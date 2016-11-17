using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingViewModel.Models
{
	public class Person
	{
		public Int32 ID { get; set; }
		public Boolean IsMarried { get; set; }
		public String DisplayName { get; set; }
		public Detail MainDetail { get; set; }
		public Detail PartnerDetail { get; set; }

		public Person()
		{
			MainDetail = new Detail();
			PartnerDetail = new Detail();
		}
	}
}
