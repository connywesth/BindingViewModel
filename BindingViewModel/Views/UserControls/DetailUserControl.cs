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
	public partial class DetailUserControl : UserControl
	{
		public Detail detail
		{
			get
			{
				Detail workDetail= new Detail();
				workDetail.FirstName = this.firstNameTextBox.Text;
				workDetail.LastName = this.lastNameTextBox.Text;
				workDetail.DateOfBirth = this.dateOfBirthDateTimePicker.Value;
				workDetail.Address = this.addressTextBox.Text;
				return workDetail;
			}
			set
			{
				this.firstNameTextBox.Text= value.FirstName;
				this.lastNameTextBox.Text = value.LastName;
				if(value.DateOfBirth!=null)
				{
					value.DateOfBirth = DateTime.Now; // Debugging
					this.dateOfBirthDateTimePicker.Value = value.DateOfBirth;
				}
				else
				{
					value.DateOfBirth = DateTime.Now;// Debugging
					this.dateOfBirthDateTimePicker.Value = value.DateOfBirth;
				}
				this.addressTextBox.Text= value.Address;
			}
		}

		//public List<Binding> DetailBindings
		//{
		//	get
		//	{
		//		Detail workDetail= new Detail();
		//		workDetail.FirstName = this.firstNameTextBox.Text;
		//		workDetail.LastName = this.lastNameTextBox.Text;
		//		workDetail.DateOfBirth = this.dateOfBirthDateTimePicker.Value;
		//		workDetail.Address = this.addressTextBox.Text;
		//		return workDetail;
		//	}
		//	set
		//	{
		//		this.firstNameTextBox.Text = value.FirstName;
		//		this.lastNameTextBox.Text = value.LastName;
		//		if(value.DateOfBirth != null)
		//		{
		//			value.DateOfBirth = DateTime.Now; // Debugging
		//			this.dateOfBirthDateTimePicker.Value = value.DateOfBirth;
		//		}
		//		else
		//		{
		//			value.DateOfBirth = DateTime.Now;// Debugging
		//			this.dateOfBirthDateTimePicker.Value = value.DateOfBirth;
		//		}
		//		this.addressTextBox.Text = value.Address;
		//	}
		//}

		public DetailUserControl()
		{
			InitializeComponent();
		}
	}
}

