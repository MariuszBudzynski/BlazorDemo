using BlazorDemo.Models;
using NWdatabase.Models;

namespace BlazorDemo.Repositories
{
	public interface IModdelMapper
	{
		Employee ModelEEtoEmployee(EmployeeModel employeeModel);
		EmployeeModel EmployeetoModelEE(Employee employeeModel);
	}
}