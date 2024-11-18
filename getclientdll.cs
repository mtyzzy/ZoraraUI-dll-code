private List<ClientsWindow.ClientInfo> GetClientsFromDll()
{
	List<ClientsWindow.ClientInfo> list = new List<ClientsWindow.ClientInfo>();
	IntPtr intPtr = ClientsWindow.GetClients();
	for (;;)
	{
		ClientsWindow.ClientInfo clientInfo = Marshal.PtrToStructure<ClientsWindow.ClientInfo>(intPtr);
		if (clientInfo.name == null)
		{
			break;
		}
		list.Add(clientInfo);
		intPtr += (IntPtr)Marshal.SizeOf<ClientsWindow.ClientInfo>();
	}
	return list;
}
