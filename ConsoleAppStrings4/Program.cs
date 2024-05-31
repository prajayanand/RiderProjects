using System;

namespace ConsoleAppStrings4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a URL:");
            string url = Console.ReadLine();

            ParseUrl(url);
        }

        static void ParseUrl(string url)
        {
            string protocol = "";
            string server = "";
            string resource = "";

            // Find protocol
            int protocolEndIndex = url.IndexOf("://");
            if (protocolEndIndex != -1)
            {
                protocol = url.Substring(0, protocolEndIndex);
                url = url.Substring(protocolEndIndex + 3); // Remove protocol part from URL
            }

            // Find server and resource
            int serverEndIndex = url.IndexOf('/');
            if (serverEndIndex != -1)
            {
                server = url.Substring(0, serverEndIndex);
                resource = url.Substring(serverEndIndex + 1); // Get resource part
            }
            else
            {
                server = url;
            }

            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }
}