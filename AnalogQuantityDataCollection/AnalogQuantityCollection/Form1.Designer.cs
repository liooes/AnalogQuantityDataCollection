namespace AnalogQuantityCollection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.cbxBaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCOMPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetHum = new System.Windows.Forms.Button();
            this.txtHumData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGetTmp = new System.Windows.Forms.Button();
            this.txtTmpData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxtemhumADD = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetElectricity = new System.Windows.Forms.Button();
            this.txtElectricity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnElectricCurrent = new System.Windows.Forms.Button();
            this.txtElectricCurrent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGetVoltage = new System.Windows.Forms.Button();
            this.txtVoltage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxSmartMeterADD = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenCom);
            this.groupBox1.Controls.Add(this.cbxBaudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxCOMPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打开串口";
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.Font = new System.Drawing.Font("宋体", 9F);
            this.btnOpenCom.Location = new System.Drawing.Point(535, 42);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(75, 23);
            this.btnOpenCom.TabIndex = 4;
            this.btnOpenCom.Text = "打开";
            this.btnOpenCom.UseVisualStyleBackColor = true;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // cbxBaudrate
            // 
            this.cbxBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudrate.Font = new System.Drawing.Font("宋体", 9F);
            this.cbxBaudrate.FormattingEnabled = true;
            this.cbxBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400"});
            this.cbxBaudrate.Location = new System.Drawing.Point(453, 44);
            this.cbxBaudrate.Name = "cbxBaudrate";
            this.cbxBaudrate.Size = new System.Drawing.Size(76, 20);
            this.cbxBaudrate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(370, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择波特率：";
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCOMPort.Font = new System.Drawing.Font("宋体", 9F);
            this.cbxCOMPort.FormattingEnabled = true;
            this.cbxCOMPort.Location = new System.Drawing.Point(125, 41);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Size = new System.Drawing.Size(61, 20);
            this.cbxCOMPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择串口号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnGetHum);
            this.groupBox2.Controls.Add(this.txtHumData);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnGetTmp);
            this.groupBox2.Controls.Add(this.txtTmpData);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxtemhumADD);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(13, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "温湿度采集";
            // 
            // btnGetHum
            // 
            this.btnGetHum.Font = new System.Drawing.Font("宋体", 9F);
            this.btnGetHum.Location = new System.Drawing.Point(230, 206);
            this.btnGetHum.Name = "btnGetHum";
            this.btnGetHum.Size = new System.Drawing.Size(75, 23);
            this.btnGetHum.TabIndex = 7;
            this.btnGetHum.Text = "获取";
            this.btnGetHum.UseVisualStyleBackColor = true;
            this.btnGetHum.Click += new System.EventHandler(this.btnGetHum_Click);
            // 
            // txtHumData
            // 
            this.txtHumData.Font = new System.Drawing.Font("宋体", 9F);
            this.txtHumData.Location = new System.Drawing.Point(124, 208);
            this.txtHumData.Name = "txtHumData";
            this.txtHumData.ReadOnly = true;
            this.txtHumData.Size = new System.Drawing.Size(62, 21);
            this.txtHumData.TabIndex = 9;
            this.txtHumData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F);
            this.label6.Location = new System.Drawing.Point(41, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "当前湿度值：";
            // 
            // btnGetTmp
            // 
            this.btnGetTmp.Font = new System.Drawing.Font("宋体", 9F);
            this.btnGetTmp.Location = new System.Drawing.Point(230, 115);
            this.btnGetTmp.Name = "btnGetTmp";
            this.btnGetTmp.Size = new System.Drawing.Size(75, 23);
            this.btnGetTmp.TabIndex = 5;
            this.btnGetTmp.Text = "获取";
            this.btnGetTmp.UseVisualStyleBackColor = true;
            this.btnGetTmp.Click += new System.EventHandler(this.btnGetTmp_Click);
            // 
            // txtTmpData
            // 
            this.txtTmpData.Font = new System.Drawing.Font("宋体", 9F);
            this.txtTmpData.Location = new System.Drawing.Point(124, 117);
            this.txtTmpData.Name = "txtTmpData";
            this.txtTmpData.ReadOnly = true;
            this.txtTmpData.Size = new System.Drawing.Size(62, 21);
            this.txtTmpData.TabIndex = 6;
            this.txtTmpData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(41, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "当前温度值：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(29, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "选择通信地址：";
            // 
            // cbxtemhumADD
            // 
            this.cbxtemhumADD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtemhumADD.Font = new System.Drawing.Font("宋体", 9F);
            this.cbxtemhumADD.FormattingEnabled = true;
            this.cbxtemhumADD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbxtemhumADD.Location = new System.Drawing.Point(124, 41);
            this.cbxtemhumADD.Name = "cbxtemhumADD";
            this.cbxtemhumADD.Size = new System.Drawing.Size(100, 20);
            this.cbxtemhumADD.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnGetElectricity);
            this.groupBox3.Controls.Add(this.txtElectricity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnElectricCurrent);
            this.groupBox3.Controls.Add(this.txtElectricCurrent);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnGetVoltage);
            this.groupBox3.Controls.Add(this.txtVoltage);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbxSmartMeterADD);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(344, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 294);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "智能电表采集";
            // 
            // btnGetElectricity
            // 
            this.btnGetElectricity.Font = new System.Drawing.Font("宋体", 9F);
            this.btnGetElectricity.Location = new System.Drawing.Point(228, 220);
            this.btnGetElectricity.Name = "btnGetElectricity";
            this.btnGetElectricity.Size = new System.Drawing.Size(75, 23);
            this.btnGetElectricity.TabIndex = 16;
            this.btnGetElectricity.Text = "获取";
            this.btnGetElectricity.UseVisualStyleBackColor = true;
            this.btnGetElectricity.Click += new System.EventHandler(this.btnGetElectricity_Click);
            // 
            // txtElectricity
            // 
            this.txtElectricity.Font = new System.Drawing.Font("宋体", 9F);
            this.txtElectricity.Location = new System.Drawing.Point(122, 222);
            this.txtElectricity.Name = "txtElectricity";
            this.txtElectricity.ReadOnly = true;
            this.txtElectricity.Size = new System.Drawing.Size(63, 21);
            this.txtElectricity.TabIndex = 18;
            this.txtElectricity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F);
            this.label9.Location = new System.Drawing.Point(39, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "当前电量值：";
            // 
            // btnElectricCurrent
            // 
            this.btnElectricCurrent.Font = new System.Drawing.Font("宋体", 9F);
            this.btnElectricCurrent.Location = new System.Drawing.Point(228, 161);
            this.btnElectricCurrent.Name = "btnElectricCurrent";
            this.btnElectricCurrent.Size = new System.Drawing.Size(75, 23);
            this.btnElectricCurrent.TabIndex = 13;
            this.btnElectricCurrent.Text = "获取";
            this.btnElectricCurrent.UseVisualStyleBackColor = true;
            this.btnElectricCurrent.Click += new System.EventHandler(this.btnElectricCurrent_Click);
            // 
            // txtElectricCurrent
            // 
            this.txtElectricCurrent.Font = new System.Drawing.Font("宋体", 9F);
            this.txtElectricCurrent.Location = new System.Drawing.Point(122, 163);
            this.txtElectricCurrent.Name = "txtElectricCurrent";
            this.txtElectricCurrent.ReadOnly = true;
            this.txtElectricCurrent.Size = new System.Drawing.Size(63, 21);
            this.txtElectricCurrent.TabIndex = 15;
            this.txtElectricCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F);
            this.label8.Location = new System.Drawing.Point(39, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "当前电流值：";
            // 
            // btnGetVoltage
            // 
            this.btnGetVoltage.Font = new System.Drawing.Font("宋体", 9F);
            this.btnGetVoltage.Location = new System.Drawing.Point(228, 94);
            this.btnGetVoltage.Name = "btnGetVoltage";
            this.btnGetVoltage.Size = new System.Drawing.Size(75, 23);
            this.btnGetVoltage.TabIndex = 10;
            this.btnGetVoltage.Text = "获取";
            this.btnGetVoltage.UseVisualStyleBackColor = true;
            this.btnGetVoltage.Click += new System.EventHandler(this.btnGetVoltage_Click);
            // 
            // txtVoltage
            // 
            this.txtVoltage.Font = new System.Drawing.Font("宋体", 9F);
            this.txtVoltage.Location = new System.Drawing.Point(122, 96);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.ReadOnly = true;
            this.txtVoltage.Size = new System.Drawing.Size(63, 21);
            this.txtVoltage.TabIndex = 12;
            this.txtVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F);
            this.label4.Location = new System.Drawing.Point(27, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "选择通信地址：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.Location = new System.Drawing.Point(39, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "当前电压值：";
            // 
            // cbxSmartMeterADD
            // 
            this.cbxSmartMeterADD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSmartMeterADD.Font = new System.Drawing.Font("宋体", 9F);
            this.cbxSmartMeterADD.FormattingEnabled = true;
            this.cbxSmartMeterADD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbxSmartMeterADD.Location = new System.Drawing.Point(122, 41);
            this.cbxSmartMeterADD.Name = "cbxSmartMeterADD";
            this.cbxSmartMeterADD.Size = new System.Drawing.Size(100, 20);
            this.cbxSmartMeterADD.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F);
            this.label10.Location = new System.Drawing.Point(192, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "℃";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F);
            this.label11.Location = new System.Drawing.Point(192, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "%RH";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F);
            this.label12.Location = new System.Drawing.Point(191, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "V";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F);
            this.label13.Location = new System.Drawing.Point(191, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F);
            this.label14.Location = new System.Drawing.Point(191, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 20;
            this.label14.Text = "KW·h";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 435);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.ComboBox cbxBaudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCOMPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetHum;
        private System.Windows.Forms.TextBox txtHumData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetTmp;
        private System.Windows.Forms.TextBox txtTmpData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxtemhumADD;
        private System.Windows.Forms.Button btnGetElectricity;
        private System.Windows.Forms.TextBox txtElectricity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnElectricCurrent;
        private System.Windows.Forms.TextBox txtElectricCurrent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGetVoltage;
        private System.Windows.Forms.TextBox txtVoltage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxSmartMeterADD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

