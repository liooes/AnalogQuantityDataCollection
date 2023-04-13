using SerialPortHelpers;
using System; 

namespace AnalogQuantityCollection
{
    public class SmartMeterMode
    {
        SerialPortHelper sph;

        Centercmd centcmd = new Centercmd();
        /// <summary>
        /// 电压
        /// </summary>
        public string Voltage { get; set; }

        /// <summary>
        /// 电流
        /// </summary>
        public string ElectricCurrent { get; set; }

        /// <summary>
        /// 电量
        /// </summary>
        public string Electricity { get; set; }

        /// <summary>
        /// 初始化串口
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        public SmartMeterMode(string portName, string baudRate)
        {
            sph = new SerialPortHelper(portName, baudRate);
        }

        /// <summary>
        /// 发送查询电表数据
        /// </summary>
        /// <param name="modeAddress"></param>
        public void sendCMD(string modeAddress,byte[] cenCMD)
        {
            byte[] cmd = GetSendCMD(modeAddress,cenCMD);
            sph.sp_sendData(cmd);//发送查询命令 
        }


        /// <summary>
        /// 获取电量值
        /// </summary>
        /// <returns></returns>
        public void getElectricity()
        {
            sph.sp_DataReceive();//获取接收数据
            if (sph.strspRevData != null)
            {
                byte[] sm = new byte[4] { sph.strspRevData[3], sph.strspRevData[4], sph.strspRevData[5], sph.strspRevData[6] };
                formatSmartMeterData(sm,2);
            }
        }

        /// <summary>
        /// 获取电压值
        /// </summary>
        /// <returns></returns>
        public void getVoltage()
        {
            sph.sp_DataReceive();//获取接收数据
            if (sph.strspRevData != null)
            {
                byte[] sm = new byte[2] { sph.strspRevData[3], sph.strspRevData[4]};
                formatSmartMeterData(sm, 0);
            }
        }

        /// <summary>
        /// 获取电流值
        /// </summary>
        /// <returns></returns>
        public void getCurrent()
        {
            sph.sp_DataReceive();//获取接收数据
            if (sph.strspRevData != null)
            {
                byte[] sm = new byte[2] { sph.strspRevData[3], sph.strspRevData[4] };
                formatSmartMeterData(sm, 1);
            }
        }

     


         /// <summary>
        /// 转换电智能表值 
         /// </summary>
         /// <param name="sm">转换值</param>
        /// <param name="falg">0电压 1电流 2 电量</param>
        void formatSmartMeterData(byte[] sm,int falg)
        {
            //十进制 转 十六进制 转 十进制 除10 
            switch (falg)
            {
                case 0:
                    {
                        this.Voltage = (float.Parse(format16To10(format10To16(sm))) / 10).ToString();
                    } break;
                case 1:
                    {
                        this.ElectricCurrent = (float.Parse(format16To10(format10To16(sm))) / 100).ToString();
                    } break;
                case 2:
                    {
                        this.Electricity = (float.Parse(format16To10(format10To16(sm))) / 100).ToString();
                    } break;
            }

        }

         
        /// <summary>
        /// 十六进制转十进制
        /// </summary>
        /// <param name="str16"></param>
        /// <returns></returns>
        string format16To10(string str16)
        {
            return Convert.ToInt32(str16, 16).ToString();
        }

        /// <summary>
        /// 十六进制转十进制
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        string format10To16(byte[] b)
        {
            string str16 = "";
            for (int i = 0; i < b.Length; i++)
                str16 += Convert.ToString(b[i], 16);

            return str16;
        }

        /// <summary>
        /// 获取发送命令
        /// </summary>
        /// <param name="modeAddress">硬件地址</param>
        /// <returns>byte[]命令</returns>
        byte[] GetSendCMD(string modeAddress,byte[] bCentercmd)
        {
            byte address = byte.Parse(modeAddress);
             
            byte[] data1 = new byte[6];

            data1[0] = address;
            for (int i = 1; i <= bCentercmd.Length; i++)
                data1[i] = bCentercmd[i - 1];

            byte[] crc = CRC.CRC16(data1);

            byte[] bytcmd = new byte[8];
            for (int i = 0; i < data1.Length; i++)
                bytcmd[i] = data1[i];

            bytcmd[6] = crc[1];
            bytcmd[7] = crc[0];


            return bytcmd;
        }
    }
}
