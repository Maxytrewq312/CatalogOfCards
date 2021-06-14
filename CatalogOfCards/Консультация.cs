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
    public partial class Консультация : Form
    {
        public Консультация()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxPhoneoremail.Text == "" || textBoxSurname.Text == "")
            {
                MessageBox.Show("Проверьте значения полей для ввода", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ActiveForm.Hide();
                Form thnx = new ThankYou();
                thnx.Show();
            }
        }
    }
}
