using System;
namespace EntityFramework.Models
{
	public class User
	{
		public int UserID { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Surname { get; set; } = string.Empty;
		public int CountryId { get; set; }

	}
}

