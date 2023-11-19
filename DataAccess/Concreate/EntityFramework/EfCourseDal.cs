using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, DataContext>, ICourseDal
    {
        public List<ProductDetailDTO> GetProductDetailDTOs()
        {
            using (DataContext context = new DataContext())
            {
                var result = from p in context.Courses
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDTO
                             {
                                 CourseId = p.CourseId,
                                 CourseName = p.CourseName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };
                 return result.ToList();
                
            }
        }
            
                       
    }
}
