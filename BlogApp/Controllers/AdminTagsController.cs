using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data;
using BlogApp.Models.Domain;
using BlogApp.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BlogDbContext _blogDbContext;
        public AdminTagsController(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }

        [HttpGet] 
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            // Mapping AddTagRequest to Tag domain model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };

            _blogDbContext.Tags.Add(tag);
            _blogDbContext.SaveChanges();
            
            return View("Add");
        }
    }
}