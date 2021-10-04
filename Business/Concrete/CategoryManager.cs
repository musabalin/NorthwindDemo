using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public IDataResult<List<Category>>  GetAll()
        {
            return new SuccessDataResult<List<Category>>();
        }

        public IDataResult<Category> GetByInt(int categoryId)
        {

            return new SuccessDataResult<Category>(_categorydal.Get(c => c.CategoryId == categoryId));
        }
    }
}
