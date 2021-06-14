using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogOfCards
{
    public partial class Каталог : Form
    {
        public Каталог()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Имя пациента")
                textBox1.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Фамилия пациента")
                textBox2.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Диагнозы пациента")
                textBox3.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Имя пациента";
            }
                
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Фамилия пациента";
            }
                
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Диагнозы пациента";
            }
                
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Имя пациента")
                textBox1.Text = "";
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Имя пациента")
                textBox6.Text = "";
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Диагнозы пациента")
                textBox7.Text = "";
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Фамилия пациента")
                textBox8.Text = "";
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Имя пациента")
                textBox9.Text = "";
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Фамилия пациента")
                textBox5.Text = "";
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Диагнозы пациента")
                textBox4.Text = "";
        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
            if (textBox12.Text == "Имя пациента")
                textBox12.Text = "";
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            if (textBox11.Text == "Фамилия пациента")
                textBox11.Text = "";
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Диагнозы пациента")
                textBox10.Text = "";
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Диагнозы пациента";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Фамилия пациента";
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Имя пациента";
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Диагнозы пациента";
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Фамилия пациента";
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Имя пациента";
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "Диагнозы пациента";
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "Фамилия пациента";
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                textBox12.Text = "Имя пациента";
            }
        }

        private void BtnCard1_Click(object sender, EventArgs e)
        {
            try
            {
                Pacients pac = new Pacients();
                pac.NamePac = textBox1.Text;
                pac.SurnamePac = textBox2.Text;
                pac.DiagPac = textBox3.Text;
                Program.cd.Pacients.Add(pac);
                Program.cd.SaveChanges();
                MessageBox.Show("Данные успешно загружены!", "Отлично!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Данные не были успешно загружены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCard2_Click(object sender, EventArgs e)
        {
            try
            {
                Pacients pac = new Pacients();
                pac.NamePac = textBox6.Text;
                pac.SurnamePac = textBox5.Text;
                pac.DiagPac = textBox4.Text;
                Program.cd.Pacients.Add(pac);
                Program.cd.SaveChanges();
                MessageBox.Show("Данные успешно загружены!", "Отлично!");
            }
            catch
            {
                MessageBox.Show("Данные не были успешно загружены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnCard3_Click(object sender, EventArgs e)
        {
            try
            {
                Pacients pac = new Pacients();
                pac.NamePac = textBox9.Text;
                pac.SurnamePac = textBox8.Text;
                pac.DiagPac = textBox7.Text;
                Program.cd.Pacients.Add(pac);
                Program.cd.SaveChanges();
                MessageBox.Show("Данные успешно загружены!", "Отлично!");
            }
            catch
            {
                MessageBox.Show("Данные не были успешно загружены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnCard4_Click(object sender, EventArgs e)
        {
            try
            {
                Pacients pac = new Pacients();
                pac.NamePac = textBox12.Text;
                pac.SurnamePac = textBox11.Text;
                pac.DiagPac = textBox10.Text;
                Program.cd.Pacients.Add(pac);
                Program.cd.SaveChanges();
                MessageBox.Show("Данные успешно загружены!", "Отлично!");
            }
            catch
            {
                MessageBox.Show("Данные не были успешно загружены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnIzm1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnIzm2_Click(object sender, EventArgs e)
        {

        }

        private void BtnIzm3_Click(object sender, EventArgs e)
        {

        }

        private void BtnIzm4_Click(object sender, EventArgs e)
        {

        }
    }
}
