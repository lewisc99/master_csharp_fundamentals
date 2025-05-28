var text = Console.ReadLine();

var characterCount = new Dictionary<char, int>();

foreach (var character in text)
{
  // If it's a space, then we can disregard it
  if (char.IsWhiteSpace(character))
    continue;

  // The containskey method checks if the character is already in the dictionary
  if (characterCount.ContainsKey(character))
  {
    // If it is, we increment the count
    characterCount[character]++;
  }
  else
  {
    // If the key is not found, then it means that
    // It is the first time we are seeing this character
    characterCount[character] = 1;
  }
}

// Key property contains the keys of the dictionary
foreach (var key in characterCount.Keys)
{
  // Value property contains the values of the dictionary
  Console.WriteLine($"{key} --> {characterCount[key]}");
}