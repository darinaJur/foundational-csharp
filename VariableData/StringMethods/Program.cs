// Exercise - Complete a challenge to extract, replace, and remove data from an input string


const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

int openingPositionSpan = input.IndexOf("<span>");
int closingPositionSpan = input.IndexOf("</span>");

quantity = input.Substring((openingPositionSpan + 6), closingPositionSpan - (openingPositionSpan +6));

int openingPositionDiv = input.IndexOf("<div>");
int closingPositionDiv = input.IndexOf("</div>");

output = input.Substring((openingPositionDiv +5), closingPositionDiv - (openingPositionDiv + 5)).Replace("&trade", "&reg");



Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");