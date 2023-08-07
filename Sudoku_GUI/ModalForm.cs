using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_GUI
{
    public partial class ModalForm : Form
    {
        private FormPrincipal formPrincipalIns; // Propiedad para guardar la referencia al Form1

        public ModalForm(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            formPrincipalIns = formPrincipal; // Guardar la referencia del Form1 cuando se instancia Form2
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
            else
            {
                Opacity += .03;
            }

            int y = FormPrincipal.parentY += 3;
            this.Location = new Point(FormPrincipal.parentX + 220, y);

            if (y >= i)
            {
                modalEffect_Timer.Stop();
            }
        }
        
        int i;
        private void ModalForm_Load(object sender, EventArgs e)
        {
            i = FormPrincipal.parentY + 150;

            this.Location = new Point(FormPrincipal.parentX + 220, FormPrincipal.parentY + 150);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbFacil_MouseEnter(object sender, EventArgs e)
        {
            this.lbFacil.ForeColor = SystemColors.MenuHighlight;
        }

        private void lbFacil_MouseLeave(object sender, EventArgs e)
        {
            this.lbFacil.ForeColor = SystemColors.ButtonShadow;
        }

        private void lbMedio_MouseEnter(object sender, EventArgs e)
        {
            this.lbMedio.ForeColor = SystemColors.MenuHighlight;
        }

        private void lbMedio_MouseLeave(object sender, EventArgs e)
        {
            this.lbMedio.ForeColor = SystemColors.ButtonShadow;
        }

        private void lbDificil_MouseEnter(object sender, EventArgs e)
        {
            this.lbDificil.ForeColor = SystemColors.MenuHighlight;
        }

        private void lbDificil_MouseLeave(object sender, EventArgs e)
        {
            this.lbDificil.ForeColor = SystemColors.ButtonShadow;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbBlanco_MouseEnter(object sender, EventArgs e)
        {
            this.lbBlanco.ForeColor = Color.Red;
        }

        private void lbBlanco_MouseLeave(object sender, EventArgs e)
        {
            this.lbBlanco.ForeColor = Color.OrangeRed;
        }

        private void lbFacil_Click(object sender, EventArgs e)
        {
            formPrincipalIns.startNewGame(3);
            this.Close();
        }

        private void lbMedio_Click(object sender, EventArgs e)
        {
            formPrincipalIns.startNewGame(2);
            this.Close();
        }

        private void lbDificil_Click(object sender, EventArgs e)
        {
            formPrincipalIns.startNewGame(1);
            this.Close();
        }

        private void lbBlanco_Click(object sender, EventArgs e)
        {
            formPrincipalIns.startNewGame(0);
            this.Close();
        }
    }
}
