// Program.cs

namespace _1._2;
class Program
{
    static void Main()
    {
        Message message1 = new Message("What's up Thuan, how are you?");
        Message message2 = new Message("Hello Hieu,how's your day?");
        Message message3 = new Message("Greetings, Nam! nice to see you!");
        Message message4 = new Message("Hey Phong, good to have you here!");
        Message standardmessage = new Message("Welcome new person, nice to meet you!");

        Message[] messages = { message1, message2, message3, message4, standardmessage };

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (name == "thuan".ToLower())
        {
            messages[0].Print();
        }
        else if (name == "hieu".ToLower())
        {
            messages[1].Print();
        }
        else if (name == "nam".ToLower())
        {
            messages[2].Print();
        }
        else if (name == "phong".ToLower())
        {
            messages[3].Print();
        }
        else
        {
            messages[4].Print();
        }
    }
}

// Message.cs 

using System;
namespace _1._2
{
	internal class Message
	{
		private string _text;


		public Message(string text)
		{
			_text = text;
		}

		public void Print()
		{
			Console.WriteLine(_text);
		}
	}
}
