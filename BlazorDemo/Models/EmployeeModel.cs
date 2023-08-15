using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Models
{
    public class EmployeeModel
    {
		[Key]
		public int EmployeeId { get; set; }

		[Required(ErrorMessage = "Last Name field is required")]
		[StringLength(20)]
		public string LastName { get; set; } = null!;

		[Required(ErrorMessage = "First Name field is required")]
		[StringLength(10)]
		public string FirstName { get; set; } = null!;

		[Required(ErrorMessage = "Title field is required")]
		[StringLength(30)]
		public string? Title { get; set; }

		[Required(ErrorMessage = "Title Of Courtesy field is required")]
		[StringLength(25)]
		public string? TitleOfCourtesy { get; set; }

		[Required(ErrorMessage = "Birth Date field is required")]
		[DataType(DataType.Date, ErrorMessage = "Wrong Date format!")]
		public DateTime? BirthDate { get; set; }

		public DateTime? HireDate { get; set; } = DateTime.Now;

		[Required(ErrorMessage = "Address field is required")]
		[StringLength(60)]
		public string? Address { get; set; }

		[Required(ErrorMessage = "City field is required")]
		[StringLength(15)]
		public string? City { get; set; }

		[Required(ErrorMessage = "Region field is required")]
		[StringLength(15)]
		public string? Region { get; set; }

		[Required(ErrorMessage = "Postal Code field is required")]
		[StringLength(10)]
		public string? PostalCode { get; set; }

		[Required(ErrorMessage = "Country field is required")]
		[StringLength(15)]
		public string? Country { get; set; }

		[Required(ErrorMessage = "Home Phone field is required")]
		[StringLength(24)]
		public string? HomePhone { get; set; }

		[Required(ErrorMessage = "Extension field is required")]
		[StringLength(4)]
		public string? Extension { get; set; }

	}
}
