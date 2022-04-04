using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int mouseCounter, keyboardCounter, mouseCounterTemp, keyboardCounterTemp;
        DateTime startTime, today;
        bool logfileExists;

        string mainFilePath, customDatetimeFormat;
        //Forslag:
        //    Automatisk oppstart
        //    pauseknapp
        //    logging hvert x minutt og totaloversikt
        //    valg av trykk som skal telles
        //    lagring ved midnatt (eller oppvåkning fra dvale)
        //    valgfritt tidsrom for graf

        public Form1()
        {

            InitializeComponent();
            SystemEvents.PowerModeChanged += OnPowerModeChanged;
            logfileExists = false;

            KeyboardHook.Start();
            KeyboardHook.KeyboardAction += new KeyEventHandler(KeyboardEvent);
            MouseHook.Start();
            MouseHook.MouseAction += new EventHandler(MouseEvent);
            mouseCounter = 0;
            keyboardCounter = 0;
            //this.notifyIcon1.Icon = SystemIcons.Application;
            //Icon icon = Icon.ExtractAssociatedIcon("telle.ico");
            Icon icon = WindowsFormsApplication1.Properties.Resources.telle;

            this.Icon = icon;
            this.notifyIcon1.Icon = icon;
            notifyIcon1.Visible = false;
            startTime = DateTime.Now;
            toolStripStatusLabel1.Text = "Starttidspunkt: " + startTime.ToString("d. MMMM yyyy, klokken HH:mm");
            mainFilePath = "logfile.txt";
            customDatetimeFormat = "dd-MM-yyyy"; //HH':'mm':'ss";
            CheckForFile();
            ShowLogState();
            today = DateTime.Today;
            ActivateTimer();
        }
        private void OnPowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            // Event som kjøres hver gang PCen åpnes eller lukkes
            
            if (today != DateTime.Today)
            {
                VisibleReset();
            }
            CompleteSave();
            ActivateTimer();
           
        }
        void ActivateTimer()
        {
            timer1.Enabled = false;
            //Settimer:
            TimeSpan remainingTime;
            DateTime tomorrow = DateTime.Today.AddDays(1);
            remainingTime = (tomorrow - DateTime.Now);
            timer1.Interval = (int)remainingTime.TotalMilliseconds;
            timer1.Enabled = true;
        }
        private void KeyboardEvent(object sender, KeyEventArgs e)
        {
            keyboardCounter++;
            keyboardCounterTemp++;
            txtKeyboard.Text = keyboardCounter.ToString();
            ShowSum();
        }
        private void MouseEvent(object sender, EventArgs e)
        {
            mouseCounter++;
            mouseCounterTemp++;
            txtMouse.Text = mouseCounter.ToString();
            ShowSum();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;     //Icon i systemTray Blir Synlig
            this.Hide();
            //notifyIcon1.ShowBalloonTip();
            notifyIcon1.ShowBalloonTip(500,"Lagt til i system-tray","Programmet arbeider fortsatt", ToolTipIcon.Info);


        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        void StartLogging()
        {
            //tmrSaveToFile.Enabled = true;
            if (!File.Exists(mainFilePath))
            {
                StreamWriter bw = new StreamWriter(File.Create(mainFilePath));
                //bw.WriteLine("Enabled");
                bw.WriteLine("Date,Keyboard,Mouse");
                bw.Close();
                bw.Dispose();

            }
            
            logfileExists = true;
            ShowLogState();
        }
        
        void ShowLogState()
        {
            if (logfileExists)
            {
                txtloggingStatus.Text = "Logging på";
                txtloggingStatus.BackColor = Color.LightGreen;
                //btnStartLogging.Enabled = false;
                //btnSaveAndReset.Enabled = true;
                btnLogging.Text = "Lagre og nullstill";
                btnShowGraph.Enabled = true;

            }
            else
            {
                txtloggingStatus.Text = "Logging av";
                txtloggingStatus.BackColor = Color.LightCoral;
                //btnStartLogging.Enabled = true;
                //btnSaveAndReset.Enabled = false;
                btnLogging.Text = "Start Logging";
                btnShowGraph.Enabled = false;
            }
        }

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            CompleteSave();
            try
            {


                string linecontent;
                StreamReader streamReader = File.OpenText(mainFilePath);
                List<DateTime> dates = new List<DateTime>();
                List<int> keyboardList = new List<int>();
                List<int> mouseList = new List<int>();

                streamReader.ReadLine();
                linecontent = streamReader.ReadLine();
                while (linecontent != null)
                {
                    string date;
                    DateTime tempDate;
                    string[] lineparts = linecontent.Split(',');
                    keyboardList.Add(Convert.ToInt32(lineparts[1]));
                    mouseList.Add(Convert.ToInt32(lineparts[2]));

                    date = lineparts[0];
                    tempDate = DateTime.ParseExact(date, customDatetimeFormat, CultureInfo.InvariantCulture);
                    dates.Add(tempDate);
                    //dates.Add(Convert.ToDateTime(lineparts[0], CultureInfo.InvariantCulture));

                    linecontent = streamReader.ReadLine();
                }
                streamReader.Close();
                History newWindow = new History(dates, keyboardList, mouseList);
                newWindow.Show();
            }
            catch(Exception error) { MessageBox.Show(error.Message); }

        }

        private void btnSaveAndReset_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            toolStripStatusLabel1.Text = "Starttidspunkt: " + startTime.ToString("d. MMMM yyyy, klokken HH:mm");
            CompleteSave();
            keyboardCounter = 0;
            mouseCounter = 0;
            txtKeyboard.Text = keyboardCounter.ToString();
            txtMouse.Text = mouseCounter.ToString();
            ShowSum();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (logfileExists)
            {
                CompleteSave();
            }
        }

        void CompleteSave()
        {

            today = DateTime.Today;
            if (mouseCounterTemp + keyboardCounterTemp > 4)
            {


                
                DateTime timestamp = DateTime.Now;
                AppendLineTimestamp(mainFilePath, timestamp, keyboardCounterTemp, mouseCounterTemp);
                keyboardCounterTemp = 0;
                mouseCounterTemp = 0;
                
            }
        }
        void VisibleReset()
        {
            startTime = DateTime.Now;
            toolStripStatusLabel1.Text = "Starttidspunkt: " + startTime.ToString("d. MMMM yyyy, klokken HH:mm");
            keyboardCounter = 0;
            mouseCounter = 0;
            txtKeyboard.Text = keyboardCounter.ToString();
            txtMouse.Text = mouseCounter.ToString();
            ShowSum();
        }
        private void btnLogging_Click(object sender, EventArgs e)
        {
            if (logfileExists)  //Resetknapp
            {
                CompleteSave();
                VisibleReset();
            }
            else    //startknapp
            {
                StartLogging();
                ShowLogState();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Lagre ny linje, med datoen "today".
            VisibleReset();
            
            AppendLineTimestamp(mainFilePath, today, keyboardCounterTemp, mouseCounterTemp);
            keyboardCounterTemp = 0;
            mouseCounterTemp = 0;
            VisibleReset();
            timer1.Enabled = false;
            ActivateTimer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void AppendLineTimestamp(string filepath, DateTime timestamp, int value1, int value2)
        {
            if (value1 + value2 > 2)
            {
                if (!File.Exists(mainFilePath))
                {
                    StreamWriter bw = new StreamWriter(File.Create(mainFilePath));
                    //bw.WriteLine("Enabled");
                    bw.WriteLine("Date,Keyboard,Mouse");
                    bw.Close();
                    bw.Dispose();
                }
                string csvLine = timestamp.ToString(customDatetimeFormat) + "," + value1.ToString() + "," + value2.ToString();
                AppendLineToFile(filepath, csvLine);
            }
                
        }
        void AppendLineToFile(string filepath, string csvLine)
        {
            if (File.Exists(filepath))
            {
                StreamWriter bw = new StreamWriter(filepath, true);
                bw.WriteLine(csvLine);
                bw.Close();
                bw.Dispose();
            }
        }

        void CheckForFile()
        {
            if (File.Exists(mainFilePath))
            {
                //string firstline;
                //StreamReader streamReader = File.OpenText(mainFilePath);

                //firstline = streamReader.ReadLine();
                //streamReader.Close();
                //streamReader.Dispose();

                //if (firstline == "Enabled")
                //{
                StartLogging();
                //}
            }
        }
        void ShowSum()
        {
            int sum = mouseCounter + keyboardCounter;
            txtSum.Text = sum.ToString();
        }
    }
}
