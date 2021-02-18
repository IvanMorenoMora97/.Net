using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormulario
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Registro register = new Registro();
            //Ocultamos el formulario de login.
            this.Hide();
            //Abrimos el formulario de registro y detenemos las instrucciones futuras.
            register.ShowDialog();
            //Una vez acabado el "ShowDialog" volvemos a mostrar el formulario principal (Login).
            this.Visible = true;

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            ModosJuegos mJuegos = new ModosJuegos();
            //Ocultamos el formulario de login.
            this.Hide();
            //Abrimos la pantalla de los modos de juego.
            mJuegos.ShowDialog();
            //Una vez acabado el "ShadowDialog" volvemos a mostrar el formulario principal (Login).
            this.Visible = true;

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
