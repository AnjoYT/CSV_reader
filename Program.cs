using CSV_reader;

internal class Program
{
	private static void Main(string[] args)
	{
		string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+"\\Downloads\\HIG\\";
		Reader.CSV_load(path + "2023-10-18.csv", path + "FAKTURA_HIG_08_2023.csv",path);
	}
}