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
