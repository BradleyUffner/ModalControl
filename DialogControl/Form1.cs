using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnShowDialogControl_Click(object sender, EventArgs e)
        {
            var control = new DialogControl();
            splitContainer1.Panel2.Controls.Add(control);

            if (await control.ShowModalAsync() == DialogResult.OK)
            {
                MessageBox.Show($"Username: {control.UserName}");
            }

            splitContainer1.Panel2.Controls.Remove(control);
        }
    }
}
