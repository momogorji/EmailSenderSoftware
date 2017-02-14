using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace EasyInfoSearch.Class
{

    class DataGridViewImageValueCell : DataGridViewImageCell
    {
        // Used to make custom cell consistent with a DataGridViewImageCell
        static Image emptyImage;


       
        static DataGridViewImageValueCell()
        {
            emptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }
        public DataGridViewImageValueCell()
        {
            this.ValueType = typeof(int);
        }
        // Method required to make the Progress Cell consistent with the default Image Cell.
        // The default Image Cell assumes an Image as a value, although the value of the Progress Cell is an int.
        protected override object GetFormattedValue(object value,
            int rowIndex, ref DataGridViewCellStyle cellStyle,
            TypeConverter valueTypeConverter,
            TypeConverter formattedValueTypeConverter,
            DataGridViewDataErrorContexts context)
        {
            return emptyImage;
        }

        protected override void Paint(System.Drawing.Graphics g,
            System.Drawing.Rectangle clipBounds,
            System.Drawing.Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates cellState,
            object value, object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            if (Convert.ToInt16(value) == 0 || value == null)
            {
                value = 0;
            }

            //int progressVal = Convert.ToInt32(value);

            //float percentage = ((float)progressVal / 100.0f); // Need to convert to float before division; otherwise C# returns int which is 0 for anything but 100%.
            Brush backColorBrush = new SolidBrush(cellStyle.BackColor);
            Brush foreColorBrush = new SolidBrush(cellStyle.ForeColor);

            // Draws the cell grid
            base.Paint(g, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, (paintParts & ~DataGridViewPaintParts.ContentForeground));

            float posX = cellBounds.X + cellBounds.Width / 3;
            float posY = cellBounds.Y;




            //Draw image             
            switch ((int)value)
            {
                case (int)MMG_Soft_MailSender.Class.clsPublic.enStatus.Unsend:
                    g.DrawImage(MMG_Soft_MailSender.Properties.Resources.mail_new, posX, posY);
                    break;
                case (int)MMG_Soft_MailSender.Class.clsPublic.enStatus.Send:
                    g.DrawImage(MMG_Soft_MailSender.Properties.Resources.mail_send, posX, posY);
                    break;
                case (int)MMG_Soft_MailSender.Class.clsPublic.enStatus.Err:
                    g.DrawImage(MMG_Soft_MailSender.Properties.Resources.Error_send, posX, posY);
                    break;
                case (int)MMG_Soft_MailSender.Class.clsPublic.enStatus.Block:
                    g.DrawImage(MMG_Soft_MailSender.Properties.Resources.Blocked, posX, posY);
                    break;
                default:
                    break;
            }


        }

        public override object Clone()
        {
            DataGridViewImageValueCell dataGridViewCell = base.Clone() as DataGridViewImageValueCell;
            
            return dataGridViewCell;
        }

     

    }


}
