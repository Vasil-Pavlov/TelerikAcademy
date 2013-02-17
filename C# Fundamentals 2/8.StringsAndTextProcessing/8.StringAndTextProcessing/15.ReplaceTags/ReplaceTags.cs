using System;
using System.Text;

class ReplaceTags
{
    static void Main()
    {
        string html = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        html = html.Replace("<a href=\"", "[URL=");
        html = html.Replace("</a>", "[/URL]");
        int index = 0;

        do
        {
            index = html.IndexOf("[URL=", index);
            if (index < 0)
            {
                break;
            }
            index = html.IndexOf("\">", index);

            html = html.Remove(index, 2);
            html = html.Insert(index, "]");
            index++;
        }
        while (index > 0);
        Console.WriteLine(html);
    }
}

