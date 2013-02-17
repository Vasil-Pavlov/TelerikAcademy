using System;
using System.IO;
using System.Collections.Generic;

class ExtractText
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\xml.xml");
        Queue<char> xmlElements = new Queue<char>();
        string text = "";

        using (reader)
        {
            text = reader.ReadToEnd();
        }

        foreach (char item in text)
        {
            if (item == '<')
            {
                xmlElements.Enqueue(item);
            }
            else if (item == '>')
            {
                xmlElements.Dequeue();
            }
            else if (xmlElements.Count == 0)
            {
                Console.Write(item);
            }
        }        
    }
}

