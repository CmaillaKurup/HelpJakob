namespace HjælpJakob
{//This class is responsible for sending messages
    public enum MessageCarrier { Smtp, VMessage }
    
    public class Send : ConvertToHTML
    {
        private string to;
        private string from;
        private string body;
        private string subject;
        private string cc;

        //constructor
        public Send(string to, string from, string body, string subject, string cc)
        {
            this.to = to;
            this.from = from;
            this.body = body;
            this.subject = subject;
            this.cc = cc;
        }
        
        //incapsulation
        public string To { get => to; set => to = value; }
        public string From { get => from; set => from = value; }
        public string Body { get => body; set => body = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Cc { get => cc; set => cc = value; }
        
        //methode for sending one message by SMTP
        public void sendMessageSmtp(MessageCarrier type, Send m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML) m.Body = ConvertBodyToHTML(m.Body);
            }
        }

        //methode for sending one message by Vmessage
        public void sendMessageVMessage(MessageCarrier type, Send m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML) m.Body = ConvertBodyToHTML(m.Body);
            }
        }
        
        //methode for sending message to all by SMTP
        public void sendMessageToAllSmtp(MessageCarrier type, string[] to, Send m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML) m.Body = ConvertBodyToHTML(m.Body);
            }
        }
        
        //methode for sending message to all by VMessage
        public void sendMessageToAllVMessage(MessageCarrier type, string[] to, Send m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML) m.Body = ConvertBodyToHTML(m.Body);
            }
        }
    }
}