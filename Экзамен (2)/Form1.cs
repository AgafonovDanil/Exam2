using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен__2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRashet_Click(object sender, EventArgs e)
        {
            double dlit = Convert.ToInt32(textDlit.Text);
            double cena = 10;
            string rashet = "Ваш разговор длился " + dlit + " минут, Вы говорили в " + comboNedel.SelectedItem + " день недели. Стоимость разговора " + dlit*cena  + " руб.";
            string rashetVihod = "Ваш разговор длился " + dlit + " минут, Вы говорили в " + comboNedel.SelectedItem + " день недели. Стоимость разговора " + dlit* cena*0.8   +" руб.";
             if (comboNedel.SelectedIndex==0)
             {
                labelItog.Text = rashet.ToString();
             }
             if (comboNedel.SelectedIndex == 1)
             {
                labelItog.Text = rashet.ToString();
            }
             if (comboNedel.SelectedIndex == 2)
             {
                labelItog.Text = rashet.ToString();
            }
             if (comboNedel.SelectedIndex == 3)
             {
                labelItog.Text = rashet.ToString();
            }
             if (comboNedel.SelectedIndex == 4)
             {
                labelItog.Text = rashet.ToString();
            }
             if (comboNedel.SelectedIndex == 5)
             {
                labelItog.Text = rashetVihod.ToString();
            }
             if (comboNedel.SelectedIndex == 6)
             {
                labelItog.Text = rashetVihod.ToString();
             }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textDlit.Text = "";
            comboNedel.SelectedIndex = -1;
            labelItog.Text = "";
        }

        private void textDlit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <=47 || number >= 58) && number !=8 && number !=44)
            {
                e.Handled = true;
            }
        }

        private void textDlit_TextChanged(object sender, EventArgs e)
        {
            if (textDlit.Text != "")
            {
                btnRashet.Enabled = true;
            }
        }
    }
}
