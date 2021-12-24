using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Courses_MVC.Data;
using Courses_MVC.Models;

namespace Courses_MVC.Controllers
{
    public class LessonController : Controller
    {
        private readonly CoursesContext _context;

        public LessonController(CoursesContext context)
        {
            _context = context;
        }
       
        //Khánh Duy//
        [TempData]
        public string StatusMessage { get; set; }
        public IActionResult LessonCourse(int id)
        {
           
            var courseDetail = (_context.Lessons
                                .Where(l => l.courseId == id)
                                .Include(l => l.Course)
                                ).ToList();
            if(courseDetail.ToArray().Length ==0)
            {
                StatusMessage = "Khóa học đang được phát triển";
                return Redirect("/Courses/DanhSachHienTHi");
            }    
            else
            {
                return View(courseDetail);
            }               
        }
        public IActionResult LessonDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var lessonDetail = (_context.Lessons
                                .Include(l => l.Course)
                                ).FirstOrDefault(l => l.lessonId == id);
            if (lessonDetail == null)
            {
                return NotFound();
            }   
            var listLessonInCourseId = _context.Lessons
                                        .Include(l =>l.Course)
                                        .Where( c => c.courseId == lessonDetail.courseId)
                                        .ToList();
            ViewBag.listLesson = listLessonInCourseId.ToArray();                                                  
            var listExercise = _context.Exercises
                                .Where(e => e.lessonId == id)
                                .ToList();
            ViewBag.listExercise = listExercise;
            ViewBag.numberOfExercise = listExercise.Count();
            return View(lessonDetail);
        }

        public async Task<IActionResult> ListlessonAdmin()
        {
            var listlesson = _context.Lessons
                            .Include(l => l.Course);
            return View(await listlesson.ToListAsync()); 
            
        }
        [HttpPost]
        public async Task<IActionResult> ListlessonAdmin(string? searchString)
        {
            var listlesson = _context.Lessons
                            .Include(l => l.Course);
            if(!string.IsNullOrEmpty(searchString))
            {
                listlesson = listlesson.Where(l => l.title.Contains(searchString)).Include(l => l.Course);
            }    
            else
            {
                listlesson = _context.Lessons
                            .Include(l => l.Course);
            }
            return View(await listlesson.ToListAsync());
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lesson = await _context.Lessons
                .Include(c => c.courseId)
                .FirstOrDefaultAsync(m => m.lessonId == id);
            if (lesson == null)
            {
                return NotFound();
            }

            return View(lesson);
        }
        public IActionResult CreateLesson()
        {
            ViewData["courseId"] = new SelectList(_context.Courses, "courseId", "courseName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLesson(Lesson lesson)
        {
            if (ModelState.IsValid)
            {
                _context.Lessons.Add(lesson);
                await _context.SaveChangesAsync();
                StatusMessage = $"Thêm thành công";
                return RedirectToAction(nameof(ListlessonAdmin));
            }
            else
            {
                StatusMessage = $"Thêm không thành công";
                return RedirectToAction(nameof(ListlessonAdmin));
            }

        }

        public async Task<IActionResult> Updatelesson(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var lessonNeedUpdate = await _context.Lessons.Include(l => l.Course).FirstOrDefaultAsync(l => l.lessonId == id);
            if (lessonNeedUpdate == null)
            {
                return NotFound();
            }
            ViewData["courseId"] = new SelectList(_context.Courses, "courseId", "courseName");
            return View(lessonNeedUpdate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Updatelesson(int id, Lesson lessonUpdate)
        {
            var lesson = await _context.Lessons.FirstOrDefaultAsync(l => l.lessonId == lessonUpdate.lessonId);
            if (ModelState.IsValid)
            {
                //lesson.lessonId = lessonUpdate.lessonId;
                lesson.title = lessonUpdate.title;
                lesson.content = lessonUpdate.content;
                lesson.description = lessonUpdate.description;
                lesson.courseId = lessonUpdate.courseId;
                _context.SaveChanges();
                StatusMessage = $"Cập nhật thành công";
                return RedirectToAction(nameof(ListlessonAdmin));
            }
            else
            {
                StatusMessage = $"Cập nhật không thành công";
                return RedirectToAction(nameof(ListlessonAdmin));
            }
            
        }


        public IActionResult DeleteLesson(int? id)
        {
            

            if (id == null)
            {
                return NotFound();
            }

            var lesson = _context.Lessons.Include(l => l.Course)
                                .FirstOrDefault(m => m.lessonId == id);
            if (lesson == null)
            {
                return NotFound();
            }

            return View(lesson);
        }


        [HttpPost, ActionName("DeleteLesson")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteLessonConfirm(int? id)
        {
            var lesson = await _context.Lessons.FirstOrDefaultAsync(l => l.lessonId == id);
            if (lesson == null)
            {
                StatusMessage = $"Xóa không thành công";
                return RedirectToAction(nameof(ListlessonAdmin));
            }
            _context.Lessons.Remove(lesson);
            await _context.SaveChangesAsync();
            StatusMessage = $"Xóa thành công";
            return RedirectToAction(nameof(ListlessonAdmin));
        }
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lesson = await _context.Lessons
                .Include(c => c.courseId)
                .FirstOrDefaultAsync(m => m.lessonId == id);
            if (lesson == null)
            {
                return NotFound();
            }

            return View(lesson);
        }

        // POST: Lesson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lesson = await _context.Lessons.FindAsync(id);
            _context.Lessons.Remove(lesson);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LessonExists(int id)
        {
            return _context.Lessons.Any(e => e.lessonId == id);
        }
    }
}
