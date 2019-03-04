using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_Task04
{
    class Presenter
    {
        private Model model; // Model
        private Form1 view;  // View

        public Presenter(Form1 view)
        {
            this.view = view;
            model = new Model();


        }
    }
}
