using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        List<Course> _courses;
        public InMemoryCourseDal()
        {
            _courses = new List<Course>
            {
                new Course{CourseId =1, CategoryId = 1, CourseName = "Bardak", UnitPrice = 15, UnitsInStock = 15},
                new Course{CourseId =2, CategoryId = 1, CourseName = "Kamera", UnitPrice = 500, UnitsInStock = 3},
                new Course{CourseId =3, CategoryId = 2, CourseName = "Telefon", UnitPrice = 1500, UnitsInStock = 2},
                new Course{CourseId =4, CategoryId = 2, CourseName = "Klavye", UnitPrice = 150, UnitsInStock = 65},
                new Course{CourseId =5, CategoryId = 2, CourseName = "Fare", UnitPrice = 85, UnitsInStock = 1},

            };
        }
        public void Add(Course course)
        {
             _courses.Add(course);
        }

        public void Delete(Course course)
        {
            Course courseToDelete = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);
            _courses.Remove(courseToDelete);
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAllByCategory(int categoryId)
        {
          return _courses.Where(c => c.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDTO> GetProductDetailDTOs()
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);
            courseToUpdate.CourseName = course.CourseName;
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.UnitPrice = course.UnitPrice;
            courseToUpdate.UnitsInStock = course.UnitsInStock;
            _courses.Add(courseToUpdate);

        }
    }
}
