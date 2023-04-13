using SerialPortHelpers;
using System;
using System.Threading; 

namespace AnalogQuantityCollection
{
    public class TempHumMode
    {
        SerialPortHelper sph;
        public string Temperature { get; set; }
        public string Humidity { get; set; }

        /// <summary>
        /// 初始化串口
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        public TempHumMode(string portName, string baudRate)
        {
            sph = new SerialPortHelper(portName, baudRate);
        }
         
        /// <summary>
        /// 获取温湿度值
        /// </summary>
        /// <returns></returns>
        public void getTempHumData()
        { 
            sph.sp_DataReceive();//获取接收数据
            if (sph.strspRevData != null)
            {
                //sph.strspRevData; 
                byte[] tmp = new byte[2] { sph.strspRevData[5], sph.strspRevData[6] };
                byte[] hum = new byte[2] { sph.strspRevData[3], sph.strspRevData[4] };
                formatTempHumData(tmp, hum);
            }
        }

        /// <summary>
        /// 发送查询数据
        /// </summary>
        /// <param name="modeAddress"></param>
        public void sendCMD(string modeAddress, byte[] cenCMD)
        {
            byte[] cmd = GetSendCMD(modeAddress, cenCMD);
            sph.sp_sendData(cmd);//发送查询命令 
        }

        /// <summary>
        /// 格式化温湿度值
        /// </summary>
        /// <param name="tmp">温度</param>
        /// <param name="hum">湿度</param>
        private void formatTempHumData(byte[] tmp, byte[] hum)
        {
            //十进制 转 十六进制 转 十进制 除10 
            this.Temperature = (float.Parse(format16To10(format10To16(tmp))) / 10).ToString();

            float fhum = float.Parse(format16To10(format10To16(hum)));
            this.Humidity = (fhum / 10).ToString(); 
        }

        /// <summary>
        /// 十六进制转十进制
        /// </summary>
        /// <param name="str16"></param>
        /// <returns></returns>
        string format16To10(string str16)
        {
            return  Convert.ToInt32(str16, 16).ToString();
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

        ///// <summary>
        ///// 获取发送命令
        ///// </summary>
        ///// <param name="modeAddress">硬件地址</param>
        ///// <returns>byte[]命令</returns>
        //byte[] GetSendCMD(string modeAddress)
        //{
        //    byte address = byte.Parse(modeAddress);

        //    byte[] data = { 03, 00, 00, 00, 02 };
        //    byte[] data1 = new byte[6];

        //    data1[0] = address;
        //    for (int i = 1; i <= data.Length; i++)
        //        data1[i] = data[i - 1];

        //    byte[] crc = CRC.CRC16(data1);

        //    byte[] bytcmd = new byte[8];
        //    for (int i = 0; i < data1.Length; i++)
        //        bytcmd[i] = data1[i];

        //    bytcmd[6] = crc[1];
        //    bytcmd[7] = crc[0];


        //    return bytcmd;
        //}

        /// <summary>
        /// 获取发送命令
        /// </summary>
        /// <param name="modeAddress">硬件地址</param>
        /// <returns>byte[]命令</returns>
        byte[] GetSendCMD(string modeAddress, byte[] bCentercmd)
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
