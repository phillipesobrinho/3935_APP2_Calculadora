using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3935_APP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_resultado.Text = (Convert.ToInt32(txt_1.Text) + 
                Convert.ToInt32(txt_2.Text)).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro. Deve inserir um número",
                    "Calculadora",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txt_1.ResetText();
                txt_2.ResetText();
            }

        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_resultado.Text = (Convert.ToInt32(txt_1.Text) -
                Convert.ToInt32(txt_2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Deve inserir um número",
                    "Calculadora", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txt_1.ResetText();
                txt_2.ResetText();
            }
        }

        private void btn_vezes_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_resultado.Text = (Convert.ToInt32(txt_1.Text) *
                Convert.ToInt32(txt_2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Deve inserir um número",
                    "Calculadora", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txt_1.ResetText();
                txt_2.ResetText();
            }
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_resultado.Text = (Convert.ToInt32(txt_1.Text) /
                Convert.ToInt32(txt_2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Deve inserir um número",
                    "Calculadora", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txt_1.ResetText();
                txt_2.ResetText();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_1.ResetText();
            txt_2.ResetText();
            lbl_resultado.ResetText();
        }

        private void txt_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
