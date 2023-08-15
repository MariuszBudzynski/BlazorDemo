using NWdatabase.Models;

namespace BlazorDemo.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Task SaveEmployee(Employee employee);
		List<string> GetDistinctTitles();
		List<string> GetDistinctTitlesOfCourtesy();
        int GetEmployeeByID(int id);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(Employee employee);
	}
}
