namespace Sudoku_GUI
{
    partial class ModalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.lbFacil = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMedio = new System.Windows.Forms.Label();
            this.lbDificil = new System.Windows.Forms.Label();
            this.lbBlanco = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCancel = new System.Windows.Forms.Label();
            this.lbElegirDificultad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Enabled = true;
            this.modalEffect_Timer.Interval = 1;
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // lbFacil
            // 
            this.lbFacil.AutoSize = true;
            this.lbFacil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacil.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbFacil.Location = new System.Drawing.Point(39, 145);
            this.lbFacil.Name = "lbFacil";
            this.lbFacil.Size = new System.Drawing.Size(80, 32);
            this.lbFacil.TabIndex = 2;
            this.lbFacil.Text = "Fácil";
            this.lbFacil.Click += new System.EventHandler(this.lbFacil_Click);
            this.lbFacil.MouseEnter += new System.EventHandler(this.lbFacil_MouseEnter);
            this.lbFacil.MouseLeave += new System.EventHandler(this.lbFacil_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hotel De Paris", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(88, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo Juego";
            // 
            // lbMedio
            // 
            this.lbMedio.AutoSize = true;
            this.lbMedio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedio.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbMedio.Location = new System.Drawing.Point(178, 145);
            this.lbMedio.Name = "lbMedio";
            this.lbMedio.Size = new System.Drawing.Size(97, 32);
            this.lbMedio.TabIndex = 4;
            this.lbMedio.Text = "Medio";
            this.lbMedio.Click += new System.EventHandler(this.lbMedio_Click);
            this.lbMedio.MouseEnter += new System.EventHandler(this.lbMedio_MouseEnter);
            this.lbMedio.MouseLeave += new System.EventHandler(this.lbMedio_MouseLeave);
            // 
            // lbDificil
            // 
            this.lbDificil.AutoSize = true;
            this.lbDificil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDificil.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbDificil.Location = new System.Drawing.Point(342, 145);
            this.lbDificil.Name = "lbDificil";
            this.lbDificil.Size = new System.Drawing.Size(91, 32);
            this.lbDificil.TabIndex = 5;
            this.lbDificil.Text = "Difícil";
            this.lbDificil.Click += new System.EventHandler(this.lbDificil_Click);
            this.lbDificil.MouseEnter += new System.EventHandler(this.lbDificil_MouseEnter);
            this.lbDificil.MouseLeave += new System.EventHandler(this.lbDificil_MouseLeave);
            // 
            // lbBlanco
            // 
            this.lbBlanco.AutoSize = true;
            this.lbBlanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBlanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlanco.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbBlanco.Location = new System.Drawing.Point(150, 209);
            this.lbBlanco.Name = "lbBlanco";
            this.lbBlanco.Size = new System.Drawing.Size(153, 32);
            this.lbBlanco.TabIndex = 6;
            this.lbBlanco.Text = "En Blanco";
            this.lbBlanco.Click += new System.EventHandler(this.lbBlanco_Click);
            this.lbBlanco.MouseEnter += new System.EventHandler(this.lbBlanco_MouseEnter);
            this.lbBlanco.MouseLeave += new System.EventHandler(this.lbBlanco_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lbCancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 52);
            this.panel1.TabIndex = 7;
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCancel.Location = new System.Drawing.Point(430, 0);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(34, 32);
            this.lbCancel.TabIndex = 8;
            this.lbCancel.Text = "X";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // lbElegirDificultad
            // 
            this.lbElegirDificultad.AutoSize = true;
            this.lbElegirDificultad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbElegirDificultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbElegirDificultad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbElegirDificultad.Location = new System.Drawing.Point(101, 83);
            this.lbElegirDificultad.Name = "lbElegirDificultad";
            this.lbElegirDificultad.Size = new System.Drawing.Size(248, 32);
            this.lbElegirDificultad.TabIndex = 8;
            this.lbElegirDificultad.Text = "Elija su dificultad";
            // 
            // ModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(462, 271);
            this.Controls.Add(this.lbElegirDificultad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbBlanco);
            this.Controls.Add(this.lbDificil);
            this.Controls.Add(this.lbMedio);
            this.Controls.Add(this.lbFacil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalForm";
            this.Opacity = 0D;
            this.Text = "ModalForm";
            this.Load += new System.EventHandler(this.ModalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer modalEffect_Timer;
        private System.Windows.Forms.Label lbFacil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMedio;
        private System.Windows.Forms.Label lbDificil;
        private System.Windows.Forms.Label lbBlanco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.Label lbElegirDificultad;
    }
}