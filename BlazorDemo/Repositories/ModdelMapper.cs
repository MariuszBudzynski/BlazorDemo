using BlazorDemo.Models;
using NWdatabase.Models;

namespace BlazorDemo.Repositories
{
	public class ModdelMapper : IModdelMapper
	{
		public EmployeeModel EmployeetoModelEE(Employee employee)
		{
			if (employee is not null)
			{
				EmployeeModel mappedEmployee = new EmployeeModel()
				{
					EmployeeId = employee.EmployeeId,
					LastName = employee.LastName,
					FirstName = employee.FirstName,
					Title = employee.Title,
					TitleOfCourtesy = employee.TitleOfCourtesy,
					BirthDate = employee.BirthDate,
					HireDate = employee.HireDate,
					Address = employee.Address,
					City = employee.City,
					Region = employee.Region,
					PostalCode = employee.PostalCode,
					Country = employee.Country,
					HomePhone = employee.HomePhone,
					Extension = employee.Extension
				};
				return mappedEmployee;
			}
			else
			{
				EmployeeModel mappedEmployee = null;
				return mappedEmployee;
			}
		}

		public Employee ModelEEtoEmployee(EmployeeModel employeeModel)
		{
			if (employeeModel is not null)
			{


				Employee mappedEmployee = new Employee()
				{
					EmployeeId = employeeModel.EmployeeId,
					LastName = employeeModel.LastName,
					FirstName = employeeModel.FirstName,
					Title = employeeModel.Title,
					TitleOfCourtesy = employeeModel.TitleOfCourtesy,
					BirthDate = employeeModel.BirthDate,
					HireDate = employeeModel.HireDate,
					Address = employeeModel.Address,
					City = employeeModel.City,
					Region = employeeModel.Region,
					PostalCode = employeeModel.PostalCode,
					Country = employeeModel.Country,
					HomePhone = employeeModel.HomePhone,
					Extension = employeeModel.Extension
				};
				return mappedEmployee;
			}
			else
			{
				Employee mappedEmployee = null;
				return mappedEmployee;
			}
		}
	}
}
