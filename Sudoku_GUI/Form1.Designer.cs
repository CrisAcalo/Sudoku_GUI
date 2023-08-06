namespace Sudoku_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTableroContenedor = new System.Windows.Forms.Panel();
            this.label_principal = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnResolver = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btn_num9 = new System.Windows.Forms.Button();
            this.btn_num6 = new System.Windows.Forms.Button();
            this.btn_num3 = new System.Windows.Forms.Button();
            this.btn_num8 = new System.Windows.Forms.Button();
            this.btn_num5 = new System.Windows.Forms.Button();
            this.btn_num2 = new System.Windows.Forms.Button();
            this.btn_num7 = new System.Windows.Forms.Button();
            this.btn_num4 = new System.Windows.Forms.Button();
            this.btn_num1 = new System.Windows.Forms.Button();
            this.label_coory = new System.Windows.Forms.Label();
            this.label_coorx = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTableroContenedor
            // 
            this.pnlTableroContenedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTableroContenedor.Location = new System.Drawing.Point(11, 114);
            this.pnlTableroContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTableroContenedor.Name = "pnlTableroContenedor";
            this.pnlTableroContenedor.Size = new System.Drawing.Size(450, 450);
            this.pnlTableroContenedor.TabIndex = 0;
            // 
            // label_principal
            // 
            this.label_principal.AutoSize = true;
            this.label_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_principal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_principal.Location = new System.Drawing.Point(125, 64);
            this.label_principal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_principal.Name = "label_principal";
            this.label_principal.Size = new System.Drawing.Size(137, 31);
            this.label_principal.TabIndex = 1;
            this.label_principal.Text = "SUDOKU";
            this.label_principal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_principal.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelContenedor.Controls.Add(this.btnComprobar);
            this.panelContenedor.Controls.Add(this.btnResolver);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Controls.Add(this.btn_num9);
            this.panelContenedor.Controls.Add(this.btn_num6);
            this.panelContenedor.Controls.Add(this.btn_num3);
            this.panelContenedor.Controls.Add(this.btn_num8);
            this.panelContenedor.Controls.Add(this.btn_num5);
            this.panelContenedor.Controls.Add(this.btn_num2);
            this.panelContenedor.Controls.Add(this.btn_num7);
            this.panelContenedor.Controls.Add(this.btn_num4);
            this.panelContenedor.Controls.Add(this.btn_num1);
            this.panelContenedor.Controls.Add(this.label_coory);
            this.panelContenedor.Controls.Add(this.label_coorx);
            this.panelContenedor.Controls.Add(this.label_principal);
            this.panelContenedor.Controls.Add(this.pnlTableroContenedor);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 579);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // btnResolver
            // 
            this.btnResolver.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolver.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResolver.Location = new System.Drawing.Point(484, 518);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(304, 46);
            this.btnResolver.TabIndex = 14;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.MouseEnter += new System.EventHandler(this.btnResolver_MouseEnter);
            this.btnResolver.MouseLeave += new System.EventHandler(this.btnResolver_MouseLeave);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(800, 29);
            this.panelBarraTitulo.TabIndex = 13;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Sudoku_GUI.Properties.Resources.minimizar_2_16;
            this.btnMaximizar.Location = new System.Drawing.Point(747, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(16, 16);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Sudoku_GUI.Properties.Resources.menos_2_16;
            this.btnMinimizar.Location = new System.Drawing.Point(713, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::Sudoku_GUI.Properties.Resources.minimizar_2_16;
            this.btnRestaurar.Location = new System.Drawing.Point(747, 5);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(16, 16);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Sudoku_GUI.Properties.Resources.close1;
            this.btnCerrar.Location = new System.Drawing.Point(777, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btn_num9
            // 
            this.btn_num9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_num9.Location = new System.Drawing.Point(688, 433);
            this.btn_num9.Margin = new System.Windows.Forms.Padding(1);
            this.btn_num9.Name = "btn_num9";
            this.btn_num9.Size = new System.Drawing.Size(100, 70);
            this.btn_num9.TabIndex = 12;
            this.btn_num9.Text = "9";
            this.btn_num9.UseVisualStyleBackColor = false;
            this.btn_num9.Click += new System.EventHandler(this.btn_num9_Click);
            // 
            // btn_num6
            // 
            this.btn_num6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_num6.Location = new System.Drawing.Point(688, 361);
            this.btn_num6.Margin = new System.Windows.Forms.Padding(1);
            this.btn_num6.Name = "btn_num6";
            this.btn_num6.Size = new System.Drawing.Size(100, 70);
            this.btn_num6.TabIndex = 11;
            this.btn_num6.Text = "6";
            this.btn_num6.UseVisualStyleBackColor = false;
            this.btn_num6.Click += new System.EventHandler(this.btn_num6_Click);
            // 
            // btn_num3
            // 
            this.btn_num3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_num3.Location = new System.Drawing.Point(688, 289);
            this.btn_num3.Margin = new System.Windows.Forms.Padding(1);
            this.btn_num3.Name = "btn_num3";
            this.btn_num3.Size = new System.Drawing.Size(100, 70);
            this.btn_num3.TabIndex = 10;
            this.btn_num3.Text = "3";
            this.btn_num3.UseVisualStyleBackColor = false;
            this.btn_num3.Click += new System.EventHandler(this.btn_num3_Click);
            // 
            // btn_num8
            // 
            this.btn_num8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_num8.Location = new System.Drawing.Point(586, 433);
            this.btn_num8.Margin = new System.Windows.Forms.Padding(1);
            this.btn_num8.Name = "btn_num8";
            this.btn_num8.Size = new System.Drawing.Size(100, 70);
            this.btn_num8.TabIndex = 9;
            this.btn_num8.Text = "8";
            this.btn_num8.UseVisualStyleBackColor = false;
            this.btn_num8.Click += new System.EventHandler(this.btn_num8_Click);
            // 
            // btn_num5
            // 
            this.btn_num5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_num5.Location = new System.Drawing.Point(586, 361);
            this.btn_num5.Margin = new System.Windows.Forms.Padding(1);
            this.btn_num5.Name = "btn_num5";
            this.btn_num5.Size = new System.Drawing.Size(100, 70);
            this.btn_num5.TabIndex = 8;
            this.btn_num5.Text = "5";
            this.btn_num5.UseVisualStyleBackColor = false;
            this.btn_num5.Click += new System.EventHandler(this.btn_num5_Click);
            // 
            // btn_num2
            // 
            this.btn_num2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_num2.Location = new System.Drawing.Point(586, 289);
            this.btn_num2.Margin = new System.Windows.Forms.Padding(1);
            this.btn_num2.Name = "btn_num2";
            this.btn_num2.Size = new System.Drawing.Size(100, 70);
            this.btn_num2.TabIndex = 7;
            this.btn_num2.Text = "2";
            this.btn_num2.UseVisualStyleBackColor = false;
            this.btn_num2.Click += new System.EventHandler(this.btn_num2_Click);
            // 
            // btn_num7
            // 
            this.btn_num7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_num7.Location = new System.Drawing.Point(484, 433);
            this.btn_num7.Margin = new System.Windows.Forms.Padding(1);
            this.btn_num7.Name = "btn_num7";
            this.btn_num7.Size = new System.Drawing.Size(100, 70);
            this.btn_num7.TabIndex = 6;
            this.btn_num7.Text = "7";
            this.btn_num7.UseVisualStyleBackColor = false;
            this.btn_num7.Click += new System.EventHandler(this.btn_num7_Click);
            // 
            // btn_num4
            // 
            this.btn_num4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_num4.Location = new System.Drawing.Point(484, 361);
            this.btn_num4.Margin = new System.Windows.Forms.Padding(1);
            this.btn_num4.Name = "btn_num4";
            this.btn_num4.Size = new System.Drawing.Size(100, 70);
            this.btn_num4.TabIndex = 5;
            this.btn_num4.Text = "4";
            this.btn_num4.UseVisualStyleBackColor = false;
            this.btn_num4.Click += new System.EventHandler(this.btn_num4_Click);
            // 
            // btn_num1
            // 
            this.btn_num1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_num1.Location = new System.Drawing.Point(484, 289);
            this.btn_num1.Margin = new System.Windows.Forms.Padding(1);
            this.btn_num1.Name = "btn_num1";
            this.btn_num1.Size = new System.Drawing.Size(100, 70);
            this.btn_num1.TabIndex = 4;
            this.btn_num1.Text = "1";
            this.btn_num1.UseVisualStyleBackColor = false;
            this.btn_num1.Click += new System.EventHandler(this.btn_num1_Click);
            // 
            // label_coory
            // 
            this.label_coory.AutoSize = true;
            this.label_coory.Location = new System.Drawing.Point(544, 128);
            this.label_coory.Name = "label_coory";
            this.label_coory.Size = new System.Drawing.Size(16, 13);
            this.label_coory.TabIndex = 3;
            this.label_coory.Text = "...";
            // 
            // label_coorx
            // 
            this.label_coorx.AutoSize = true;
            this.label_coorx.Location = new System.Drawing.Point(544, 97);
            this.label_coorx.Name = "label_coorx";
            this.label_coorx.Size = new System.Drawing.Size(16, 13);
            this.label_coorx.TabIndex = 2;
            this.label_coorx.Text = "...";
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnComprobar.Location = new System.Drawing.Point(484, 225);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(304, 46);
            this.btnComprobar.TabIndex = 15;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTableroContenedor;
        private System.Windows.Forms.Label label_principal;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label_coory;
        private System.Windows.Forms.Label label_coorx;
        private System.Windows.Forms.Button btn_num1;
        private System.Windows.Forms.Button btn_num9;
        private System.Windows.Forms.Button btn_num6;
        private System.Windows.Forms.Button btn_num3;
        private System.Windows.Forms.Button btn_num8;
        private System.Windows.Forms.Button btn_num5;
        private System.Windows.Forms.Button btn_num2;
        private System.Windows.Forms.Button btn_num7;
        private System.Windows.Forms.Button btn_num4;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Button btnComprobar;
    }
}

