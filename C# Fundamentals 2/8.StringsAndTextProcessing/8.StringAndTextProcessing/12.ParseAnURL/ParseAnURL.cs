using System;
using System.Text;

class ParseAnURL
{
    static void Main()
    {
        string uRLAdress ="htpp://www.devbg.org/forum/index.php";
        StringBuilder protocol = new StringBuilder();
        StringBuilder server = new StringBuilder();
        StringBuilder resource = new StringBuilder();
        int endOfProtocol;
        int startResource;
        endOfProtocol = uRLAdress.IndexOf(':');

        for (int i = 0; i < endOfProtocol; i++)
        {
            protocol.Append(uRLAdress[i]);
        }

        startResource = uRLAdress.IndexOf('/', endOfProtocol + 3);
        for (int i = endOfProtocol + 3; i < startResource; i++)
        {
            server.Append(uRLAdress[i]);
        }

        for (int i = startResource + 1; i < uRLAdress.Length; i++)
        {
            resource.Append(uRLAdress[i]);
        }
        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        Console.WriteLine("[server] = \"{0}\"", server);
        Console.WriteLine("[resource] = \"{0}\"", resource);
    }
}

