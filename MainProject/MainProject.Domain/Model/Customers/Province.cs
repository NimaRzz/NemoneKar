using MainProject.Domain.Model.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Domain.Model.Customers
{
	public class Province
	{
		[Key]
		public long Id { get; set; }

		public string Name { get; set; }

		public ICollection<City> Cities { get; set; }
	}
}
