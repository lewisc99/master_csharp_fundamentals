using System.Text;
using (var fileStream = new FileStream("Program.cs", FileMode.Open))
{
  byte[] byteSequence = new byte[fileStream.Length];
  fileStream.Read(byteSequence, 0, byteSequence.Length);
  string text = Encoding.UTF8.GetString(byteSequence);

  Console.WriteLine(text);
} // Dispose() is calling at the end