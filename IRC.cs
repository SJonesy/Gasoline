using System;
using System.Net;
using System.Collections;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Gasoline
{
	public class IRC
	{
		private static RichTextBox IRCWindow;
		private static TcpClient connection;
		private static NetworkStream stream;
		private static byte[] buffer = new byte[65535];
		private static string nickName = "Gasoline";
		private static ushort counter = 0;
		private static ArrayList channels = new ArrayList();

		public IRC(RichTextBox window)
		{
			IRCWindow = window;
		}
		
		public void Connect(string server, int port)
		{
			AsyncCallback callBack = new AsyncCallback(OnRead);
			connection = new TcpClient(server, port);
			stream = connection.GetStream();
			
			stream.BeginRead(buffer, 0, buffer.Length, callBack, this);
		}
		
		public void Disconnect()
		{
			Send("QUIT :Leaving");
		}
		
		private void OnRead(IAsyncResult result)
		{
			string message;
			message = System.Text.Encoding.ASCII.GetString(buffer, 0, buffer.Length);
			
			IRCWindow.Text += message;
			
			if (message.Contains("PRIVMSG")) { ParseMessage(message); }
			else if (message.Contains("NOTICE AUTH :*** Checking Ident")) {
				Send("NICK " + nickName);
				Send("USER Gasoline WINDOWS 0 :Oil Prices");
			}
			else if (message.Contains("PING")) { Send("PONG localhost"); }
			
			Array.Clear(buffer, 0, buffer.Length);
			AsyncCallback callBack = new AsyncCallback(OnRead);
			stream.BeginRead(buffer, 0, buffer.Length, callBack, this);
		}
		
		public void Send(string message)
		{
			if (message.Contains("JOIN"))
			{
				channels.Add(message.Substring(5, message.Length - 5));
			}
			    
			message += '\r';
			byte [] data = new byte[message.Length];
			data = System.Text.Encoding.ASCII.GetBytes(message);
			stream.Write(data, 0, data.Length);
			IRCWindow.Text += message;
		}
		
		private void ParseMessage(string message)
		{
			Random rand = new Random();
			
			Regex r = new Regex(".*PRIVMSG (.*) :.*");
			string nickName = r.Match(":(.*)!").Groups[0].Value;
			string channel = r.Match("PRIVMSG (.*) :").Groups[0].Value;
			
			counter++;

			if (counter > channels.Count * 100)
			{
				foreach (string chan in channels)
				{
					switch(rand.Next(0,6))
					{
						case 0:
							Send("PRIVMSG " + chan.TrimEnd('\n', '\r') + " but that's nothing compared to gas prices");
							break;
						case 1:
							Send("PRIVMSG " + chan.TrimEnd('\n', '\r') + " :D");
							break;
						case 2:
							Send("PRIVMSG " + chan.TrimEnd('\n', '\r') + " yeah");
							break;
						case 3:
							Send("PRIVMSG " + chan.TrimEnd('\n', '\r') + " nope");
							break;
						case 4:
							Send("PRIVMSG " + chan.TrimEnd('\n', '\r') + " ugh");
							break;
					}
				}
				
				counter = 0;
			}
		}
	}
}
