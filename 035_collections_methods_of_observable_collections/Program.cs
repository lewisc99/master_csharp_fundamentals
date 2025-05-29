
using System;

// ObservableCollection<T> is in this namespace
using System.Collections.ObjectModel;

var notes = new ObservableCollection<string>();
notes.Add("I have to do the laundry today"); // Add a note

notes.Add("Good day today"); // Add another note
notes.RemoveAt(0); // Remove the first item
notes.Insert(0, "I have to do the dishes today"); // Insert at the first position

Console.WriteLine(notes.Count); // Output: 2


// iterates through the collection
foreach (var note in notes)
{
  // Output:
  // I have to do the dishes today
  // Good day today
  Console.WriteLine(note);
}

// Count the number of notes
Console.WriteLine(notes.Count);
