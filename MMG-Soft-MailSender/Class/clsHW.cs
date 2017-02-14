using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace MMG_Soft_MailSender.Class
{
    class clsHW
    {
        public string udfGetCPUId()
        {
            string res = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            PropertyData cpu;

            
            foreach (ManagementObject m in searcher.Get())
            {
                cpu = m.Properties.Cast<PropertyData>().Where(z => z.Name == "ProcessorId").FirstOrDefault();
                res = cpu.Value.ToString();
                break;
            }



            return res;
        }

        //public string driveser(string model)
        //{
        //    string functionReturnValue = null;
        //    string devid = "";
        //    functionReturnValue = "";
        //    try
        //    {
        //        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive WHERE Model LIKE '%" + model + "%'");
        //        foreach (ManagementObject queryObj in searcher.Get())
        //        {
        //            if (!string.IsNullOrEmpty(queryObj("SerialNumber")))
        //                functionReturnValue = queryObj("SerialNumber");
        //            Debug.Print(queryObj("Model") + ":" + functionReturnValue);
        //        }
        //    }
        //    catch (ManagementException err)
        //    {
        //        Debug.Print("An error occurred while querying for WMI data: " + err.Message);
        //    }
        //    return functionReturnValue;
        //}
    }
}
