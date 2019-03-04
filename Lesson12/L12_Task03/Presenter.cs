using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_Task03
{
    class Presenter
    {
        private  Model model; // Model
        private  Form1 view;  // View
        public bool stopORstart = false; // флаг состояния кнопки start/stop

        public Presenter(Form1 view)
        {
            this.view = view;
            model = new Model();

            // подписываемся на события
            view.StartStopButtonEvent += ViewStartStopButtonEvent; // start/ stop
            view.ResetButtonEvent += ViewResetButtonEvent; // reset
            view.dispatcherTimer.Tick += ViewTimerTickEvent;   //Tick
        }

        private void ShowTime()
        {
            view.Label_Minutes.Text = model.Minutes.ToString();
            view.Label_Seconds.Text = model.Seconds.ToString();
            view.Label_Millis.Text = model.Millis.ToString();
        }

        // отображение текста кнопки Старт.Стоп
        private void ShowTextStarStopButton()
        {
            if (stopORstart)
            {
                stopORstart = false;
                view.buttonStartStop.Text = "Start";
            }
            else
            {
                stopORstart = true;
                view.buttonStartStop.Text = "Stop";
            }
        }


    #region Обработчики событий
    // сбытие tick
    private void ViewTimerTickEvent(object sender, EventArgs e)
        {
            model.Calculate();
            model.Ticks++;
            ShowTime();
        }

        // событие кнопки сброс
        private void ViewResetButtonEvent(object sender, EventArgs e)
        {
            view.dispatcherTimer.Stop();
            model.Millis = 0;
            model.Seconds = 0;
            model.Minutes = 0;
            model.Ticks = 0;
            ShowTime();
            ShowTextStarStopButton();
        }

        // событие кнопки старт/стоп
        private void ViewStartStopButtonEvent(object sender, EventArgs e)
        {
            if (stopORstart)
            {
                view.dispatcherTimer.Stop();
                ShowTextStarStopButton();
            }
            else
            {
                view.dispatcherTimer.Start();
                ShowTextStarStopButton();
            }
        }
        #endregion
    }
}
