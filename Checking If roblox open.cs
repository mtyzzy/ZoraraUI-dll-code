private bool IsRobloxRunning()
{
	Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
	if (processesByName.Length != 0)
	{
		this._robloxProcess = processesByName[0];
		return true;
	}
	this._robloxProcess = null;
	return false;
}
