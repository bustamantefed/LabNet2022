using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseTresExtensionMethodsExceptionsUnittest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_ExceptionZero.Enabled = false;
            Btn_Division.Enabled = false;
            Btn_ExcepcionTwo.Enabled = false;
            Btn_Excepcion.Enabled = false;
        }
        private void Btn_ExceptionZero_Click(object sender, EventArgs e)
        {
            DivisionZero();
        }

        private void Btn_Division_Click(object sender, EventArgs e)
        {
            DivisionTwoNumbers();
        }

        private void DivisionZero()
        {
            try
            {
                int result;
                result = Convert.ToInt32(Txt_Insert.Text) / 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Parece que algo anda mal.\nUsted no puede dividir por cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Insert.Text = "";
            }
            finally
            {
                MessageBox.Show("Se ejecuta a la perfección la exception + finally.");
            }
        }

        public void DivisionTwoNumbers()
        {
            try
            {
                double result;
                if (Txt_Insert3.Text == "" || Txt_Insert2.Text == "")
                {
                    throw new DivisionTwoNumbersCancelException("No ingrese campos vacios, no ingreso nada!");
                }
                else
                {
                    result = (Convert.ToInt32(Txt_Insert3.Text) / Convert.ToInt32(Txt_Insert2.Text));
                    MessageBox.Show("Su resultado es:\n" + result, "Resultado división ingresando dividendo y divisor", MessageBoxButtons.OK);
                    Txt_Insert2.Text = "";
                    Txt_Insert3.Text = "";
                }
            }
            catch (DivisionTwoNumbersCancelException dEx)
            {
                MessageBox.Show(dEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Usted no puede dividir por cero.\nSolo Chuck Norris divide por cero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Btn_ExcepcionTwo_Click(object sender, EventArgs e)
        {
            try
            {
                Logic LogicExceptionChuckNorris = new Logic();
                LogicExceptionChuckNorris.LogicDivisionTwo(Convert.ToInt32(Txt_InsertNumber.Text), Convert.ToInt32(Txt_InsertNumber2.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Solo Chuck Norris es capaz de que no capte la excepción el catch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_InsertNumber.Text = "";
                Txt_InsertNumber2.Text = "";
                return;
            }                
        }

        private void Btn_Excepcion_Click(object sender, EventArgs e)
        {
            try
            {
                string msg;
                if (Txt_InsertChar.TextLength > 3 || Txt_InsertChar2.TextLength >3)
                {
                    throw new DivisionTwoNumbersCancelException("Solo Chuck Norris es capaz de ingresar más de tres caracteres en estos checkbox!");
                }
                if (Txt_InsertChar.Text == "" || Txt_InsertChar2.Text == "")
                {
                    throw new DivisionTwoNumbersCancelException("No ingrese campos vacios, no ingreso nada!\n¿Acaso se cree Chuk Norris?");
                }
                Logic LogicExceptionChuckNorris = new Logic();
                int result = LogicExceptionChuckNorris.LogicDivision(Convert.ToInt32(Txt_InsertChar.Text), Convert.ToInt32(Txt_InsertChar2.Text));
                if (result.avanAndOdd() == true)
                {
                    msg = "par";
                }
                else
                {
                    msg = "impar";
                }
                MessageBox.Show("El resultado de su división es: " +result+ " \nY es un número "+msg+".","Resultado división",MessageBoxButtons.OK);
                Txt_InsertChar.Text = "";
                Txt_InsertChar2.Text = "";
            }
            catch(DivisionTwoNumbersCancelException dEx)
            {
                MessageBox.Show(dEx.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("¿Acaso se cree Chuck Norris?.\nUsted no puede dividir por cero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;              
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Eventos del form
        private void Txt_Insert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números se permite ingresar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Txt_Insert3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números se permite ingresar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Txt_Insert2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números se permite ingresar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Txt_InsertNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números se permite ingresar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Txt_InsertNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números se permite ingresar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Txt_InsertChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números se permite ingresar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Txt_InsertChar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números se permite ingresar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Txt_Insert_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Insert.Text == "")
            {
                Btn_ExceptionZero.Enabled = false;
            }
            if (Txt_Insert.Text != "")
            {
                Btn_ExceptionZero.Enabled = true;
            }
        }
        private void Txt_Insert3_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Insert2.Text == "" && Txt_Insert3.Text == "")
            {
                Btn_Division.Enabled = false;
            }
            if (Txt_Insert2.Text != "" || Txt_Insert3.Text != "")
            {
                Btn_Division.Enabled = true;
            }
        }
        private void Txt_InsertNumber_TextChanged(object sender, EventArgs e)
        {
            if (Txt_InsertNumber.Text == "" && Txt_InsertNumber2.Text == "")
            {
                Btn_ExcepcionTwo.Enabled = false;
            }
            if (Txt_InsertNumber.Text != "" || Txt_InsertNumber2.Text != "")
            {
                Btn_ExcepcionTwo.Enabled = true;
            }
        }
        private void Txt_InsertNumber2_TextChanged(object sender, EventArgs e)
        {
            if (Txt_InsertNumber.Text == "" && Txt_InsertNumber2.Text == "")
            {
                Btn_ExcepcionTwo.Enabled = false;
            }
            if (Txt_InsertNumber.Text != "" || Txt_InsertNumber2.Text != "")
            {
                Btn_ExcepcionTwo.Enabled = true;
            }
        }
        private void Txt_InsertChar_TextChanged(object sender, EventArgs e)
        {
            if (Txt_InsertChar.Text == "" && Txt_InsertChar2.Text == "")
            {
                Btn_Excepcion.Enabled = false;
            }
            if (Txt_InsertChar.Text != "" || Txt_InsertChar2.Text != "")
            {
                Btn_Excepcion.Enabled = true;
            }
        }
        private void Txt_InsertChar2_TextChanged(object sender, EventArgs e)
        {
            if (Txt_InsertChar.Text == "" && Txt_InsertChar2.Text == "")
            {
                Btn_Excepcion.Enabled = false;
            }
            if (Txt_InsertChar.Text != "" || Txt_InsertChar2.Text != "")
            {
                Btn_Excepcion.Enabled = true;
            }
        }
    }
}
