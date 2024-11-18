private bool IsClientListed(ClientsWindow.ClientInfo client)
{
	return this.checkBoxContainer.Children.OfType<CheckBox>().Any(delegate(CheckBox cb)
	{
		string a = cb.Content.ToString();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
		defaultInterpolatedStringHandler.AppendFormatted(client.name);
		defaultInterpolatedStringHandler.AppendLiteral(", PID: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(client.id);
		return a == defaultInterpolatedStringHandler.ToStringAndClear();
	});
}
