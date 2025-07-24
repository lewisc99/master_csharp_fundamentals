// Gets the current directory where the app executable is located
string currentDirectory = Directory.GetCurrentDirectory();

// Gets the list of files
string[] files = Directory.GetFiles(currentDirectory);

Console.WriteLine("Files in current directory:");

foreach (var file in files)
{
  Console.WriteLine(file);
}