using System.Text.RegularExpressions;

// Exercise - Complete a challenge to reverse words in a sentence

string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramArray = pangram.Split(" ");

string result = "";

foreach (string word in pangramArray)
{
    char[] wordArray = word.ToCharArray();

    Array.Reverse(wordArray);

    result += new string(wordArray) + " ";
}

Console.WriteLine(result);

// Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderArr = orderStream.Split(",");
Array.Sort(orderArr);

foreach (string order in orderArr)
{
    if (!Regex.IsMatch(order, "^[a-zA-Z0-9]{4}$"))
        Console.WriteLine(order + "\t - Error");
    else
        Console.WriteLine(order);
}