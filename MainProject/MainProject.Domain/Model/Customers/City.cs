using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Domain.Model.Commons;

namespace MainProject.Domain.Model.Customers
{
	public class City
	{
		[Key]
		public long Id { get; set; }

		public string Name { get; set; }

		public long ProvinceId { get; set; }

		public Province Province { get; set; }
	}
}
