using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashHomeManagementSystem
{
    public partial class SecurityControlForm : Form
    {
        private TcpClient _doorClient = null;
        public SecurityControlForm()
        {
            InitializeComponent();

        }

        private async void SecurityControlForm_Load(object sender, EventArgs e)
        {
            try
            {
                _doorClient = new TcpClient();
                await _doorClient.ConnectAsync("localhost", 2374).ConfigureAwait(false);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnArm_Click(object sender, EventArgs e)
        {
            // Logic to arm the security system
        }

        private void btnDisarm_Click(object sender, EventArgs e)
        {
            // Logic to disarm the security system
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (_doorClient is null) { return; }

            byte[] data = Encoding.UTF8.GetBytes(Message.Open.ToString());
            try
            {
                await _doorClient.GetStream().WriteAsync(data, 0, data.Length).ConfigureAwait(false);

                await _doorClient.GetStream().ReadAsync(data, 0, data.Length).ConfigureAwait(false);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

    enum Message
    {
        Open,
        Close,
    }
}
