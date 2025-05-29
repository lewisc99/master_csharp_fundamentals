using System;

// ObservableCollection<T> is in this namespace
using System.Collections.ObjectModel;

var notes = new ObservableCollection<string>();
notes.Add("I have to do the laundry today");

Console.WriteLine(notes.Count); // Output: 1
