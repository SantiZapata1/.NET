string texto = " Hello World ";
string lowerCase = texto.ToLower(); 
string upperCase = texto.ToUpper(); 
Console.WriteLine($"Lower case: {lowerCase}\nUpper case: {upperCase}");

string trimmed = texto.Trim(); 
Console.WriteLine($"trim: {trimmed}");

string[] words = { "Hello", "beautifull","World", "!" };
string joined = string.Join(".", words);
Console.WriteLine($"Join: {joined}");

string texto2 = "Hello to all World !";
string[] words2 = texto2.Split('l'); 
Console.Write($"split: ");
for (int i = 0; i < words2.Length; i++)
{
    Console.Write(words2[i]);
}

bool containsWorld = texto2.Contains("World"); // true
Console.WriteLine($"\ncontain `world`: {containsWorld}");

string replaced = texto.Replace("Hello", "Hi"); // "Hi World!"
Console.WriteLine($"replaced: {replaced}");

string inserted = texto.Insert(7, "pinche "); // "Hello World!"
Console.WriteLine($"Inserted: {inserted}");

string removed = texto.Remove(6, 6); // "Hello!"
Console.WriteLine($"removed: {removed}");
