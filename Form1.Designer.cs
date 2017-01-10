namespace Winform_SerialPortTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Port = new System.Windows.Forms.Button();
            this.cb_PortName = new System.Windows.Forms.ComboBox();
            this.cb_BaudRate = new System.Windows.Forms.ComboBox();
            this.grp_PortSet = new System.Windows.Forms.GroupBox();
            this.cb_StopBit = new System.Windows.Forms.ComboBox();
            this.lab_StopBit = new System.Windows.Forms.Label();
            this.cb_DataBit = new System.Windows.Forms.ComboBox();
            this.lab_DataBit = new System.Windows.Forms.Label();
            this.lab_ParityBit = new System.Windows.Forms.Label();
            this.cb_ParityBit = new System.Windows.Forms.ComboBox();
            this.lab_BaudRate = new System.Windows.Forms.Label();
            this.lab_Port = new System.Windows.Forms.Label();
            this.pb_PortState = new System.Windows.Forms.PictureBox();
            this.grp_PortSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PortState)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Port
            // 
            this.btn_Port.Location = new System.Drawing.Point(55, 150);
            this.btn_Port.Name = "btn_Port";
            this.btn_Port.Size = new System.Drawing.Size(89, 33);
            this.btn_Port.TabIndex = 0;
            this.btn_Port.Text = "OpenPort";
            this.btn_Port.UseVisualStyleBackColor = true;
            this.btn_Port.Click += new System.EventHandler(this.btn_Port_Click);
            // 
            // cb_PortName
            // 
            this.cb_PortName.DropDownWidth = 89;
            this.cb_PortName.FormattingEnabled = true;
            this.cb_PortName.Location = new System.Drawing.Point(55, 20);
            this.cb_PortName.Name = "cb_PortName";
            this.cb_PortName.Size = new System.Drawing.Size(89, 20);
            this.cb_PortName.TabIndex = 1;
            // 
            // cb_BaudRate
            // 
            this.cb_BaudRate.FormattingEnabled = true;
            this.cb_BaudRate.Location = new System.Drawing.Point(55, 46);
            this.cb_BaudRate.Name = "cb_BaudRate";
            this.cb_BaudRate.Size = new System.Drawing.Size(89, 20);
            this.cb_BaudRate.TabIndex = 3;
            // 
            // grp_PortSet
            // 
            this.grp_PortSet.Controls.Add(this.pb_PortState);
            this.grp_PortSet.Controls.Add(this.cb_StopBit);
            this.grp_PortSet.Controls.Add(this.lab_StopBit);
            this.grp_PortSet.Controls.Add(this.btn_Port);
            this.grp_PortSet.Controls.Add(this.cb_DataBit);
            this.grp_PortSet.Controls.Add(this.lab_DataBit);
            this.grp_PortSet.Controls.Add(this.lab_ParityBit);
            this.grp_PortSet.Controls.Add(this.cb_ParityBit);
            this.grp_PortSet.Controls.Add(this.lab_BaudRate);
            this.grp_PortSet.Controls.Add(this.lab_Port);
            this.grp_PortSet.Controls.Add(this.cb_PortName);
            this.grp_PortSet.Controls.Add(this.cb_BaudRate);
            this.grp_PortSet.Location = new System.Drawing.Point(5, 5);
            this.grp_PortSet.Name = "grp_PortSet";
            this.grp_PortSet.Size = new System.Drawing.Size(150, 189);
            this.grp_PortSet.TabIndex = 4;
            this.grp_PortSet.TabStop = false;
            // 
            // cb_StopBit
            // 
            this.cb_StopBit.FormattingEnabled = true;
            this.cb_StopBit.Location = new System.Drawing.Point(55, 124);
            this.cb_StopBit.Name = "cb_StopBit";
            this.cb_StopBit.Size = new System.Drawing.Size(89, 20);
            this.cb_StopBit.TabIndex = 11;
            // 
            // lab_StopBit
            // 
            this.lab_StopBit.AutoSize = true;
            this.lab_StopBit.Location = new System.Drawing.Point(6, 127);
            this.lab_StopBit.Name = "lab_StopBit";
            this.lab_StopBit.Size = new System.Drawing.Size(41, 12);
            this.lab_StopBit.TabIndex = 10;
            this.lab_StopBit.Text = "停止位";
            this.lab_StopBit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_DataBit
            // 
            this.cb_DataBit.FormattingEnabled = true;
            this.cb_DataBit.Location = new System.Drawing.Point(55, 98);
            this.cb_DataBit.Name = "cb_DataBit";
            this.cb_DataBit.Size = new System.Drawing.Size(89, 20);
            this.cb_DataBit.TabIndex = 9;
            // 
            // lab_DataBit
            // 
            this.lab_DataBit.AutoSize = true;
            this.lab_DataBit.Location = new System.Drawing.Point(6, 101);
            this.lab_DataBit.Name = "lab_DataBit";
            this.lab_DataBit.Size = new System.Drawing.Size(41, 12);
            this.lab_DataBit.TabIndex = 8;
            this.lab_DataBit.Text = "数据位";
            this.lab_DataBit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_ParityBit
            // 
            this.lab_ParityBit.AutoSize = true;
            this.lab_ParityBit.Location = new System.Drawing.Point(6, 75);
            this.lab_ParityBit.Name = "lab_ParityBit";
            this.lab_ParityBit.Size = new System.Drawing.Size(41, 12);
            this.lab_ParityBit.TabIndex = 7;
            this.lab_ParityBit.Text = "校验位";
            this.lab_ParityBit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_ParityBit
            // 
            this.cb_ParityBit.FormattingEnabled = true;
            this.cb_ParityBit.Location = new System.Drawing.Point(55, 72);
            this.cb_ParityBit.Name = "cb_ParityBit";
            this.cb_ParityBit.Size = new System.Drawing.Size(89, 20);
            this.cb_ParityBit.TabIndex = 6;
            // 
            // lab_BaudRate
            // 
            this.lab_BaudRate.AutoSize = true;
            this.lab_BaudRate.Location = new System.Drawing.Point(6, 49);
            this.lab_BaudRate.Name = "lab_BaudRate";
            this.lab_BaudRate.Size = new System.Drawing.Size(41, 12);
            this.lab_BaudRate.TabIndex = 5;
            this.lab_BaudRate.Text = "波特率";
            this.lab_BaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Port
            // 
            this.lab_Port.AutoSize = true;
            this.lab_Port.Location = new System.Drawing.Point(12, 23);
            this.lab_Port.Name = "lab_Port";
            this.lab_Port.Size = new System.Drawing.Size(29, 12);
            this.lab_Port.TabIndex = 4;
            this.lab_Port.Text = "串口";
            this.lab_Port.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_PortState
            // 
            this.pb_PortState.BackColor = System.Drawing.SystemColors.Control;
            this.pb_PortState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_PortState.ErrorImage = global::Winform_SerialPortTools.Properties.Resources.BlackLED_Close_PortState;
            this.pb_PortState.Image = global::Winform_SerialPortTools.Properties.Resources.BlackLED_Close_PortState;
            this.pb_PortState.InitialImage = global::Winform_SerialPortTools.Properties.Resources.BlackLED_Close_PortState;
            this.pb_PortState.Location = new System.Drawing.Point(8, 144);
            this.pb_PortState.Name = "pb_PortState";
            this.pb_PortState.Size = new System.Drawing.Size(39, 39);
            this.pb_PortState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_PortState.TabIndex = 5;
            this.pb_PortState.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 357);
            this.Controls.Add(this.grp_PortSet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_PortSet.ResumeLayout(false);
            this.grp_PortSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PortState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Port;
        private System.Windows.Forms.GroupBox grp_PortSet;
        private System.Windows.Forms.ComboBox cb_StopBit;
        private System.Windows.Forms.Label lab_StopBit;
        private System.Windows.Forms.ComboBox cb_DataBit;
        private System.Windows.Forms.Label lab_DataBit;
        private System.Windows.Forms.Label lab_ParityBit;
        private System.Windows.Forms.ComboBox cb_ParityBit;
        private System.Windows.Forms.Label lab_BaudRate;
        private System.Windows.Forms.Label lab_Port;
        private System.Windows.Forms.PictureBox pb_PortState;
        public System.Windows.Forms.ComboBox cb_PortName;
        private System.Windows.Forms.ComboBox cb_BaudRate;

    }
}

