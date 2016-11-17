using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingViewModel.Views
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void personViewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TestPersonViewForm testPersonViewForm = new TestPersonViewForm();
			testPersonViewForm.Show();
		}

		private void detailUserControlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TestDetailUserControlForm testDetailUserControlForm = new TestDetailUserControlForm();
			testDetailUserControlForm.Show();
		}

		private void personUserControlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TestPersonUserControlForm testPersonUserControlForm = new TestPersonUserControlForm();
			testPersonUserControlForm.Show();
		}
	}
}
