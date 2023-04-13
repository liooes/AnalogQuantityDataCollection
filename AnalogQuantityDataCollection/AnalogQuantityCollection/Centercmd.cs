using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogQuantityCollection
{
   public class Centercmd
    {
       /// <summary>
       /// 温湿度
       /// </summary>
       public byte[] bTmpHum = { 0x03, 0x00, 0x00, 0x00, 0x02 };

       /// <summary>
       /// 电量值
       /// </summary>
       public byte[] bElectricity = { 0x03, 0x00, 0x00, 0x00, 0x02 };

       /// <summary>
       /// 电压值
       /// </summary>
       public byte[] bVoltage = { 0x03, 0x00, 0x0C, 0x00, 0x01 };

       /// <summary>
       /// 电流值
       /// </summary>
       public byte[] bCurrent = { 0x03, 0x00, 0x0D, 0x00, 0x01 };
    }
}
