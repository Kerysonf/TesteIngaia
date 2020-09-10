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
            return @"MYSQLCONNSTR_localdb;";
        }
    }
}