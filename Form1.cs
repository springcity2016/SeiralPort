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
        const uint MAXCOM_COUNT = 16;
        private string[] strBaudBit = {"300","600","1200","2400","4800","9600","19200","38400","43000","56000","57600","115200" };
        private string[] strParityBit = { "NONE","ODD","EVEN"};
        private string[] strDataBit = { "8","7","6"};
        private string[] strStopBit = { "1","2"};

        private Boolean bfPortState;
        private SerialPort serialPort = null;
		private Boolean bfHex;
		

        private void Form1_Load(object sender, EventArgs e)
        {
            Init_PortSet();
            
        }

        private void Init_PortSet()
        {
            bfPortState = false;
			bfHex = false;
			cb_Hex.Checked = false;
			cb_Char.Checked = true;
			this.btn_Port.Text = "打开串口";
            Init_PortName();
            Init_PortBaudBit();
            Init_PortParityBit();
            Init_PortDataBit();
            Init_PortStopBit();
        }
        private void Init_PortName()
        {
			cb_PortName.Items.Clear();
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
                this.cb_DataBit.Items.Add(strDataBit[i]);
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
		private Boolean CheckPortSetting()
		{
			if(cb_PortName.Text.Trim() == "") return false;
			return true;
		}
		private void SetPortProperty()
		{
			serialPort = new SerialPort();
			serialPort.PortName = cb_PortName.Text.Trim();
			serialPort.BaudRate = Convert.ToInt32(cb_BaudRate.Text.Trim());
			float f = Convert.ToSingle(cb_StopBit.Text.Trim());
			if(f==0){
				serialPort.StopBits = StopBits.None;
			}else if(f==1){
				serialPort.StopBits = StopBits.One;
			}else if(f==1.5){
				serialPort.StopBits = StopBits.OnePointFive;
			}else if(f==2){
                serialPort.StopBits = StopBits.Two;
			}else{
				serialPort.StopBits = StopBits.One;	
			}
			serialPort.DataBits = Convert.ToInt16(cb_DataBit.Text.Trim());
			
			string strParityBit = cb_ParityBit.Text.Trim();
			if(strParityBit=="NONE"){
				serialPort.Parity = Parity.None;
			}else if(strParityBit == "ODD"){
				serialPort.Parity = Parity.Odd;
			}else if(strParityBit == "EVEN"){
				serialPort.Parity = Parity.Even;
			}else{
				serialPort.Parity = Parity.None;
			}
		}
		private void SearchPort()
		{
			Boolean bfExistence = false;
			for(int i=0; i< MAXCOM_COUNT; i++)
			{
				try
				{
					SerialPort serialPort = new SerialPort("COM"+(i+1).ToString());
					serialPort.Open();
					serialPort.Close();
					cb_PortName.Items.Add("COM"+(i+1).ToString());
					bfExistence = true;
				}
				catch
				{
					continue;	
				}		
			}
			if(bfExistence)
			{
				cb_PortName.SelectedIndex = 0;
			}
			else
			{
				MessageBox.Show("没有找到可用串口!","错误提示");
			}				
		}
        private void btn_Port_Click(object sender, EventArgs e)
        {
			if(this.btn_Port.Text == "关闭串口")
			{
				bfPortState = false;
			}
			else
			{
				bfPortState = true;
			}
			          
            if (bfPortState)
            {
				if(!CheckPortSetting())
				{
					//SearchPort();
					MessageBox.Show("串口未设置!","错误提示");
					return;
				}
				else
				{
					SetPortProperty();
				}
				try
				{
					serialPort.Open();
					bfPortState = true;
					cb_PortName.Enabled = false;
					cb_BaudRate.Enabled = false;
					cb_ParityBit.Enabled = false;
					cb_DataBit.Enabled = false;
					cb_StopBit.Enabled = false;
					cb_Char.Enabled = false;
					cb_Hex.Enabled = false;
					btn_CheckPort.Enabled = false;
					this.btn_Port.Text = "关闭串口";
					this.pb_PortState.Image = Winform_SerialPortTools.Properties.Resources.RedLED_Open_PortState;
				}
				catch(Exception)
				{
					bfPortState = false;
					MessageBox.Show("串口无效或已被占用!","错误提示");
				}		
            }
            else 
            {
				try
				{
					serialPort.Close();
					bfPortState = false;
					cb_PortName.Enabled = true;
					cb_BaudRate.Enabled = true;
					cb_ParityBit.Enabled = true;
					cb_DataBit.Enabled = true;
					cb_StopBit.Enabled = true;
					cb_Char.Enabled = true;
					cb_Hex.Enabled = true;
					btn_CheckPort.Enabled = true;
					this.btn_Port.Text = "打开串口";
					this.pb_PortState.Image = Winform_SerialPortTools.Properties.Resources.BlackLED_Close_PortState;       
				}
				catch(Exception)
				{
					MessageBox.Show("关闭串口时发生错误");
				}
			}
			
        }

        private void cb_StopBit_SelectedIndexChanged(object sender, EventArgs e)
        {
			
        }

        private void btn_CheckPort_Click(object sender, EventArgs e)
        {
			SearchPort();
        }

        private void cb_Hex_Click(object sender, EventArgs e)
        {
			if(cb_Char.Checked==true)
			{
                cb_Char.Checked = false;
			}
			if(cb_Hex.Checked==false)
			{
                cb_Hex.Checked = true;
                bfHex = true;
			}
        }

        private void cb_Char_Click(object sender, EventArgs e)
        {
			if(cb_Hex.Checked==true)
			{
                cb_Hex.Checked = false;
			}
			if(cb_Char.Checked==false)
			{
                cb_Char.Checked = true;
                bfHex = false;
			}
        }

    }
}
