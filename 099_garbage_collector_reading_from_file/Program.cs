using System;
using System.IO;
using System.Text;

// We create an instance of the FileStream class by providing the file name and the mode
var fileStream = new FileStream("Program.cs", FileMode.Open);

// We should have a place to store the sequence of bytes in our program
// As the size of our byte array, we provide fileStream.Length (file size in bytes)
byte[] byteSequence = new byte[fileStream.Length];

// We will store the file bytes in byteSequence object
// We will start reading from the beginning
// We will read until we reach the end of the file
fileStream.Read(byteSequence, 0, byteSequence.Length);

// Now, we have an array of bytes that represent the "Program.cs" file
// But to see it as a text, we must decode this sequence of bytes
// For that, we can use the Encoding class
string text = Encoding.UTF8.GetString(byteSequence);

Console.WriteLine(text);