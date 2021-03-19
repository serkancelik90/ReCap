using Core.Utilities.Results;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Delete(int colorId);
        IDataResult<List<Color>> GetAll();

    }
}
