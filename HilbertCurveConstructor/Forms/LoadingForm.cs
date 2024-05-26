using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace HilbertCurveConstructor.Forms
{
    public partial class LoadingForm : Form
    {
        private Timer timer = new Timer();
        public LoadingForm()
        {
            InitializeComponent();
            timer.Interval = 100;
            progressBar1.Step = 5;
            Show();
            Loading();
            Hide();
        }

        private void Loading()
        {
            while (!MainForm.isLoaded)
            {
                Thread.Sleep(700);
                progressBar1.PerformStep();
            }

            if (MainForm.isLoaded)
            {
                progressBar1.Step = progressBar1.Maximum - progressBar1.Value;
                progressBar1.PerformStep();
            }
        }
    }
}