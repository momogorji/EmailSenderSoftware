using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace MMG_Soft_MailSender.Class
{
    class clsRetrieveExcelSheet
    {

        public String[] GetExcelSheetNames(string excelFile)
        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;

            try
            {
                // Connection String. Change the excel file to the file you

                // will search.

                String connString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                    "Data Source=" + excelFile + ";Extended Properties=Excel 8.0;";
                // Create connection object by using the preceding connection string.

                objConn = new OleDbConnection(connString);
                // Open connection with the database.

                objConn.Open();
                // Get the data table containg the schema guid.

                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if (dt == null)
                {
                    return null;
                }

                String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;

                // Add the sheet name to the string array.

                foreach (DataRow row in dt.Rows)
                {
                    excelSheets[i] = row["TABLE_NAME"].ToString();
                    i++;
                }

                // Loop through all of the sheets if you want too...

                for (int j = 0; j < excelSheets.Length; j++)
                {
                    // Query each excel sheet.

                }

                return excelSheets;
            }
            catch (Exception )
            {
                return null;
            }
            finally
            {
                // Clean up.

                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable GetExcelSheetData(string excelFile,string SheetName)
        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;
            try
            {
                DataSet ds = new DataSet();
                // Connection String. 
                String connString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" +
                        excelFile + ";Extended Properties=Excel 8.0;";
                // Create connection. 
                objConn = new OleDbConnection(connString);
                // Opens connection with the database. 
                objConn.Open();
                // Get the data table containing the schema guid, and also sheet names. 
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (dt == null)
                {
                    return null;
                }



                
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM ["
                            + SheetName + "]", objConn);
                OleDbDataAdapter oleda = new OleDbDataAdapter();
                oleda.SelectCommand = cmd;
                oleda.Fill(ds, "TABLE");

 
                    return ds.Tables[0];
                
                
            }
            catch (Exception )
            {
                return null;

            }
            finally
            {
                // Clean up. 
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }

    }
}
