using System;
using System.Windows.Forms;
using SimpleIRCLib;

namespace CorCrypt
{
    public partial class Form1 : Form
    {
        //initiate irc client
        public SimpleIRC irc = new SimpleIRC();

        //initiate debugform
        public DebugForm debugForm = new DebugForm();

        public string defaultDownloadDirectory = "";

        public Form1()
        {
            InitializeComponent();
            //defaultDownloadDirectory = Directory.GetCurrentDirectory();
        }

        /// <summary>
        /// Gets the values from the input fields and starts the client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ServerInput.Text != "" && PortInput.Text != "" && UsernameInput.Text != "" && ChannelsInput.Text != "" && irc.isClientRunning() == false)
            {
                int port = -1;
                if ((port = int.Parse(PortInput.Text)) != -1)
                {
                    //parameters as follows: ip or address to irc server, username, password(not functional), channels, and method to execute when message is received (see line 103)
                    irc.setupIrc(ServerInput.Text, port, UsernameInput.Text, "", ChannelsInput.Text, AppendChatMessageToChatOutput);

                    //sets the method for appending text to a debug form, see Class "DebugForm.cs" line: 27 
                    irc.setDebugCallback(debugForm.AppendToDebugOutput);

                    //sets method for updating download information while downloading, see line: 119
                    //irc.setDownloadStatusChangeCallback(OnDownloadEvent);

                    //sets the download dir to where the application runs
                    //irc.setCustomDownloadDir(defaultDownloadDirectory);

                    //Start client
                    irc.startClient();
                }
            }
            else
            {
                MessageBox.Show("You need to fill in all the information fields!");
            }
        }

        /// <summary>
        /// Disconnects the irc client, if connected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (irc.isClientRunning())
            {
                irc.stopClient();
            }
        }

        /// <summary>
        /// Sends a message to the irc server on enter press, if connected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (MessageInput.Text != "" && irc.isClientRunning())
                {
                    irc.sendMessage(MessageInput.Text);
                    MessageInput.Clear();
                }
            }

        }

        /// <summary>
        /// Appends chat message received from irc server to richtextbox output box. 
        /// Invoke is needed because this method executes on a different thread!
        /// </summary>
        /// <param name="user">The user where the messsage came from</param>
        /// <param name="message">The actual message</param>
        private void AppendChatMessageToChatOutput(string user, string message)
        {
            if (this.ChatOutput.InvokeRequired)
            {
                this.ChatOutput.Invoke(new MethodInvoker(() => AppendChatMessageToChatOutput(user, message)));
            }
            else
            {
                this.ChatOutput.AppendText(user + " : " + message + "\n");
            }
        }

        /// <summary>
        /// Opens the debug form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowDebugButton_Click(object sender, EventArgs e)
        {
                debugForm.Show();
        }

        /// <summary>
        /// Stops the irc client on form close, otherwise it would keep running in the background!!!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (irc.isClientRunning())
            {
                irc.stopClient();
            }
        }

        private void ChatOutput_TextChanged(object sender, EventArgs e)
        {
            if (ChatOutput.Visible)
            {
                ChatOutput.SelectionStart = ChatOutput.TextLength;
                ChatOutput.ScrollToCaret();
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MessageInput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void labelsomething_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}