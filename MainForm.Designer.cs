/*
 * Created by SharpDevelop.
 * User: Stephen
 * Date: 7/23/2008
 * Time: 8:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gasoline
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.IRCWindow = new System.Windows.Forms.RichTextBox();
			this.Server = new System.Windows.Forms.TextBox();
			this.Port = new System.Windows.Forms.TextBox();
			this.Connect = new System.Windows.Forms.Button();
			this.Disconnect = new System.Windows.Forms.Button();
			this.LabelServer = new System.Windows.Forms.Label();
			this.LabelPort = new System.Windows.Forms.Label();
			this.UserInput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// IRCWindow
			// 
			this.IRCWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.IRCWindow.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IRCWindow.Location = new System.Drawing.Point(12, 56);
			this.IRCWindow.Name = "IRCWindow";
			this.IRCWindow.ReadOnly = true;
			this.IRCWindow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.IRCWindow.Size = new System.Drawing.Size(472, 333);
			this.IRCWindow.TabIndex = 0;
			this.IRCWindow.Text = "";
			// 
			// Server
			// 
			this.Server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Server.Location = new System.Drawing.Point(225, 17);
			this.Server.Name = "Server";
			this.Server.Size = new System.Drawing.Size(157, 20);
			this.Server.TabIndex = 1;
			this.Server.Text = "irc.synirc.com";
			// 
			// Port
			// 
			this.Port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Port.Location = new System.Drawing.Point(419, 17);
			this.Port.Name = "Port";
			this.Port.Size = new System.Drawing.Size(65, 20);
			this.Port.TabIndex = 2;
			this.Port.Text = "6667";
			// 
			// Connect
			// 
			this.Connect.Location = new System.Drawing.Point(12, 14);
			this.Connect.Name = "Connect";
			this.Connect.Size = new System.Drawing.Size(80, 23);
			this.Connect.TabIndex = 3;
			this.Connect.Text = "Connect";
			this.Connect.UseVisualStyleBackColor = true;
			this.Connect.Click += new System.EventHandler(this.ConnectClick);
			// 
			// Disconnect
			// 
			this.Disconnect.Enabled = false;
			this.Disconnect.Location = new System.Drawing.Point(98, 14);
			this.Disconnect.Name = "Disconnect";
			this.Disconnect.Size = new System.Drawing.Size(70, 23);
			this.Disconnect.TabIndex = 4;
			this.Disconnect.Text = "Disconnect";
			this.Disconnect.UseVisualStyleBackColor = true;
			this.Disconnect.Click += new System.EventHandler(this.DisconnectClick);
			// 
			// LabelServer
			// 
			this.LabelServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelServer.Location = new System.Drawing.Point(185, 19);
			this.LabelServer.Name = "LabelServer";
			this.LabelServer.Size = new System.Drawing.Size(41, 20);
			this.LabelServer.TabIndex = 5;
			this.LabelServer.Text = "Server:";
			// 
			// LabelPort
			// 
			this.LabelPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelPort.Location = new System.Drawing.Point(390, 19);
			this.LabelPort.Name = "LabelPort";
			this.LabelPort.Size = new System.Drawing.Size(29, 13);
			this.LabelPort.TabIndex = 6;
			this.LabelPort.Text = "Port:";
			// 
			// UserInput
			// 
			this.UserInput.AcceptsReturn = true;
			this.UserInput.AllowDrop = true;
			this.UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.UserInput.Location = new System.Drawing.Point(12, 395);
			this.UserInput.Multiline = true;
			this.UserInput.Name = "UserInput";
			this.UserInput.Size = new System.Drawing.Size(472, 20);
			this.UserInput.TabIndex = 7;
			this.UserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserInputOnEnter);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 418);
			this.Controls.Add(this.UserInput);
			this.Controls.Add(this.LabelPort);
			this.Controls.Add(this.LabelServer);
			this.Controls.Add(this.Disconnect);
			this.Controls.Add(this.Connect);
			this.Controls.Add(this.Port);
			this.Controls.Add(this.Server);
			this.Controls.Add(this.IRCWindow);
			this.Name = "MainForm";
			this.Text = "Gasoline";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox UserInput;
		private System.Windows.Forms.Label LabelPort;
		private System.Windows.Forms.Label LabelServer;
		private System.Windows.Forms.Button Disconnect;
		private System.Windows.Forms.Button Connect;
		private System.Windows.Forms.TextBox Port;
		private System.Windows.Forms.TextBox Server;
		private System.Windows.Forms.RichTextBox IRCWindow;
	}
}
