using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_WF_Vasilchenko
{
    internal class Messages
    {
        public static DialogResult ShowPart1()
        {
            string _message = "Text message";
            string _caption = "Message caption";
            DialogResult result = MessageBox.Show(_message, _caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            result = MessageBox.Show(_message, _caption, MessageBoxButtons.YesNo);

            result = MessageBox.Show(_message);

            return result;
        }


        public static DialogResult ShowPart2()
        {
            string _message = "Message from Developer!";

            DialogResult result = MessageBox.Show(_message);

            result = MessageBox.Show(_message, "That's a caption");

            result = MessageBox.Show(_message, "Choice", MessageBoxButtons.YesNoCancel);
            string _button = result.ToString();

            result = MessageBox.Show("You've chosen " + _button + "!");

            return result;
        }

        public static DialogResult ShowExitConfirmation()
        {
            string _message = "Are you sure, you want to exit?";
            string _caption = "Exit";
            DialogResult result = MessageBox.Show(_message, _caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

            return result;
        }

        public static DialogResult ShowCompletion(string _msg)
        {
            string _caption = "Congratulation!";
            DialogResult result = MessageBox.Show(_msg, _caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

    }
}
