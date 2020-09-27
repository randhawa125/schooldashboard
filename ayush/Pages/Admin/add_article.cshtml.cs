using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ayush.Pages.Admin
{
	public class add_articleModel : PageModel
	{
		private ayushContext _context { get; set; }
		public BlogViewModel BlogVM { get; set; }

		public add_articleModel(ayushContext context)
		{
			_context = context;
		}

		public void OnGet(int? id)
		{
			if (id.HasValue)
			{
				BlogVM = _context.Blogs.Where(x => x.Id == id.Value).Select(x => new BlogViewModel()
				{
					Id = x.Id,
					ClassId = x.ClassId,
					Title = x.Title,
					Description = x.Description,
					IsActive = x.IsActive,
				}).FirstOrDefault();
			}
			else
			{
				BlogVM = new BlogViewModel();
			}
		}

		public async Task<IActionResult> OnPost(int? id, BlogViewModel blogVM)
		{
			var test = Request.Form.Files.Any();
			if (ModelState.IsValid)
			{
				var userId = User.Claims.ToList().FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

				if (id.HasValue)
				{
					var blogId = id.Value;
					var dbBlog = _context.Blogs.FirstOrDefault(x => x.Id == blogId);
					dbBlog.Title = blogVM.Title;
					dbBlog.Description = blogVM.Description;
					dbBlog.ClassId = blogVM.ClassId;
					dbBlog.IsActive = blogVM.IsActive;

					if (Request.Form.Files.Any())
					{
						var file = Request.Form.Files[0];

						var randomFileName = Guid.NewGuid() + Path.GetExtension(file.FileName);

						var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", randomFileName);

						using (var stream = new FileStream(path, FileMode.Create))
						{
							await file.CopyToAsync(stream);
						}

						dbBlog.FeaturedImagePath = randomFileName;
					}
				}
				else
				{
					var blog = new Blog()
					{
						Title = blogVM.Title,
						Description = blogVM.Description,
						IsActive = blogVM.IsActive,
						ClassId = blogVM.ClassId,
						SubmittedByUserId = userId,
						SubmittedDate = DateTime.Now
					};

					if (Request.Form.Files.Any())
					{
						var file = Request.Form.Files[0];

						var randomFileName = Guid.NewGuid() + Path.GetExtension(file.FileName);

						var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", randomFileName);

						using (var stream = new FileStream(path, FileMode.Create))
						{
							await file.CopyToAsync(stream);
						}

						blog.FeaturedImagePath = randomFileName;
					}

					_context.Blogs.Add(blog);
				}

				await _context.SaveChangesAsync();

				return Redirect("~/Admin/Blog");
			}
			else
			{
				BlogVM = blogVM;
				return Page();
			}
		}
	}
}
