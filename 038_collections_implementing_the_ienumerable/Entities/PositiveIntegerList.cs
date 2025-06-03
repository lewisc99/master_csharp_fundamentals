using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
  public class PositiveIntegerList : IEnumerable<int>
  {
    private List<int> _positiveIntegerList;

    public PositiveIntegerList()
    {
      _positiveIntegerList = new List<int>();
    }

    // We can only add positive integers to our list
    public void Add(int number)
    {
      if (number > 0)
      {
        _positiveIntegerList.Add(number);
      }
      else
      {
        throw new ArgumentException("Can only add positive numbers.");
      }
    }

    // We implement the IEnumerable<T> interface
    public IEnumerator<int> GetEnumerator()
    {
      return new PositiveIntegerListEnumerator(_positiveIntegerList);
    }

    // Since IEnumerable<T> inherits IEnumerable,
    // we must also implement IEnumerable
    // Because of the two methods having the same name,
    // we implemnent one of the interfaces explicitly
    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    // We will create an enumerator class inside PositiveIntegerList
    // We will return an instance of this class whenever
    // the GetEnumerator method is called
    public class PositiveIntegerListEnumerator : IEnumerator<int>
    {
      // The collection we will iterate
      List<int> _positiveIntegerList;

      // Our pointer
      int position = -1;

      public PositiveIntegerListEnumerator(List<int> positiveIntegerList)
      {
        this._positiveIntegerList = positiveIntegerList;
      }

      // Returns current item
      public int Current
      {
        get
        {
          // We will return an item only if position
          // is valid
          if (position >= 0)
          {
            return _positiveIntegerList[position];
          }
          else
          {
            throw new InvalidOperationException("Pointer is currently not pointing to any item.");
          }
        }
      }

      // We must explicitly implement the `IEnumerator` interface
      object IEnumerator.Current
      {
        get
        {
          return this.Current;
        }
      }

      // We must have a method that performs clean-up
      // We will talk about this method later
      public void Dispose()
      {

      }

      // We will try to move the position to the next item
      // If we succeed, we will return true
      // Otherwise we will return false
      public bool MoveNext()
      {
        if (position < _positiveIntegerList.Count - 1)
        {
          position++;
          return true;
        }
        else
        {
          return false;
        }
      }

      // The method that resets the pointer
      public void Reset()
      {
        position = -1;
      }
    }
  }
}