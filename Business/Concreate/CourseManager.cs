using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class CourseManager : ICourseService
    {
           ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
             _courseDal = courseDal;
        }

       
        public IResult Add(Course course)
        {

            if (course.CourseName.Length < 2)
            {
                return new ErrorResult(Messages.CourseNameInvalid);
            }
            _courseDal.Add(course);
   
            return new Result(Messages.CourseAdded);
        }

        public IDataResult<List<Course>> GetAll()

        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Course>>(Messages.MainTenanceTime);
            }

            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(),Messages.CoursesListed);
        }

        public IDataResult<List<Course>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p => p.CategoryId == id));
            
        }

        public IDataResult<Course> GetById(int courseId)
        {
           return new SuccessDataResult<Course>(_courseDal.Get(p => p.CourseId == courseId));
        }

        public SuccessDataResult<List<Course>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public SuccessDataResult<List<ProductDetailDTO>> GetProductDetailDTOs()
        {
           return new SuccessDataResult<List<ProductDetailDTO>>(_courseDal.GetProductDetailDTOs());
        }

        IDataResult<List<Course>> ICourseService.GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        IDataResult<Course> ICourseService.GetById(int courseId)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Course>> ICourseService.GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<ProductDetailDTO>> ICourseService.GetProductDetailDTOs()
        {
            throw new NotImplementedException();
        }
    }
}
