using CommonDLL.DTO;
using DatabaseDLL.DatabaseRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicDLL.LogicRepo
{
    public class BreakdownLogic
    {

        readonly BreakdownRepository repo = new BreakdownRepository();

        public List<BreakdownDTO> GetAll()
        {
            return repo.GetAll();

        }
        public void AddBreakdown(string BreakdownReference, string CompanyName, string DriverName, string RegistrationNumber, DateTime BreakdownDate)
        {
            repo.AddBreakdown(BreakdownReference, CompanyName, DriverName, RegistrationNumber, BreakdownDate);
        }
        public int EditBreakdown(int Id, string BreakdownReference, string CompanyName, string DriverName, string RegistrationNumber, DateTime BreakdownDate)
        {
            return repo.EditBreakdown(Id, BreakdownReference, CompanyName, DriverName, RegistrationNumber, BreakdownDate);
        }

        public BreakdownDTO GetDetailsById(int Id)
        {
            return repo.GetDetailsById(Id);

        }
    }
}
