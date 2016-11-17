namespace BindingViewModel.Views
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.personViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.detailUserControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.personUserControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// personToolStripMenuItem
			// 
			this.personToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personViewToolStripMenuItem});
			this.personToolStripMenuItem.Name = "personToolStripMenuItem";
			this.personToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.personToolStripMenuItem.Text = "Person";
			// 
			// personViewToolStripMenuItem
			// 
			this.personViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailUserControlToolStripMenuItem,
            this.personUserControlToolStripMenuItem});
			this.personViewToolStripMenuItem.Name = "personViewToolStripMenuItem";
			this.personViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.personViewToolStripMenuItem.Text = "PersonView";
			this.personViewToolStripMenuItem.Click += new System.EventHandler(this.personViewToolStripMenuItem_Click);
			// 
			// detailUserControlToolStripMenuItem
			// 
			this.detailUserControlToolStripMenuItem.Name = "detailUserControlToolStripMenuItem";
			this.detailUserControlToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.detailUserControlToolStripMenuItem.Text = "DetailUserControl";
			this.detailUserControlToolStripMenuItem.Click += new System.EventHandler(this.detailUserControlToolStripMenuItem_Click);
			// 
			// personUserControlToolStripMenuItem
			// 
			this.personUserControlToolStripMenuItem.Name = "personUserControlToolStripMenuItem";
			this.personUserControlToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.personUserControlToolStripMenuItem.Text = "PersonUserControl";
			this.personUserControlToolStripMenuItem.Click += new System.EventHandler(this.personUserControlToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem personViewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem detailUserControlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem personUserControlToolStripMenuItem;
	}
}