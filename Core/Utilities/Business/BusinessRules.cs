using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    
    public class BusinessRules
    {
        //params IResult[] logics istedigimiz sayıda logic verebiliriz demek. Basarısız olanları bulma methodu.
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (logic.Success==false)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
