using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        WebClient webClient = new WebClient();

        try
        {
            webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"C:\\6.ExceptionHandling\\4.DownloadFile\\Logo-BASD.jpg");
        }
        catch (WebException)
        {
            Console.WriteLine("Problem with web connection.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Problem.");
        }
        webClient.Dispose();
    }
}

