using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace L12_Task03
{
    public partial class Form1 : Form
    {
        public event EventHandler StartStopButtonEvent = null;
        public event EventHandler ResetButtonEvent = null;

        public DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100); //Интервал в 0.1 секунды     1_000_000
        }


        #region Обработчики
        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (StartStopButtonEvent != null)
                StartStopButtonEvent.Invoke(sender, e);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (ResetButtonEvent != null)
                ResetButtonEvent.Invoke(sender, e);
        }
        #endregion

    }
}
