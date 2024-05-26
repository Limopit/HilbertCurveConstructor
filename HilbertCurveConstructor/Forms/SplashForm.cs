using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace HilbertCurveConstructor.Forms
{
    public partial class SplashForm : Form
    {
        LoadingForm LF;
        public SplashForm()
        {
            InitializeComponent();
            InitializeTimer();
        }
        
        private void InitializeTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 30 * 1000; // Таймер на 30 секунд
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e) { Close();}
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread loadingThread = new Thread(Loading); // Выделение отдельного потока под форму загрузки
            loadingThread.Start();
            Program.context.MainForm = new MainForm();
            Thread.Sleep(200);
            Close();
            Program.context.MainForm.Show();
        }

        private void Loading()
        {
            LF = new LoadingForm();
        }
    }
}