using Microsoft.EntityFrameworkCore;
using NWdatabase.Models;

namespace BlazorDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly NorthwindContext _db;

        public EmployeeRepository(NorthwindContext db)
        {
            _db = db;
        }
        public IEnumerable<Employee> GetAllEmployees()
		{
				var query = _db.Employees
					.AsNoTracking() //this is needed in this scenario as the update will not wotk
					.AsQueryable();
				return query.ToList();
		}

		public async Task SaveEmployee(Employee employee)
		{
			_db.Add(employee);
			await _db.SaveChangesAsync();
			
		}

		public  List<string> GetDistinctTitles()
		{
			var query = _db.Employees
				.AsNoTracking()
				.AsQueryable()
				.OrderBy(t => t.Title)
				.Select(t => t.Title)
				.Distinct();
			return query.ToList();
		}

		public List<string> GetDistinctTitlesOfCourtesy()
		{
			var query = _db.Employees
				.AsNoTracking()
				.AsQueryable()
				.OrderBy(t => t.TitleOfCourtesy)
				.Select(t => t.TitleOfCourtesy)
				.Distinct();
			return query.ToList();
		}

		public int GetEmployeeByID(int id)
		{
			var query = _db.Employees
				.AsNoTracking()
				.AsQueryable()
				.Select(e=>e.EmployeeId)
				.FirstOrDefault();
			return query;
		}

		public async Task UpdateEmployee(Employee employee)
		{
			_db.ChangeTracker.Clear();
			_db.Update(employee);
			await _db.SaveChangesAsync();
		}

		public async Task DeleteEmployee(Employee employee)
		{
			_db.ChangeTracker.Clear();
			_db.Remove(employee);
			await _db.SaveChangesAsync();
		}
	}
}
