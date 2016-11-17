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
	public partial class PersonUserControl : UserControl
	{
		public Person Person
		{
			get
			{
				Person person = new Person();
				person.MainDetail = this.personDetailUserControl.detail;
				person.PartnerDetail = this.PartnerDetailUserControl.detail;
				person.DisplayName = this.titleTextBox.Text;
				return person;
			}
			set
			{
				this.personDetailUserControl.detail = value.MainDetail;
				this.PartnerDetailUserControl.detail = value.PartnerDetail;
				this.titleTextBox.Text = value.DisplayName;
			}
		}
		public Detail MainDetail
		{
			get
			{
				Detail mainDetail = new Detail();
				mainDetail = this.personDetailUserControl.detail;
				return mainDetail;
			}
			set
			{
				this.personDetailUserControl.detail = value;
			}
		}
		public Detail PartnerDetail
		{
			get
			{
				Detail partnerDetail = new Detail();
				partnerDetail = this.PartnerDetailUserControl.detail;
				return partnerDetail;
			}
			set
			{
				this.PartnerDetailUserControl.detail = value;
			}
		}
		public string DisplayName
		{
			get
			{
				Person person = new Person();
				// person.MainDetail = this.personDetailUserControl.detail;
				// person.PartnerDetail = this.PartnerDetailUserControl.detail;
				person.DisplayName = this.titleTextBox.Text;
				return person.DisplayName;
			}
			set
			{
				//this.personDetailUserControl.detail = value.MainDetail;
				//this.PartnerDetailUserControl.detail = value.PartnerDetail;
				this.titleTextBox.Text = value;
			}
		}
		public PersonUserControl()
		{
			InitializeComponent();
		}
	}
}
