using Courses_MVC.Data;
using Courses_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Controllers
{
    public class CoursesController : Controller
    {
        private readonly CoursesContext _context;

        public CoursesController(CoursesContext context)
        {
            _context = context;
        }
        [TempData]
        public string StatusMessage { get; set; }
        public IActionResult DanhSachHienThi()
        {
            var listTopic = _context.Topic.ToList();
            ViewBag.listTopic = listTopic;
            var listCourse = _context.Courses.Include(c => c.Discount).Include(c => c.Topic);
            return View(listCourse.ToList());
        }

        [HttpPost]
        public IActionResult DanhSachHienThi(string? courestitle)
        {
            var listTopic = _context.Topic.ToList();
            ViewBag.listTopic = listTopic;
            var coursesContext = (from cs in _context.Courses
                                  select cs);
            if (!string.IsNullOrEmpty(courestitle))
            {
                coursesContext = coursesContext.Where(c => c.courseName.Contains(courestitle)).Include(c => c.Discount).Include(c => c.Topic);
            }
            else
            {
                StatusMessage = $"Không tìm thấy";
                coursesContext = _context.Courses.Include(c => c.Discount).Include(c => c.Topic);
            }
            return View(coursesContext.ToList());
        }

        public async Task<IActionResult> listCourseAdmin()
        {
            var listCourse = _context.Courses
                            .Include(d => d.Discount).Include(t => t.Topic)
                            .ToListAsync();
            return View(await listCourse);
        }
        [HttpPost]

        public async Task<IActionResult> listCourseAdmin(string? searchString)
        {
            var listCourse = (from cs in _context.Courses
                              select cs);
            if (!string.IsNullOrEmpty(searchString))
            {
                listCourse = listCourse.Where(c => c.courseName.Contains(searchString)).Include(d => d.Discount).Include(t => t.Topic);
            }
            else
            {
                listCourse = _context.Courses.Include(d => d.Discount).Include(t => t.Topic); 
            }
            return View(await listCourse.ToArrayAsync());
        }
        // GET: Courses
        public async Task<IActionResult> Index()
        {
            var coursesContext = _context.Courses.Include(c => c.Discount).Include(c => c.Topic);
            return View(await coursesContext.ToListAsync());
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var course = (from cs in _context.Courses
                          join tp in _context.Topic on cs.topicId equals tp.topicId
                          join dc in _context.Discounts on cs.discountId equals dc.discountId
                          select cs)
                         .Include(c => c.Topic)
                         .Include(c => c.Discount)
                         .FirstOrDefaultAsync(c => c.courseId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(await course);
        }

        // GET: Courses/Create

        public IActionResult CreateCourse()
        {
            ViewData["discountId"] = new SelectList(_context.Discounts, "discountId", "discription");
            ViewData["topicId"] = new SelectList(_context.Topic, "topicId", "topicName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                StatusMessage = $"Thêm thành công";
                return RedirectToAction(nameof(listCourseAdmin));
            }
            else
            {
                StatusMessage = $"Thêm không thành công";
                return RedirectToAction(nameof(listCourseAdmin));
            }
            ViewData["discountId"] = new SelectList(_context.Discounts, "discountId", "discription", course.discountId);
            ViewData["topicId"] = new SelectList(_context.Topic, "topicId", "topicName", course.topicId);

            return View();
        }



        public async Task<IActionResult> UpdateCourse(int? id)
        {
            if (id == null)
            {
                return NoContent();
            }

            var courseUpdate = await _context.Courses
                               .FindAsync(id);
            if (courseUpdate == null)
            {
                return NotFound();
            }
            ViewData["discountId"] = new SelectList(_context.Discounts, "discountId", "discription", courseUpdate.discountId);
            ViewData["topicId"] = new SelectList(_context.Topic, "topicId", "topicName", courseUpdate.topicId);
            return View(courseUpdate);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateCourse(int? id, Course updateCourse)
        {
            if(ModelState.IsValid)
            {
                Course Course = await _context.Courses.FirstOrDefaultAsync(c => c.courseId == updateCourse.courseId);
                Course.courseName = updateCourse.courseName;
                Course.discription = updateCourse.discription;
                Course.price = updateCourse.price;
                Course.topicId = updateCourse.topicId;
                Course.discountId = updateCourse.discountId;
                Course.totalTime = updateCourse.totalTime;
                Course.totalStudent = updateCourse.totalStudent;
                Course.imgCourse = updateCourse.imgCourse;
                Course.originalPrice = updateCourse.originalPrice;
                _context.SaveChanges();
                StatusMessage = $"Cập nhật thành công";
                return RedirectToAction(nameof(listCourseAdmin));
            } 
            else
            {
                StatusMessage = $"Cập nhật không thành công";
                return RedirectToAction(nameof(listCourseAdmin));
            }    
            
            //if (id != updateCourse.courseId)
            //{
            //    return NotFound();
            //}
            //if(ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(updateCourse);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch
            //    {
            //        if(!CourseExists(updateCourse.courseId))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(listCourseAdmin));
            //}

            //ViewData["discountId"] = new SelectList(_context.Discounts, "discountId", "discription", updateCourse.discountId);
            //ViewData["topicId"] = new SelectList(_context.Topic, "topicId", "topicName", updateCourse.topicId);
            //return View(updateCourse);
        }



        public async Task<IActionResult> DeleteCourse(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var courseDelete = await _context.Courses
                                    .Include(c => c.Topic)
                                    .Include(c => c.Discount)
                                    .FirstOrDefaultAsync(c => c.courseId == id);
            if (courseDelete == null)
            {
                return NotFound();
            }
            return View(courseDelete);
        }
        [HttpPost, ActionName("DeleteCourse")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCoureConform(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var course = await _context.Courses
                        .Include(c => c.Topic)
                        .Include(c => c.Discount)
                        .FirstOrDefaultAsync(c => c.courseId == id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            StatusMessage = $"Xóa thành công";
            return RedirectToAction(nameof(listCourseAdmin));
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.courseId == id);
        }
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var course = await _context.Courses
        //        .Include(c => c.Discount)
        //        .Include(c => c.Topic)
        //        .FirstOrDefaultAsync(m => m.courseId == id);
        //    if (course == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(course);
        //}

        //// POST: Courses/Delete/5

        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var course = await _context.Courses.FindAsync(id);
        //    _context.Courses.Remove(course);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}



        //[HttpPost]
        //[ValidateAntiForgeryToken]








        //public IActionResult Create()
        //{
        //    ViewData["discountId"] = new SelectList(_context.Discounts, "discountId", "discription");
        //    ViewData["topicId"] = new SelectList(_context.Topic, "topicId", "topicName");
        //    return View();
        //}

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        //public async Task<IActionResult> Create([Bind("courseId,courseName,discription,price,originalPrice,totalTime,totalStudent,topicId,discountId")] Course course)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(course);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["discountId"] = new SelectList(_context.Discounts, "discountId", "discription", course.discountId);
        //    ViewData["topicId"] = new SelectList(_context.Topic, "topicId", "topicName", course.topicId);
        //    return View(course);
        //}

        //// GET: Courses/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var course = await _context.Courses.FindAsync(id);
        //    if (course == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["discountId"] = new SelectList(_context.Discounts, "discountId", "discription", course.discountId);
        //    ViewData["topicId"] = new SelectList(_context.Topic, "topicId", "topicName", course.topicId);
        //    return View(course);
        //}

        //// POST: Courses/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("courseId,courseName,discription,price,originalPrice,imgCourse,totalTime,totalStudent,topicId,discountId")] Course course)
        //{
        //    if (id != course.courseId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(course);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CourseExists(course.courseId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["discountId"] = new SelectList(_context.Discounts, "discountId", "discription", course.discountId);
        //    ViewData["topicId"] = new SelectList(_context.Topic, "topicId", "topicName", course.topicId);
        //    return View(course);
        //}

        // GET: Courses/Delete/5
    }
}
