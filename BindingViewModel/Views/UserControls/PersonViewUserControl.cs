using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BindingViewModel.Models;

namespace BindingViewModel.Views
{
	public partial class PersonViewUserControl : UserControl
	{
		public PersonViewUserControl()
		{
			InitializeComponent();
			this.personUserControl1.DataBindings.Add("DisplayName", personViewModelBindingSource, "DisplayName");
			this.personUserControl1.DataBindings.Add("MainDetail", personViewModelBindingSource, "MainDetail");
			this.personUserControl1.DataBindings.Add("PartnerDetail", personViewModelBindingSource, "PartnerDetail");
		}

		private void PersonViewUserControl_Load(object sender, EventArgs e)
		{
			if(personViewModelBindingSource.Position >= 0)
			{
				Person p = (Person)this.personViewModelBindingSource.List[personViewModelBindingSource.Position];
			}

		}
	}
}
