using Microsoft.AspNetCore.DataProtection.Internal;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CourseController : Controller
    {
        private readonly DataContext _context;
        public CourseController(DataContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Get Courses Method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var courses = _context.Courses.Where(x => x.Id == id).FirstOrDefault();
            return View(courses);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var courses = _context.Courses.Where(x => x.Id == id).FirstOrDefault();
            return View(courses);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var courses = _context.Courses.Where(x => x.Id == id).FirstOrDefault();
            return View(courses);
        }

        /// <summary>
        /// Post Course Methods
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(Course course)
        {
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
