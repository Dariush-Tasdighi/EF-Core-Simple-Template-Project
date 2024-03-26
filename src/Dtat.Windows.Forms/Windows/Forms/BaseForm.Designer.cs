namespace Dtat.Windows.Forms;

partial class BaseForm
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
		// BaseForm
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(389, 364);
		Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
		Name = "BaseForm";
		StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		ResumeLayout(false);
	}

	#endregion
}
