using System;
using System.Windows.Forms;
using System.Threading;

namespace Engine
{
    public class Program
    {
        public static Form1 form = new Form1();
        public static bool quitting = false;
        [STAThread]
        static void Main(string[] args)
        {
            form.SuspendLayout();
            form.FormLayout();
            form.ResumeLayout(false);
            form.PerformLayout();
            Application.Run(form);
        }
    }
}