using System;

namespace HjælpJakob
{
    internal class Program
    {
        public static void Main()
        {
            //Card withDraw = new WithDraw("Anne", 12);
            Send sendMessage = new Send("Simone", "Kaj", "I suppose this is a very important message", "important!", "Julie");
            
            Console.WriteLine("To: " + sendMessage.To);
            Console.WriteLine("From: " + sendMessage.From);
            Console.WriteLine("Message: " + sendMessage.Body);
            Console.WriteLine("Subject: " + sendMessage.Subject);
            Console.WriteLine("CC: " + sendMessage.Cc);
        }
    }
}