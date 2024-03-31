using System;
using Persistence;
using Dtat.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Client;

public partial class MainForm : BaseForm
{
	public MainForm()
	{
		InitializeComponent();
	}

	//private void MainForm_Load(object sender, EventArgs e)
	//{
	//}

	private async void MainForm_Load(object sender, EventArgs e)
	{
		try
		{
			using var applicationDbContext = new ApplicationDbContext();

			var hasAnyUser =
				await
				applicationDbContext.Users.AnyAsync();

			if (hasAnyUser)
			{
				MessageBox.ShowInformation
					(message: "Everything is all right!");
			}
			else
			{
				MessageBox.ShowError
					(message: "Something wrong!");
			}
		}
		catch (Exception ex)
		{
			MessageBox.ShowError(message: ex.Message);
		}
	}
}
