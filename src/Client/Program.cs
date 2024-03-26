using System;
using System.Windows.Forms;

namespace Client;

internal static class Program : object
{
	static Program()
	{
	}

	[STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new MainForm());
	}
}
