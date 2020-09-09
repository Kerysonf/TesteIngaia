using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteIngaia.Models
{
    public class Retorno<T>
    {
        public T ObjectReturn { get; set; }
        public Exception Exception { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}