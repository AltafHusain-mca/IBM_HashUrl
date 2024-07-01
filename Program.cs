// See https://aka.ms/new-console-template for more information
using IBM_HashUrl;
Console.WriteLine("Hello, World!");
clsHash objHashCode = new clsHash();
string hashCode=objHashCode.GettingHashCode("https://stackoverflow.com", "tdspu", 5);
Console.WriteLine("Hash code is :"+ hashCode);
Console.ReadLine();