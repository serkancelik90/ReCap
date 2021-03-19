using Core.Utilities.Results;
using ReCap.Business.Abstract;
using ReCap.Business.Constants;
using ReCap.DataAccess.Abstract;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Delete(int colorId)
        {
           var deletedColor =  _colorDal.Get(x => x.ColorId == colorId);
            _colorDal.Delete(deletedColor);
            return new SuccessResult();

        }

        public IDataResult<List<Color>> GetAll()
        {
           return new SuccessDataResult<List<Color>> (_colorDal.GetAll());
        }
    }
}
