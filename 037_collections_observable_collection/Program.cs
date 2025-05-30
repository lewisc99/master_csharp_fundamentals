using System.Collections.ObjectModel;
using System.Collections.Specialized;

var notes = new ObservableCollection<string>();

// We subscribe our method to this event
// Our method will get executed whenever this event is triggered.
notes.CollectionChanged += notes_CollectionChanged;

notes.Add("I have to do the laundry today");
notes.Add("2 x 2 = 4");
notes.Add("Hello World!");
notes.RemoveAt(2);


// The method that we subscribe to the event
static void notes_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
  // We can see what action caused the event
  if (e.Action == NotifyCollectionChangedAction.Add)
  {
    foreach (var item in e.NewItems)
    {
      Console.WriteLine("Note with the following content was added: ");
      Console.WriteLine(item);
      Console.WriteLine();
    }
  }

  if (e.Action == NotifyCollectionChangedAction.Remove ||
  e.Action == NotifyCollectionChangedAction.Replace)
  {
    foreach (var item in e.OldItems)
    {
      Console.WriteLine("Note with the following content was removed: ");
      Console.WriteLine(item);
      Console.WriteLine();
    }
  }
}