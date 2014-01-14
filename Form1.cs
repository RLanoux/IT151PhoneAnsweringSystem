using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IT151PhoneAnsweringSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate(Int32 i)
        {
            if (i == 5)
            {
                //Randomly generate a number between 1000000000 and 10000000000
                Random rAreaCode = new Random();
                Random rExchange = new Random();
                Random rExtenstion = new Random();
                Int32 iAC = rAreaCode.Next(100, 1000);
                Int32 iExch = rExchange.Next(100, 1000);
                Int32 iExt = rExtenstion.Next(1000, 10000);
                DateTime dtNow = System.DateTime.Now.ToUniversalTime();
                String sIncoming = dtNow.ToString()
                    + " - "
                    + "(" + iAC.ToString() + ")"
                    + iExch.ToString() + " - "
                    + iExt.ToString();
                txtRecentCall.Text = sIncoming;
                mqIncomingCalls.Enqueue(sIncoming);
                tslStatus.Text = "Calls in Queue: "
                    + mqIncomingCalls.Count.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mbActivated)
            {
                Random rnd = new Random();
                Int32 i = rnd.Next(0, 10);
                Generate(i);
            }
        }

        Queue<String> mqIncomingCalls = new Queue<String>(100);

        Boolean mbActivated = false;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (mbActivated)
            {
                mbActivated = false;
                btnActivate.Text = "Activate System";
            }
            else
            {
                mbActivated = true;
                btnActivate.Text = "Deactivate System";
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (mqIncomingCalls.Count > 0)
            {
                String sAnswered = mqIncomingCalls.Dequeue();
                txtAnsweredCall.Text = sAnswered;
                tslStatus.Text = "Calls in Queue: "
                    + mqIncomingCalls.Count.ToString();
            }
        }
    }
}
