using System;

// ObservableCollection<T> is in this namespace
using System.Collections.ObjectModel;

// NotifyCollectionChanged event is in this namespace
using System.Collections.Specialized;

var notes = new ObservableCollection<string>();


// Subscribing to the event.
// Whenever an itens is added or removed,
// This method will be executed.
notes.CollectionChanged += (sender, eventArgs) =>
{
  // We can perform different actions depending on what triggered the event

  // If a new item was added
  if (eventArgs.Action == NotifyCollectionChangedAction.Add)
  {
    // NewItems is a collection of items that were added
    foreach (var item in eventArgs.NewItems)
    {
      Console.WriteLine($"'{item.ToString()}' was added.");
    }
  }

  // If an item was removed
  if (eventArgs.Action == NotifyCollectionChangedAction.Remove ||
      eventArgs.Action == NotifyCollectionChangedAction.Replace)
  {
    // OldItems contains items that were removed or replaced
    foreach (var item in eventArgs.OldItems)
    {
      Console.WriteLine($"'{item.ToString()}' was removed or replaced.");
    }
  }
};

notes.Add("I have to do the laundry today.");
notes.Add("Good day today");
notes.RemoveAt(0); // Remove the first item
notes.Insert(0, "Hello world");