public void ExecuteScript(string script)
{
	string[] array = (from c in this.ActiveClients
	select c.name).ToArray<string>();
	ClientsWindow.Execute(Encoding.UTF8.GetBytes(script), array, array.Length);
}
