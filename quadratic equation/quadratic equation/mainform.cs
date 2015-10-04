using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quadratic_equation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnsolve_Click(object sender, EventArgs e)
        {
            double a, b, c;

            int n;

            List <double> roots = new List <double> ();

            tbdesk.Clear();
            tbsolution.Clear();

            if (tba.Text == "" || tbb.Text == "" || tbc.Text == "")
            {
                MessageBox.Show("Тут что-то введено не правильно!", "Ошибка! =( ");
            }
            else
            {
                try
                {
                    a = Convert.ToDouble(tba.Text);
                    b = Convert.ToDouble(tbb.Text);
                    c = Convert.ToDouble(tbc.Text);

                    qe_solution qe = new qe_solution(a, b, c);

                    tbdesk.Text = Convert.ToString(qe.GetDesk());

                    roots = qe.solve();
                    n = roots.Count;

                    if (n == 2)
                    {
                        tbsolution.AppendText(Convert.ToString(roots[0]));
                        tbsolution.AppendText(Convert.ToString(roots[1]));
                    }
                    else if (n == 1)
                    {
                        tbsolution.AppendText(Convert.ToString(roots[0]));
                    }
                    else
                    {
                        tbsolution.AppendText("Уравнение корней не имеет!");
                    } 
                }
                catch
                {
                    MessageBox.Show("Скорее всего вы ввели вместо цифр буквы или что-то еще!", "Ошибка! =( ");
                }

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tba.Text = "";
            tbb.Text = "";
            tbc.Text = "";

            tbdesk.Text = "";
            tbsolution.Text = "";
        }
    }
}
