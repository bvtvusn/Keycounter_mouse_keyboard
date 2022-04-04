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
    public partial class History : Form
    {
        
        List<DateTime> dates;
        List<int> keyboard, mouse;

        public History(List<DateTime> inputDates, List<int> keyboardList, List<int> mouseList)
        {
            InitializeComponent();
            this.dtStartDate.ValueChanged -= new System.EventHandler(this.dtStartDate_ValueChanged);
            this.dtEndDate.ValueChanged -= new System.EventHandler(this.dtEndDate_ValueChanged);
            this.Icon = WindowsFormsApplication1.Properties.Resources.telle;

            CreateDataArrays(inputDates, mouseList, keyboardList);
            dtStartDate.Value = DateTime.Today.AddMonths(-1);
            dtEndDate.Value = DateTime.Today;
            ShowGraph();

            this.dtEndDate.ValueChanged += new System.EventHandler(this.dtEndDate_ValueChanged);
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
        }
        void CreateDataArrays(List<DateTime> inputDates, List<int> mouseList, List<int> keyboardList)
        {
            int count = inputDates.Count;
            List<DateTime> distinctDate = inputDates.Distinct().ToList();

            int[] mouseCombined = new int[distinctDate.Count];
            int[] keyboardCombined = new int[distinctDate.Count];

            for (int i = 0; i < count; i++)
            {
                DateTime current = inputDates[i];
                int index = FindIndex(distinctDate, current);
                mouseCombined[index] += mouseList[i];
                keyboardCombined[index] += keyboardList[i];
            }

            keyboard = keyboardCombined.ToList();
            mouse = mouseCombined.ToList();
            dates = distinctDate;
        }
        void ShowGraph() //List<DateTime> datesTemp, List<int> keyboardTemp, List<int> mouseTemp
        {
            List<DateTime> datesTemp = new List<DateTime>(dates);
            List<int> keyboardTemp = new List<int>(keyboard);
            List<int> mouseTemp = new List<int>(mouse);

            DateTime start = dtStartDate.Value;
            DateTime end = dtEndDate.Value;


            for (int i = datesTemp.Count - 1; i >= 0; i--)
            {
                if (start > datesTemp[i] || end < datesTemp[i])
                {
                    datesTemp.RemoveAt(i);
                    mouseTemp.RemoveAt(i);
                    keyboardTemp.RemoveAt(i);
                }
            }

            HistoryChart.Series["Tastatur"].Points.Clear();
            HistoryChart.Series["Mus"].Points.Clear();

            HistoryChart.Series["Tastatur"].Points.DataBindXY(datesTemp, keyboardTemp);
            HistoryChart.Series["Mus"].Points.DataBindXY(datesTemp, mouseTemp);
        }

        private void numDays_ValueChanged(object sender, EventArgs e)
        {
            ShowGraph();
        }

        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {
            ShowGraph();
        }

        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            ShowGraph();
        }

        private void btnDayByDay_Click(object sender, EventArgs e)
        {
            DayByDay dayByDay1 = new DayByDay(dates, keyboard, mouse);
            dayByDay1.Show();
        }

        int FindIndex(List<DateTime> tempList, DateTime test)
        {
            int index = -1;
            for (int i = 0; i < tempList.Count; i++)
            {
                if (tempList[i] == test)
                    index = i;
            }
            return index;
        }
    }
}
