using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Reflection;

namespace EasyInfoSearch.Class
{
    public class DataGridViewImageValueColumn : DataGridViewImageColumn
    {
        public static Color _ProgressBarColor;




        public DataGridViewImageValueColumn()
        {
            CellTemplate = new DataGridViewImageValueCell(); ;
        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(DataGridViewImageValueCell)))
                {
                    throw new InvalidCastException("Must be a DataGridViewProgressCell");
                }
                base.CellTemplate = value;
            }
        }


    }
}


