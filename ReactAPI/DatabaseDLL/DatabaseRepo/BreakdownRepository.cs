using CommonDLL.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDLL.DatabaseRepo
{
    public class BreakdownRepository
    {
        public List<BreakdownDTO> GetAll()
        {
            using (IDbConnection connection = new SqlConnection(CommonDLL.Helper.Connection.ConnectionString()))
            {
                return connection.Query<BreakdownDTO>("SELECT * from Breakdowns", commandType: CommandType.Text).ToList();
            }
        }

        public void AddBreakdown(string BreakdownReference, string CompanyName, string DriverName, string RegistrationNumber, DateTime BreakdownDate)
        {
            using (IDbConnection connection = new SqlConnection(CommonDLL.Helper.Connection.ConnectionString()))
            {
                string sql = @"INSERT INTO Breakdowns (BreakdownReference, CompanyName, DriverName, RegistrationNumber, BreakdownDate) VALUES (@BreakdownReference, @CompanyName, @DriverName, @RegistrationNumber, @BreakdownDate)";

                connection.Execute(sql, new { BreakdownReference, CompanyName, DriverName, RegistrationNumber, BreakdownDate });
            }
        }

        public int EditBreakdown(int Id, string BreakdownReference, string CompanyName, string DriverName, string RegistrationNumber, DateTime BreakdownDate)
        {
            using (IDbConnection connection = new SqlConnection(CommonDLL.Helper.Connection.ConnectionString()))
            {
                var query = @"UPDATE [Breakdowns]  SET BreakdownReference = @BreakdownReference, CompanyName = @CompanyName, DriverName = @DriverName, RegistrationNumber = @RegistrationNumber,  BreakdownDate = @BreakdownDate WHERE Id = @Id";

                var count = connection.Execute(query, new { Id = Id, BreakdownReference = BreakdownReference, CompanyName = CompanyName, DriverName = DriverName, RegistrationNumber = RegistrationNumber, BreakdownDate = BreakdownDate }, commandType: CommandType.Text);

                if (count != 1)
                {
                    throw new Exception("Update failed.");
                }

                return count;
            }
        }

        public BreakdownDTO GetDetailsById(int Id)
        {
            using (IDbConnection connection = new SqlConnection(CommonDLL.Helper.Connection.ConnectionString()))
            {
                return connection.QueryFirstOrDefault<BreakdownDTO>("SELECT * from Breakdowns where Id = @Id", new { Id = Id }, commandType: CommandType.Text);
            }
        }

    }
}
