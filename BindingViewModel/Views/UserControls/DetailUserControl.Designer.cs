namespace BindingViewModel.Views
{
	partial class DetailUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.lblDateOfBirth = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(78, 0);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(262, 20);
			this.firstNameTextBox.TabIndex = 3;
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(-1, 3);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(54, 13);
			this.lblFirstName.TabIndex = 5;
			this.lblFirstName.Text = "FirstName";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(-1, 29);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(55, 13);
			this.lblLastName.TabIndex = 7;
			this.lblLastName.Text = "LastName";
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(78, 26);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(262, 20);
			this.lastNameTextBox.TabIndex = 6;
			// 
			// lblDateOfBirth
			// 
			this.lblDateOfBirth.AutoSize = true;
			this.lblDateOfBirth.Location = new System.Drawing.Point(-1, 55);
			this.lblDateOfBirth.Name = "lblDateOfBirth";
			this.lblDateOfBirth.Size = new System.Drawing.Size(68, 13);
			this.lblDateOfBirth.TabIndex = 9;
			this.lblDateOfBirth.Text = "Date Of Birth";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(-1, 81);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(45, 13);
			this.lblAddress.TabIndex = 11;
			this.lblAddress.Text = "Address";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(78, 78);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(262, 20);
			this.addressTextBox.TabIndex = 10;
			// 
			// dateOfBirthDateTimePicker
			// 
			this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(78, 52);
			this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
			this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(262, 20);
			this.dateOfBirthDateTimePicker.TabIndex = 12;
			// 
			// DetailUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dateOfBirthDateTimePicker);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.lblDateOfBirth);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.firstNameTextBox);
			this.Name = "DetailUserControl";
			this.Size = new System.Drawing.Size(348, 102);
			((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label lblDateOfBirth;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
		private System.Windows.Forms.BindingSource detailBindingSource;
	}
}
