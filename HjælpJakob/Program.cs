using System;

namespace HjælpJakob
{
    internal class Program
    {
        public static void Main()
        {
            //Creating an object of send ass a single message
            Send sendMessage = new Send("Simone", "Kaj", "I suppose this is a very important message", "important!", "Julie");
            
            //checking how it works
            Console.WriteLine("To: " + sendMessage.To);
            Console.WriteLine("From: " + sendMessage.From);
            Console.WriteLine("Message: " + sendMessage.Body);
            Console.WriteLine("Subject: " + sendMessage.Subject);
            Console.WriteLine("CC: " + sendMessage.Cc);
        }
    }
}