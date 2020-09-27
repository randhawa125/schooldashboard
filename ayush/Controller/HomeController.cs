using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using ayush.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ayush.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private ayushContext _context { get; set; }
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly ISmsService _smsService;
        private readonly IConfiguration _configuration;
        public HomeController(ayushContext context, UserManager<IdentityUser> userManager, IEmailSender emailSender, ISmsService smsService, IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _emailSender = emailSender;
            _smsService = smsService;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("validate")]
        public async Task<IActionResult> ValidateEmailAndSendCode(string emailAddress)
        {
            var user = await _userManager.FindByEmailAsync(emailAddress);

            if (user == null)
            {
                Random generator = new Random();
                string code = generator.Next(0, 999999).ToString("D6");

                //var userInformation = new UserInformation() { Code = code, CodeSentOn = DateTime.UtcNow };
                var otp = new OneTimePassword() { Key = emailAddress, Value = code, CreatedOn = DateTime.Now };
                await _context.OneTimePasswords.AddAsync(otp);
                await _context.SaveChangesAsync();

                string message = $"Your UPCLASS OTP is <h1>{code}</h1>. This code is valid for next 15 minutes only.";
                await _emailSender.SendEmailAsync(emailAddress, "UPCLASS OTP", message);

                return new JsonResult(new { isExist = false, code });
            }

            return new JsonResult(new { isExist = true });
        }

        [HttpGet]
        [Route("validatephone")]
        public async Task<IActionResult> ValidatePhoneAndSendOTP(string phoneNumber)
        {
            var user = _context.Users.FirstOrDefault(x => x.PhoneNumber == phoneNumber);

            if (user == null)
            {
                Random generator = new Random();
                string code = generator.Next(0, 999999).ToString("D6");

                var otp = new OneTimePassword() { Key = phoneNumber, Value = code, CreatedOn = DateTime.Now };
                await _context.OneTimePasswords.AddAsync(otp);
                await _context.SaveChangesAsync();

                string message = $"Your UPCLASS OTP is {code}. This code is valid for next 15 minutes only.";
                _smsService.SendSMS(message, phoneNumber);

                return new JsonResult(new { isExist = false, code });
            }

            return new JsonResult(new { isExist = true });
        }

        [HttpGet]
        [Route("validatePhoneForgotPassword")]
        public async Task<IActionResult> ValidatePhoneForgotPassword(string phoneNumber)
        {
            var user = _context.Users.FirstOrDefault(x => x.PhoneNumber == phoneNumber);

            if (user != null)
            {
                Random generator = new Random();
                string code = generator.Next(0, 999999).ToString("D6");

                var otp = new OneTimePassword() { Key = phoneNumber, Value = code, CreatedOn = DateTime.Now };
                await _context.OneTimePasswords.AddAsync(otp);
                await _context.SaveChangesAsync();

                string message = $"Your UPCLASS OTP is {code}. This code is valid for next 15 minutes only.";
                _smsService.SendSMS(message, phoneNumber);

                return new JsonResult(new { isExist = true, code });
            }

            return new JsonResult(new { isExist = false });
        }

        [HttpGet]
        [Route("validateotp")]
        public async Task<IActionResult> ValidateMobileOTP(string code, string phoneNumber)
        {
            var otp = _context.OneTimePasswords.OrderByDescending(x => x.CreatedOn).FirstOrDefault(x => x.Key == phoneNumber);
            if(otp != null)
            {
                if (otp.Value == code && otp.CreatedOn.AddMinutes(15) >= DateTime.Now && otp.IsKeyUsed == false)
                {
                    otp.IsKeyUsed = true;
                    _context.SaveChanges();
                    return new JsonResult(new { isValid = true });
                }
            }
            return new JsonResult(new { isValid = false });
        }

        [HttpGet]
        [Route("validatePasswordResetOTP")]
        public async Task<IActionResult> ValidatePasswordResetMobileOTP(string code, string phoneNumber)
        {
            var otp = _context.OneTimePasswords.OrderByDescending(x => x.CreatedOn).FirstOrDefault(x => x.Key == phoneNumber);
            if (otp != null)
            {
                if (otp.Value == code && otp.CreatedOn.AddMinutes(15) >= DateTime.Now && otp.IsKeyUsed == false)
                {
                    otp.IsKeyUsed = true;
                    _context.SaveChanges();

                    var user = _context.Users.FirstOrDefault(x => x.PhoneNumber == phoneNumber);
                    var secretCode = await _userManager.GeneratePasswordResetTokenAsync(user);
                    secretCode = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(secretCode));

                    return new JsonResult(new { isValid = true, secretCode });
                }
            }
            return new JsonResult(new { isValid = false });
        }

        [HttpGet]
        [Route("validateemailotp")]
        public async Task<IActionResult> ValidateEmailOTP(string code, string emailAddress, string referredBy)
        {
            using (IDbContextTransaction transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var otp = await _context.OneTimePasswords.OrderByDescending(x => x.CreatedOn).FirstOrDefaultAsync(x => x.Key == emailAddress);
                    if (otp != null)
                    {
                        if (otp.Value == code && otp.CreatedOn.AddMinutes(15) >= DateTime.Now && otp.IsKeyUsed == false)
                        {
                            otp.IsKeyUsed = true;
                            await _context.SaveChangesAsync();

                            //Make an entry in the RewardsRegister
                            var reg = new RewardsRegister()
                            {
                                UserId = referredBy,
                                RegisteredUserEmail = emailAddress,
                                RewardPoints = 100,
                                RewardDate = DateTime.Now
                            };
                            _context.Entry(reg).State = EntityState.Added;
                            await _context.SaveChangesAsync();

                            await transaction.CommitAsync();
                            return new JsonResult(new { isValid = true });
                        }
                    }
                    return new JsonResult(new { isValid = false });
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    return StatusCode(500, ex.Message);
                }                
            }
        }

        private async Task<IActionResult> ValidateCode(string code, IdentityUser user)
        {
            if (user == null)
            { return new JsonResult(new { isValid = false }); }

            var info = await _context.UserInformation.FirstOrDefaultAsync(x => x.UserId == user.Id);

            if (info == null)
            { return new JsonResult(new { isValid = false }); }

            if (info.Code != null && info.Code.Equals(code) && info.CodeSentOn.Value.AddMinutes(15) >= DateTime.Now && !info.IscodeUsed.Value)
            {
                return new JsonResult(new { isValid = true });
            }

            return new JsonResult(new { isValid = false });
        }

        [HttpPost]
        [Route("uploadImage")]
        public JsonResult UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];

                var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                var newImage = new Image() { Name = fileName };

                _context.Images.Add(newImage);

                if (_context.SaveChanges() > 0)
                {
                    return new JsonResult(new { Success = true, Image = fileName, File = newImage.Id, ImageURL = string.Format("{0}{1}", "/uploads/", fileName) });
                }
                else
                {
                    return new JsonResult(new { Success = false, Message = StatusCode(500) });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new { Success = false, Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("SendInviteEmail")]
        public async Task<IActionResult> SendInviteEmail(EmailViewModel email)
        {
            try
            {
                var user = await _userManager.GetUserAsync(User);
                var url = _configuration.GetValue<string>("WebsiteURL");
                await _emailSender.SendEmailAsync(email.emailaddress, email.emailSubject, email.emailBody.Replace("\n", "<br>").Replace(url + "?invitedBy=" + user.Id, "<a href='" + url + "?invitedBy=" + user.Id + "'>" + url + "?invitedBy=" + user.Id + "</a>"));
                return Ok("Invited Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An unexpected error occured! " + ex.ToString());
            }
        }

        [HttpPost]
        [Route("Feedback")]
        public async Task<IActionResult> Feedback(FeedbackFormModel feedback)
        {
            var user = await _userManager.GetUserAsync(User);
            if (_context.Feedback.Any(x => x.UserId == user.Id))
            {
                return BadRequest("You have already submitted a feedback");
            }
            else
            {
                feedback.UserId = user.Id;
                await _context.Feedback.AddAsync(feedback);
                await _context.SaveChangesAsync();
                return Ok();
            }
        }
    }
}
