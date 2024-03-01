using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public static class Helper
    {
        public static DataGridViewTextBoxColumn BuildColumnName(string propertyName, string nameColumn)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = propertyName;
            column.HeaderText = nameColumn;
            return column;
        }
    }
}
