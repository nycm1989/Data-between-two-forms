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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Right position
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width/2) - this.Width - 10, (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2));
            
            //Open second form
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Form2))
                {
                    foreach (Control control in frm.Controls)
                    {
                        if (control is TextBox && control.Name == "textSample2")
                        {
                            ((TextBox)control).Text = textSample1.Text;
                            textSample1.Text = "";
                            break;
                        }
                    }
                }
            }

        }
    }
}
