namespace Dtat.Windows.Forms;

public static class MessageBox : object
{
	static MessageBox()
	{
	}

	public static void ShowError(string message)
	{
		System.Windows.Forms.MessageBox.Show(text: message);
	}

	public static void ShowInformation(string message)
	{
		System.Windows.Forms.MessageBox.Show(text: message);
	}
}
