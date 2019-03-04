using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L12_Task04
{
    public partial class Form1 : Form
    {
        public string argsTextButtons = null; // будет содержать такст от кнопок
        public Form1()
        {
            InitializeComponent();
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            argsTextButtons = clickedButton.Text;
            //MessageBox.Show(argsTextButtons);
        }
    }
}
