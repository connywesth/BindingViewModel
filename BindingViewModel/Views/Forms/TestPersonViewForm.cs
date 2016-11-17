using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BindingViewModel.Models;

namespace BindingViewModel.Views
{
	public partial class TestPersonViewForm : Form
	{
		//Person person;
		public TestPersonViewForm()
		{
			InitializeComponent();

			//person = new Person();
			//this.titleTextBox.DataBindings.Add("Text", person, "DisplayName");
			//this.firstNameTextBox.DataBindings.Add("Text", person.MainDetail, "FirstName");
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
