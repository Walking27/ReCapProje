using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;

using System.Text;

namespace Business.Abstract
{
    public interface IColorSevice
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetById(int colorId);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(int color);
    }
}
