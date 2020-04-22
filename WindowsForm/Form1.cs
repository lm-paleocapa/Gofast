using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCTO_GoFast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelSignIn.Visible = false;
            panelRecovery.Visible = false;
            panelChat.Visible = false;
        }

        private struct Utente
        {
            private string Email;
            private string User;
            private string Password;
            private int Age;
        }

        private void BtnLoginHome_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(TxtUserHome.Text) || string.IsNullOrEmpty(TxtPassHome.Text))
                {
                    labelCampiObbligatori.Visible = true;
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtUserHome.Text) || string.IsNullOrWhiteSpace(TxtPassHome.Text))
                {
                    labelCampiObbligatori.Visible = true;
                    return;
                }


            }/*controlli*/

            panelChat.Visible = true;
            panelHome.Visible = false;

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            {
                labelCampObbReg.Visible = false;
                labelEtà.Visible = false;
                labelPasDiv.Visible = false;

                if (string.IsNullOrEmpty(TxtAgeReg.Text) || string.IsNullOrEmpty(TxtConfPassReg.Text) || string.IsNullOrEmpty(TxtPassReg.Text) || string.IsNullOrEmpty(TxtUserReg.Text) || string.IsNullOrEmpty(TxtMailReg.Text))
                {
                    labelCampObbReg.Visible = true;
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtAgeReg.Text) || string.IsNullOrWhiteSpace(TxtConfPassReg.Text) || string.IsNullOrWhiteSpace(TxtPassReg.Text) || string.IsNullOrWhiteSpace(TxtUserReg.Text) || string.IsNullOrWhiteSpace(TxtMailReg.Text))
                {
                    labelCampObbReg.Visible = true;
                    return;
                }

                if(!int.TryParse(TxtAgeReg.Text, out int Age))
                {
                    labelEtà.Visible = true;
                    return;
                }

                if (int.Parse(TxtAgeReg.Text)<16)
                {
                    labelEtà.Visible = true;
                    return;
                }

                if(TxtPassReg.Text != TxtConfPassReg.Text)
                {
                    labelPasDiv.Visible = true;
                    return;
                }

            }/*controlli*/
        }

        private void BtnSignInHome_Click(object sender, EventArgs e)
        {
            panelSignIn.Visible = true;
            panelHome.Visible = false;
        }

    }
}
