using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_WF_Vasilchenko
{
    public partial class HW1_WF : Form
    {
        public HW1_WF()
        {
            InitializeComponent();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
           MazeForm1 mazeForm = new MazeForm1();
            mazeForm.Show();
            //Application.Run(new WF_Sandbox.Form1());
        }

        private void buttonTask2_1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = Messages.ShowPart1();
        }

        private void buttonTask2_2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = Messages.ShowPart2();
        }
    }
}
