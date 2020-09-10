using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteIngaia.DAL
{
    public class MasterDAL
    {
        public string StringConnection { get; set; }
        public MasterDAL() 
        {
            StringConnection = GetConnection();
        }
        private string GetConnection() 
        {
            return @"Server=testeingaia.database.windows.net;Database=Cadastros;User Id=keryson;password=teste@0309";
        }
    }
}