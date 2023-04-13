using SerialPortHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogQuantityCollection
{
    public partial class Form1 : Form
    {
        TempHumMode thm;
        SmartMeterMode smm;
        SerialPortHelper sph;
        Centercmd cencmd = new Centercmd();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置串口参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenCom_Click(object sender, EventArgs e)
        {
            if (btnOpenCom.Text.Equals("打开"))
            {
                btnOpenCom.Text = "关闭";
                thm = new TempHumMode(cbxCOMPort.Text, cbxBaudrate.Text);
                smm = new SmartMeterMode(cbxCOMPort.Text, cbxBaudrate.Text);
                sph = new SerialPortHelper(cbxCOMPort.Text, cbxBaudrate.Text);
            }
            else
            {
                btnOpenCom.Text = "打开";
                 sph = new SerialPortHelper(cbxCOMPort.Text, cbxBaudrate.Text);
                try
                {
                    sph.CloseSerialPort();
                }
                catch { }
            }
        }

        /// <summary>
        /// 获取温度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetTmp_Click(object sender, EventArgs e)
        {
            if (btnOpenCom.Text.Equals("关闭"))
            {
                thm.sendCMD("0" + cbxtemhumADD.Text,cencmd.bTmpHum);
                thm.getTempHumData();//获取温度值 

                if (thm.Temperature != null) 
                    txtTmpData.Text = thm.Temperature.ToString(); 
            } 
        }

        /// <summary>
        /// 获取湿度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetHum_Click(object sender, EventArgs e)
        {
            if (btnOpenCom.Text.Equals("关闭"))
            {
                thm.sendCMD("0" + cbxtemhumADD.Text, cencmd.bTmpHum);
                thm.getTempHumData();

                if (thm.Humidity != null)
                    txtHumData.Text = thm.Humidity.ToString();
            }
            
        }

        /// <summary>
        /// 载入必要参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            settingCOM();
            cbxCOMPort.SelectedIndex = 1;
            cbxBaudrate.SelectedIndex = 0;
            cbxtemhumADD.SelectedIndex = 0;
            cbxSmartMeterADD.SelectedIndex = 0;
        }

        /// <summary>
        /// 释放串口资源
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        { 
            try
            {
                sph.CloseSerialPort();
            }
            catch { }
            base.OnClosed(e);
        }

        /// <summary>
        /// 设置串口号
        /// </summary>
        private void settingCOM()
        {
            try
            {
                string[] str = SerialPort.GetPortNames();
                for (int i = 0; i < str.Length; i++)
                    cbxCOMPort.Items.Add(str[i]);
            }
            catch { }
        }

        /// <summary>
        /// 获取电压
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetVoltage_Click(object sender, EventArgs e)
        {
            if (btnOpenCom.Text.Equals("关闭"))
            {
                smm.sendCMD("0" + cbxSmartMeterADD.Text, cencmd.bVoltage);
                smm.getVoltage();

                if (smm.Voltage != null)
                    txtVoltage.Text = smm.Voltage.ToString();
            } 
        }

        /// <summary>
        /// 获取电流
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnElectricCurrent_Click(object sender, EventArgs e)
        {
            if (btnOpenCom.Text.Equals("关闭"))
            {
                smm.sendCMD("0" + cbxSmartMeterADD.Text, cencmd.bCurrent);
                smm.getCurrent();
                
                if (smm.ElectricCurrent != null)
                    txtElectricCurrent.Text = smm.ElectricCurrent.ToString();
            } 
        }

        /// <summary>
        /// 获取电量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetElectricity_Click(object sender, EventArgs e)
        {
            if (btnOpenCom.Text.Equals("关闭"))
            {
                smm.sendCMD("0" + cbxSmartMeterADD.Text, cencmd.bElectricity);
                smm.getElectricity();
                
                if (smm.Electricity != null)
                    txtElectricity.Text = smm.Electricity.ToString();
            } 
        }
    }
}
