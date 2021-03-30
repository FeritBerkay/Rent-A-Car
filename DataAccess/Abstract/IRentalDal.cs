using Entities.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<RentalDetailDto> GetRentalDetails();
    }
}
