using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRule
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                //Eğer başarısız ise gönderileni geri gönder.
                if (!logic.Success)//(logic.Success==false)
                {
                    return logic;
                }
            }
            return null;

        }
    }
}
