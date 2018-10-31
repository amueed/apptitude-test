using System;
using System.Linq.Expressions;

namespace AlexaSettings
{
    public class Alexa
    {
        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }

        public Alexa()
        {
            this.GreetingMessage = "hello, i am Alexa";
            this.OwnerName = string.Empty;
        }

        public void Configure(Action<Alexa> configuration)
        {
            configuration(this);
        }

        public string Talk()
        {
            return this.GreetingMessage.Replace("{OwnerName}", OwnerName);
        }
    }
}