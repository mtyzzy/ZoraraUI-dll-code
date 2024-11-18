private void OpenDiscordLink()
{
	try
	{
		Process.Start(new ProcessStartInfo
		{
			FileName = "https://discord.gg/realzorara",
			UseShellExecute = true
		});
	}
	catch (Exception ex)
	{
		MessageBox.Show("Failed to open Discord link: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
	}
}
