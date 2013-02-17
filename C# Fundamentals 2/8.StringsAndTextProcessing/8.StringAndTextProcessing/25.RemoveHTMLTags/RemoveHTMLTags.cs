using System;
using System.Collections.Generic;

class RemoveHTMLTags
{
    static void Main()
    {
        Queue<char> tags = new Queue<char>();
        string text = "<html>" +
                    " <head><title>News</title></head>" +
                    " <body><p><a href=\"http://academy.telerik.com\">Telerik" +
                    "  Academy</a>aims to provide free real-world practical" +
                    "  training for young people who want to turn into" +
                    "  skillful .NET software engineers.</p></body>" +
                    "</html>";

        foreach (char item in text)
        {
            if (item == '<')
            {
                tags.Enqueue(item);
            }
            else if (item == '>')
            {
                tags.Dequeue();
                Console.WriteLine();
            }
            else if (tags.Count == 0)
            {
                Console.Write(item);
            }
        }
    }
}

