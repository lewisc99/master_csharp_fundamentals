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

// Instead of using a foreach loop to convert each file,
// we can convert in parallel using Parallel.ForEach()
Parallel.ForEach<string>(filesToConvert, (fileName) =>
{
  Console.WriteLine($"Successfully converted file {fileName} to PDF.");
});