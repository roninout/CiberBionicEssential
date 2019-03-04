using System;

// Presenter

namespace L12_TaskAdd01
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            //this.mainWindow.myEvent += new EventHandler(mainWindow_myEvent);
            this.mainWindow.MyEvent += new EventHandler(mainWindow_myEvent); /* и тут подправил */
        }

        void mainWindow_myEvent(object sender, System.EventArgs e)
        {
            string variable = model.Logic(this.mainWindow.textBox1.Text);

            this.mainWindow.textBox1.Text = variable;
        }
    }
}
