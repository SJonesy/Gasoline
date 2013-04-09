/*
 * Created by SharpDevelop.
 * User: Stephen
 * Date: 7/23/2008
 * Time: 8:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gasoline
{
	public partial class MainForm : Form
	{
		IRC irc;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void ConnectClick(object sender, EventArgs e)
		{
			irc = new IRC(IRCWindow);
			
			if (!String.IsNullOrEmpty(Server.Text) && !String.IsNullOrEmpty(Port.Text))
			{
				irc.Connect(Server.Text, Convert.ToInt32(Port.Text));
				Connect.Enabled = false;
				Disconnect.Enabled = true;
			}
		}
		
		void DisconnectClick(object sender, EventArgs e)
		{
			IRCWindow.Clear();
			irc.Disconnect();
			Connect.Enabled = true;
			Disconnect.Enabled = false;
		}
		
		void UserInputOnEnter(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				irc.Send(UserInput.Text + "\r");
				UserInput.Clear();
			}
		}
	}
}
