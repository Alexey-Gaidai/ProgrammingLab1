using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void reshenie(double m, double p, double r)
        {
            label5.Text = "";
            double otvet;
            otvet = Math.Round((m / p) / (Math.PI * (r * r)),3);
            string otv = Convert.ToString(otvet);
            otvetlabel.Text = otv;
            massatextbox.Text = "";
            plotnosttextbox.Text = "";
            radiustextbox.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m, p, r;
            if (massatextbox.Text == "" || plotnosttextbox.Text == "" || radiustextbox.Text == "")
                label5.Text = "Введите значения!";
            else
            {
                m = Convert.ToDouble(massatextbox.Text);
                p = Convert.ToDouble(plotnosttextbox.Text);
                r = Convert.ToDouble(radiustextbox.Text);
                reshenie(m, p, r);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            massatextbox.Text = "";
            plotnosttextbox.Text = "";
            radiustextbox.Text = "";
        }
    }
}
