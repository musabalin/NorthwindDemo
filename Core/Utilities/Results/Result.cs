using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //this bu sınıf demektir
        //burada bu sınıfın tek parametreli constructorunuda çalıştır demiş oluyoruz. 
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        //Normalde Success=success kendini tekrar ettiği için
        //tek parametreli constructor oluşturduk this ile bunu tetikledik.
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
