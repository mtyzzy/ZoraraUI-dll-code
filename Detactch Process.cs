private void DetachFromProcess()
{
	try
	{
		ClientsWindow.Detach();
		this._isInjected = false;
	}
	catch (Exception ex)
	{
		MessageBox.Show("Failed to detach Zorara: " + ex.Message, "Detach Error", MessageBoxButton.OK, MessageBoxImage.Hand);
	}
}
