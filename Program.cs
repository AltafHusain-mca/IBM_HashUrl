﻿// See https://aka.ms/new-console-template for more information
using IBM_HashUrl;
clsHash objHashCode = new clsHash();
string hashCode=objHashCode.GettingHashCode("https://stackoverflow.com", "tdspu", 5);
Console.WriteLine("Hash code is :" + hashCode);// this line will give final hashcode
Console.ReadLine();// adding comment to test pull request
