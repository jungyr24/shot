namespace ScrSh
{
	partial class RegionSelectionForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(320, 240);
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegionSelectionForm";
			this.Opacity = 0.33d;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Screenshot region selection";
			this.TopMost = true;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegionSelectionFormKeyDown);
			this.ResumeLayout(false);
		}
	}
}