using System;
using System.Text;

class ExtractGivenWord
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        int endOfTheSentence = 0;
        int currentOccurence = 0;
        int lastOccurence = 0;

        do
        {
            currentOccurence = text.IndexOf(" " + word + " ", lastOccurence, text.Length - lastOccurence - 1);

            if (currentOccurence >= 0)
            {
                endOfTheSentence = text.LastIndexOf('.', currentOccurence, currentOccurence);
            }
            endOfTheSentence++;
            currentOccurence++;
            lastOccurence = currentOccurence;
            currentOccurence = text.IndexOf('.', lastOccurence, text.Length - lastOccurence);

            if (currentOccurence >= 0)
            {
                Console.WriteLine(text.Substring(endOfTheSentence, currentOccurence - endOfTheSentence).Trim());
            }
            currentOccurence++;
        }
        while (currentOccurence > 0 && currentOccurence < text.Length);

    }
}

