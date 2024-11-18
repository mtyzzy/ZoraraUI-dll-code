private void MonitorRobloxProcess(object sender, EventArgs e)
{
	if (!this.IsRobloxRunning() && this._isInjected)
	{
		this._isInjected = false;
		try
		{
			ClientsWindow.Detach();
		}
		catch (Exception ex)
		{
			MessageBox.Show("Failed to detach Zorara: " + ex.Message, "Detach Error", MessageBoxButton.OK, MessageBoxImage.Hand);
		}
		this._timer.Stop();
		this._processMonitorTimer.Stop();
		Action<string, Brush> statusUpdated = this.StatusUpdated;
		if (statusUpdated == null)
		{
			return;
		}
		statusUpdated("Not Connected", Brushes.Red);
	}
}
