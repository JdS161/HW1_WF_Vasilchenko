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
    public partial class MazeForm2 : Form
    {
        public MazeForm2()
        {
            InitializeComponent();
            MoveToStart();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Messages.ShowExitConfirmation();
        }

        private void labelFinish_Click(object sender, EventArgs e)
        {
            Messages.ShowCompletion("You've finished LEVEL2!");
            Application.Exit();
        }
        private void MoveToStart()
        {
            Point startPoint = panel1.Location;
            startPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startPoint);
        }
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = System.Windows.Forms.Cursors.SizeAll;
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
            else
                this.Cursor = System.Windows.Forms.Cursors.Default;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label73_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Messages.ShowExitConfirmation();
            }
        }
    }
}
