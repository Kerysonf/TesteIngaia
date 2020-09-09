using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TesteIngaia.BLL;
using TesteIngaia.Models;

namespace TesteIngaia.Controllers
{
    public class MusicasController : ApiController
    {
        public Retorno<List<string>> GetMusicasByTemperatura(string Cidade) 
        {
            var retorno = new Retorno<List<string>>();
            var musicaBLL = new MusicasBLL();
            try
            {
                if (!String.IsNullOrEmpty(Cidade))
                {
                    retorno.ObjectReturn = musicaBLL.GetMusicasByCidade(Cidade);
                    retorno.Success = true;
                }
                else
                {
                    retorno.Message = "O parametro 'Cidade' não pode ser vazio ou nulo";
                    retorno.Success = false;
                }
            }
            catch ( Exception ex)
            {
                retorno.Success = false;
                retorno.ObjectReturn = null;
                retorno.Message = ex.Message;
                retorno.Exception = ex;
            }
            return retorno;
        }
    }
}
