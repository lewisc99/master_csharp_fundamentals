using System;
using System.Threading;
using System.Threading.Tasks;

// We have files to convert
string[] filesToConvert = new string[]
{
                "EmployeeList.docx",
                "Salaries.docx",
                "Rules.docx",
                "EmploymentContract.docx",
                "Handbook.docx",
                "FAQ.docx",
                "untitled.docx",
                "New.docx",
                "Graphs.docx",
                "EOD.docx"
};

// Insted of using a for loop to convert each file 
// We can convert in parallel using Parallel.For()
Parallel.For(0, filesToConvert.Length, (i) =>
{
  Console.WriteLine($"Successfully converted file {filesToConvert[i]} to PDF.");

});
