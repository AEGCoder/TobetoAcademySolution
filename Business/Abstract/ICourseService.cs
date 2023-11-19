using Core.Utilities.Results;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetAllByCategoryId(int id);
        IDataResult<List<Course>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDTO>> GetProductDetailDTOs();
        IDataResult<Course> GetById (int courseId);
        IResult Add(Course course);
    }
}
