﻿using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that receives some info from the console about people and their phone numbers.
//Each entry should have just one name and one number (both of them strings). 
//On each line you will receive some of the following commands:
//•	A {name} {phone} – adds entry to the phonebook.In case of trying to add a name that is already in the phonebook you should change 
//the existing phone number with the new one provided.
//•	S { name} – searches for a contact by given name and prints it in format "{name} -> {number}". In case the contact isn't found, print "Contact {name} does not exist.".
//•	END – stop receiving more commands.



class PhoneBook
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();


        while (true)
        {
            string[] token = Console.ReadLine().Split(' ');


            string command = token[0];

            if (command == "A")
            {
                phoneBook[token[1]]= token[2];
            }
            else if (command == "S")
            {
                ReadFromPhoneBook(token[1], phoneBook);
            }
            else if (command == "END")
            {
                break;
            }

        }

    }

    private static void ReadFromPhoneBook(string name, Dictionary<string, string> phoneBook)
    {
        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine("{0} -> {1}", name, phoneBook[name]);
        }
        else
        {
            Console.WriteLine("Contact {0} does not exist.", name);
        }
    }
}

