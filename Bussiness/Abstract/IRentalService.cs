using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IRentalService:IBaseService<Rental>
    {

        IDataResult<List<RentalDetailDto>> GetRentaltDetails();
    }
}
