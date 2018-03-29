using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogdoErnandi.Models;

namespace BlogdoErnandi.Controllers
{
    public class PostsController : Controller
    {
        private BlogContext _context = new BlogContext();

        // GET: Posts
        public ActionResult Index()
        {
            var posts = _context.Posts.ToList();
            return View();
        }
        public ActionResult Details(int id)

        {
            var post = _context.Posts.SingleOrDefault(p => p.Id == id);
            if(post==null)
            {
                return HttpNotFound();
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Deletecomplete(int id)
        {
            return View();
        }
        public ActionResult Save(Post post)
        {
            return View();
        }
    }
}