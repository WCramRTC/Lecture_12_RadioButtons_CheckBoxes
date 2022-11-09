using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_12_RadioButtons_CheckBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        #region ExampleCode
        private void btnEnroll_Click(object sender, EventArgs e)
        {
            rtbEnroll.Text = "";
            string name = tbName.Text;


            // Check check boxes for classes selected
            string classes = "Classes:\n";

            if (chkWeb.Checked) classes += "Web Developement\n";

            if (chkGame.Checked) classes += "Game Development\n";

            if (chkDatabase.Checked) classes += "Database\n";

            if (chkProg.Checked) classes += "Programming\n";

            // Check radio buttons for quarter selected
            string quarter = "Quarter: ";

            if(rbFall.Checked)
            {
                quarter += "Fall";
            }
            else if (rbWinter.Checked) {
                quarter += "Winter";
            }
            else if (rbSpring.Checked)
            {
                quarter += "Spring";
            }
            else
            {
                quarter += "Summer";

            }

            string enroll = $"" +
                $"Student: {name}\n\n" +
                $"{quarter}\n\n" +
                $"{classes}";

            rtbEnroll.Text = enroll;

        }
        #endregion ExampleCode
    }
}
