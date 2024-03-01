using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCustom
{
    public class TextBoxNumber : TextBox
    {
        bool checkDouble = false;
        double? minValue = null;
        double? maxValue = null;

        public TextBoxNumber()
        {
            this.KeyPress += TextBoxNumber_KeyPress;            
        }
       
        public bool CheckDouble { get => checkDouble; set => checkDouble = value; }
        public double? MinValue { get => minValue; set => minValue = value; }
        public double? MaxValue { get => maxValue; set => maxValue = value; }

        private void TextBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(CheckDouble && e.KeyChar == '.'))
            {
                e.Handled = true;
                return;
            }
            string newText = this.Text + e.KeyChar;
            if (!string.IsNullOrEmpty(newText))
            {
                if (int.TryParse(newText, out int value))
                {
                    if ((MaxValue != null && value > MaxValue) || (MinValue != null && value < MinValue))
                    {                                                
                            e.Handled = true;                        
                    }                    
                }
            }            
        }       
    }
}
