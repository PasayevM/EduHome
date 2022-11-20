using EduHome2.DAL;
using EduHome2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EduHome2.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _db;
        public CoursesController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Course> courses = _db.Courses.OrderByDescending(x=>x.Id).ToList();
            return View(courses);
        }
    }
}
