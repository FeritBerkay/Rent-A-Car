using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Entities.Concrete.Color>
    {
        
    }
}
