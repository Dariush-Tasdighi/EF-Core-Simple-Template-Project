namespace Client;

partial class MainForm
{
	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}

		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	private void InitializeComponent()
	{
		SuspendLayout();
		// 
		// MainForm
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(428, 338);
		Name = "MainForm";
		Text = "Main";
		Load += MainForm_Load;
		ResumeLayout(false);
	}

	#endregion
}
