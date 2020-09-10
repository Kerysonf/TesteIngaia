using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using TesteIngaia.Models;

namespace TesteIngaia.DAL
{
    public class MusicasDAL : MasterDAL
    {
        public int SaveLogEstatisticas(EstatisticasModel estatisticas)
        {
            var sql = new StringBuilder();
            try
            {
                using (var conn = new SqlConnection(StringConnection))
                {
                    sql.Append(" INSERT INTO Estatisticas VALUES (@Cidade,@QntConsultas) ");
                    var retorno = conn.Execute(sql.ToString(), estatisticas);
                    return retorno;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public int UpdateLogEstatisticas(EstatisticasModel estatisticas)
        {
            var sql = new StringBuilder();
            try
            {
                using (var conn = new SqlConnection(StringConnection))
                {
                    sql.Append(" UPDATE Estatisticas SET qtdConsultas = @QntConsultas WHERE cidade = @Cidade ");
                    var retorno = conn.Execute(sql.ToString(), estatisticas);
                    return retorno;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public int GetQntdConsultas(string cidade)
        {
            var sql = new StringBuilder();
            try
            {
                using (var conn = new SqlConnection(StringConnection))
                {
                    sql.Append(" SELECT qtdConsultas FROM Estatisticas WHERE cidade = @cidade");
                    var retorno = conn.Query<int>(sql.ToString(), new { cidade }).FirstOrDefault();
                    return retorno;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<EstatisticasModel> GetEstatisticas()
        {
            var sql = new StringBuilder();
            try
            {
                using (var conn = new SqlConnection(StringConnection))
                {
                    sql.Append(" SELECT qtdConsultas as QntConsultas, cidade FROM Estatisticas");
                    var retorno = conn.Query<EstatisticasModel>(sql.ToString()).ToList();
                    return retorno;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public string GetEstatisticasByCidade(string cidade)
        {
            var sql = new StringBuilder();
            try
            {
                using (var conn = new SqlConnection(StringConnection))
                {
                    sql.Append(" SELECT cidade FROM Estatisticas WHERE cidade = @cidade");
                    var retorno = conn.Query<string>(sql.ToString(), new {cidade}).FirstOrDefault();
                    return retorno;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}