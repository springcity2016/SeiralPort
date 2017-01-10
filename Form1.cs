using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Winform_SerialPortTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const uint _9600_ = 5;
        private string[] strBaudBit = {"300","600","1200","2400","4800","9600","19200","38400","43000","56000","57600","115200" };
        private string[] strParityBit = { "NONE","ODD","EVEN"};
        private string[] strDataBit = { "8","7","6"};
        private string[] strStopBit = { "1","2"};

        private Boolean bfPortState;

        private void Form1_Load(object sender, EventArgs e)
        {
            Init_PortSet();
            
        }

        private void Init_PortSet()
        {
            bfPortState = false;
            Init_PortName();
            Init_PortBaudBit();
            Init_PortParityBit();
            Init_PortDataBit();
            Init_PortStopBit();
        }

        private void Init_PortName()
        {

        }
        private void Init_PortBaudBit()
        {
            for (int i=0; i < strBaudBit.Length; i++)
            {
                this.cb_BaudRate.Items.Add(strBaudBit[i]);
            }
            //this.cb_BaudRate.Text = strBaudBit[5];
            this.cb_BaudRate.SelectedIndex = (int)_9600_;
        }
        private void Init_PortParityBit()
        {
            for(int i=0; i<strParityBit.Length; i++)
            {
                this.cb_ParityBit.Items.Add(strParityBit[i]);
            }
            //this.cb_ParityBit.Text = strParityBit[0];
            this.cb_ParityBit.SelectedIndex = 0;
        }
        private void Init_PortDataBit()
        {
            for(int i=0; i<strParityBit.Length; i++)
            {
                this.cb_DataBit.Items.Add(strParityBit[i]);
            }
            //this.cb_DataBit.Text = strParityBit[0];
            this.cb_DataBit.SelectedIndex = 0;
        }
        private void Init_PortStopBit()
        {
            for(int i=0; i<strStopBit.Length;i++)
            {
                this.cb_StopBit.Items.Add(strStopBit[i]);
            }
            //this.cb_StopBit.Text = strStopBit[0];
            this.cb_StopBit.SelectedIndex = 0;
        }

        private void btn_Port_Click(object sender, EventArgs e)
        {
            bfPortState = !bfPortState;
            if (bfPortState)
            {
                this.btn_Port.Text = "ClosePort";
                this.pb_PortState.Image = Winform_SerialPortTools.Properties.Resources.RedLED_Open_PortState;
            }
            else 
            {
                this.btn_Port.Text = "OpenPort";
                this.pb_PortState.Image = Winform_SerialPortTools.Properties.Resources.BlackLED_Close_PortState;       
            }
        }

    }
}
