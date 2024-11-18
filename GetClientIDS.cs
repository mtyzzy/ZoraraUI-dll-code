private static int GetClientId(string content)
{
	return int.Parse(content.Split(", PID: ", StringSplitOptions.None)[1]);
}
