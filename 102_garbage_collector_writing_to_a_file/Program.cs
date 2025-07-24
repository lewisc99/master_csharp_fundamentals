using System;
using System.IO;
using System.Text;

string text = "Hello World!";
string fileName = "myText.txt";

// Encode our text using UTF8 encoding
byte[] bytesToWrite = Encoding.UTF8.GetBytes(text);

// Create and open the file
using (var fileStream = new FileStream(fileName, FileMode.Create))
{
  Console.WriteLine($"Writing to a file {fileName}...");

  // Write to the file
  fileStream.Write(bytesToWrite, 0, bytesToWrite.Length);

  Console.WriteLine($"Success!\n");
} // Dispose() is called at the end

// Let's make sure that our file was created
Console.WriteLine("Files in the current directory:");
var filesInCurrentDir = Directory.GetFiles(Directory.GetCurrentDirectory());

foreach (var file in filesInCurrentDir)
{
  Console.WriteLine(file);
}

// Now, let's try to read our file back
Console.WriteLine($"\nReading {fileName}:");
using (var fileStream = new FileStream(fileName, FileMode.Open))
{
  byte[] bytesRead = new byte[fileStream.Length];
  fileStream.Read(bytesRead, 0, bytesRead.Length);

  var decodedText = Encoding.UTF8.GetString(bytesRead);
  Console.WriteLine(decodedText);
}