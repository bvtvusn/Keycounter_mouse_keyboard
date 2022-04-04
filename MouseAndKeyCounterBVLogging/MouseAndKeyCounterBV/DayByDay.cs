using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DayByDay : Form
    {
        public DayByDay(List<DateTime> dates, List<int> keyboard, List<int> mouse)
        {
            InitializeComponent();
            this.Icon = WindowsFormsApplication1.Properties.Resources.telle;
            this.dataGridView1.Columns["Column1"].DefaultCellStyle.Format = "dd.MM.yyyy";
            //DataGridViewColumn column1 = dataGridView1.Columns["Column1"];
            //dataGridView1.Sort(column1,ListSortDirection.Descending);
            for (int j = 0; j < dates.Count; j++)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = dates[j] });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = keyboard[j] });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = mouse[j] });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = mouse[j] + keyboard[j] });
                dataGridView1.Rows.Add(row);
            }
            dataGridView1.Sort(Column1, ListSortDirection.Descending);
        }
    }
}
