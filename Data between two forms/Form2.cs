using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_between_two_forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Left position
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) + 10, (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Form1))
                {
                    foreach (Control control in frm.Controls)
                    {
                        if (control is TextBox && control.Name == "textSample1")
                        {
                            ((TextBox)control).Text = textSample2.Text;
                            textSample2.Text = "";
                            break;
                        }
                    }
                }
            }
        }
    }
}
