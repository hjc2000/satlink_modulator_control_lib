string path = @"C:\Users\huang\source\repos\ESP32配网\ConsoleApp1\output.txt";
FileStream file = File.Open(path, FileMode.Open);
StreamReader reader = new StreamReader(file);
FileStream file_to_write = File.Open(@"D:\my_files\workspace\temp\output.txt", FileMode.Create);
StreamWriter writer = new StreamWriter(file_to_write);

string read_data = reader.ReadToEnd();
string[] nums = read_data.Split(',',
	StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
int i = 0;
foreach (string str in nums)
{
	writer.Write(str + ",");
	i++;
	if ((i % 20) == 0)
	{
		writer.WriteLine();
	}
}
//string[] lines = read_data.Split('\n',
//	StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

//foreach (string line in lines)
//{
//	int start_index = line.IndexOf(',') + 1;
//	int end_index = line.Length - 1 - 1;
//	string tempStr = line.Substring(start_index, end_index - start_index);
//	writer.WriteLine(tempStr);
//}
writer.Flush();