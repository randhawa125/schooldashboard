using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ayush.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpPost]
        [Route("Pay")]
        public async Task Pay(FormCollection form)
        {
            var firstName = form["txtfirstname"];
            var amount = form["txtamount"];
            var productInfo = form["txtprodinfo"];
            var email = form["txtemail"];
            var phone = form["txtphone"];
            //var key = ConfigurationManager.AppSettings["MERCHANT_KEY"];
            //var salt = ConfigurationManager.AppSettings["SALT"];
            var key = "";
            var salt = "";

            //var myremotepost = new RemotePost { Url = ConfigurationManager.AppSettings["PAYU_BASE_URL"] + "/_payment" };
            var myremotepost = new RemotePost { Url = "/_payment" };
            myremotepost.Add("key", key);
            myremotepost.Add("txnid", Generatetxnid());
            myremotepost.Add("amount", amount);
            myremotepost.Add("productinfo", productInfo);
            myremotepost.Add("firstname", firstName);
            myremotepost.Add("phone", phone);
            myremotepost.Add("email", email);
            myremotepost.Add("surl", "http://localhost:3271/Return/Return");
            myremotepost.Add("furl", "http://localhost:3271/Return/Return");
            myremotepost.Add("service_provider", "payu_paisa");

            string hashString = key + "|" + Generatetxnid() + "|" + amount + "|" + productInfo + "|" + firstName + "|" + email + "|||||||||||" + salt;
            //string hashString = "3Q5c3q|2590640|3053.00|OnlineBooking|vimallad|ladvimal@gmail.com|||||||||||mE2RxRwx";
            string hash = Generatehash512(hashString);

            //var hashString = key + "|" + Generatetxnid() + "|" + amount + "|" + productInfo + "|" + firstName + "|" + email + "|||||||||||" + salt;
            //var hash = Generatehash512(hashString);
            myremotepost.Add("hash", hash);
            await myremotepost.Post(Response);
        }

        [HttpPost]
        public async Task Return(FormCollection form)
        {
            try
            {
                const string hashSeq = "key|txnid|amount|productinfo|firstname|email|udf1|udf2|udf3|udf4|udf5|udf6|udf7|udf8|udf9|udf10";

                if (form["status"] == "success")
                {

                    var mercHashVarsSeq = hashSeq.Split('|');
                    Array.Reverse(mercHashVarsSeq);
                    //var mercHashString = ConfigurationManager.AppSettings["SALT"] + "|" + form["status"];
                    var mercHashString = "";


                    foreach (var mercHashVar in mercHashVarsSeq)
                    {
                        mercHashString += "|";
                        mercHashString = mercHashString + (form[mercHashVar].Any() ? form[mercHashVar].ToString() : "");

                    }
                    await Response.WriteAsync(mercHashString);
                    var mercHash = Generatehash512(mercHashString).ToLower();

                    if (mercHash != form["hash"])
                    {
                        await Response.WriteAsync("Hash value did not matched");

                    }
                    else
                    {
                        //ViewData["Message"] = "Status is successful. Hash value is matched";
                        await Response.WriteAsync("<br/>Hash value matched");
                    }
                }
                else
                {
                    await Response.WriteAsync("Hash value did not matched");
                }
            }
            catch (Exception ex)
            {
                await Response.WriteAsync("<span style='color:red'>" + ex.Message + "</span>");
            }
        }

        public class RemotePost
        {
            public readonly System.Collections.Specialized.NameValueCollection Inputs = new System.Collections.Specialized.NameValueCollection();

            public string Url = "";
            public string Method = "post";
            public string FormName = "form1";

            public void Add(string name, string value)
            {
                Inputs.Add(name, value);
            }

            public async Task Post(HttpResponse response)
            {
                response.Clear();

                await response.WriteAsync("<html><head>");

                await response.WriteAsync($"</head><body onload=\"document.{FormName}.submit()\">");
                await response.WriteAsync($"<form name=\"{FormName}\" method=\"{Method}\" action=\"{Url}\" >");
                for (var i = 0; i < Inputs.Keys.Count; i++)
                {
                    await response.WriteAsync($"<input name=\"{Inputs.Keys[i]}\" type=\"hidden\" value=\"{Inputs[Inputs.Keys[i]]}\">");
                }
                await response.WriteAsync("</form>");
                await response.WriteAsync("</body></html>");
            }
        }


        public string Generatehash512(string text)
        {
            var message = Encoding.UTF8.GetBytes(text);
            var hashString = new SHA512Managed();
            var hashValue = hashString.ComputeHash(message);
            return hashValue.Aggregate("", (current, x) => current + $"{x:x2}");
        }


        public string Generatetxnid()
        {
            var rnd = new Random();
            var strHash = Generatehash512(rnd.ToString() + DateTime.Now);
            var txnid1 = strHash.Substring(0, 20);
            return txnid1;
        }
    }
}