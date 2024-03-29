﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sudoku_GUI
{
    public partial class FormPrincipal : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private int Dimension = 9;
        private SudokuCell[,] cells;
        private SudokuCell[,] respaldo;

        public FormPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            cells = respaldo = new SudokuCell[Dimension, Dimension];
            createCells();

        }


        Random random = new Random();

        int coorx_selected = -1;
        int coory_selected = -1;
        int value_selected = -1;

        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void createCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Create 81 cells for with styles and locations based on the index
                    cells[i, j] = new SudokuCell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(50, 50);
                    cells[i, j].ForeColor = SystemColors.MenuHighlight;
                    cells[i, j].Location = new Point(i * 50, j * 50);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? Color.FromArgb(255, 255, 255) : Color.FromArgb(236, 245, 252);
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = SystemColors.ActiveCaption;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;

                    // Assign key press event for each cells
                    cells[i, j].KeyPress += cell_keyPressed;
                    cells[i, j].Click += cell_Click;

                    pnlTableroContenedor.Controls.Add(cells[i, j]);
                }
            }
        }

        public void startNewGame(int nivelDificultad)
        {
            if (nivelDificultad == 0)
            {
                cleanCells();
            }
            else
            {
                loadValues();
                removeRandomCells(nivelDificultad);
                generarRespaldo();
            }
        }
        private void removeRandomCells(int dificultad)
        {
            int numCellsToRemove = Dimension * Dimension / dificultad; // Número de celdas para eliminar

            Random rnd = new Random();
            while (numCellsToRemove > 0)
            {
                int i = rnd.Next(Dimension);
                int j = rnd.Next(Dimension);

                cells[i, j].Value = 0; // Eliminar el valor de la celda
                cells[i,j].IsLocked = false;
                cells[i, j].ForeColor = SystemColors.MenuHighlight;
                cells[i, j].Text = string.Empty; // Limpiar el texto de la celda
                numCellsToRemove--;
            }
        }

        private void cleanCells()
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    cells[i, j].Value = 0;
                    cells[i, j].IsLocked = false;
                    cells[i, j].Text = string.Empty; // Limpiar el texto de la celda
                }
            }
        }

        private void generarRespaldo()
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    respaldo[i,j].Value = cells[i, j].Value;
                }
            }
        }
        public Boolean resolver()
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    if (cells[i, j].Value != 0)
                        continue;
                    else
                    {
                        /*Calcula los elementos de la solucion para ellos revisa si es posible insertar
                         * el valor k en las coordenadas correspondientes */
                        for (int k = 1; k <= 9; k++)
                        {
                            if (esPosibleInsertar(i, j, k))
                            {
                                cells[i, j].Value = k;
                                cells[i, j].Text = k.ToString();
                                Boolean b = resolver();

                                if (b)
                                    return true;

                                cells[i, j].Value = 0;
                                cells[i, j].Clear();
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        public Boolean esPosibleInsertar(int i, int j, int valor)
        {
            for (int a = 0; a < Dimension; a++)
            {
                if (a != i && cells[a, j].Value == valor)
                    return false;
            }
            for (int a = 0; a < Dimension; a++)
            {
                if (a != j && cells[i, a].Value == valor)
                    return false;
            }
            int y = (i / 3) * 3;
            int x = (j / 3) * 3;
            for (int a = 0; a < Dimension / 3; a++)
            {
                for (int b = 0; b < Dimension / 3; b++)
                {
                    if (a != i && b != j && cells[y + a, x + b].Value == valor)
                        return false;
                }
            }
            return true;
        }

        public Boolean esPosibleInsertarInput(int i, int j, int valor)
        {
            for (int a = 0; a < Dimension; a++)
            {
                if (a != i && cells[a, j].Value == valor)
                    return false;
            }
            for (int a = 0; a < Dimension; a++)
            {
                if (a != j && cells[i, a].Value == valor)
                    return false;
            }

            int y = (i / 3) * 3;
            int x = (j / 3) * 3;

            for (int a = 0; a < Dimension / 3; a++)
            {
                for (int b = 0; b < Dimension / 3; b++)
                {
                    if (a != i && b != j && cells[y + a, x + b].Value == valor)
                        return false;
                }
            }
            return true;
        }


        //#############################################################################################
        //####################### LÓGICA PARA GENERAR UN TABLERO INICIAL VÁLIDO #######################
        //#############################################################################################

        private void loadValues()
        {
            // Clear the values in each cells
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }

            // This method will be called recursively 
            // until it finds suitable values for each cells
            findValueForNextCell(0, -1);
        }

        private bool findValueForNextCell(int i, int j)
        {
            // Increment the i and j values to move to the next cell
            // and if the columsn ends move to the next row
            if (++j > 8)
            {
                j = 0;

                // Exit if the line ends
                if (++i > 8)
                    return true;
            }

            var value = 0;
            var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Find a random and valid number for the cell and go to the next cell 
            // and check if it can be allocated with another random and valid number
            do
            {
                // If there is not numbers left in the list to try next, 
                // return to the previous cell and allocate it with a different number
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }

                // Take a random number from the numbers left in the list
                value = numsLeft[random.Next(0, numsLeft.Count)];
                cells[i, j].Value = value;

                // Remove the allocated value from the list
                numsLeft.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));

            // Muestra los valores generados en pantalla
            cells[i, j].ForeColor = SystemColors.HotTrack;
            cells[i, j].Text = value.ToString();
            cells[i, j].IsLocked = true;

            return true;
        }

        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                // Check all the cells in vertical direction
                if (i != y && cells[x, i].Value == value)
                    return false;

                // Check all the cells in horizontal direction
                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            // Check all the cells in the specific block
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            bool bandera = true;

            for (int j = 0; j < Dimension; j++)
            {
                int firstValue = cells[0, j].Value;

                for (int i = 1; i < Dimension; i++)
                {
                    if (firstValue == cells[i, j].Value || cells[i, j].Value == 0 || firstValue == 0)
                    {
                        bandera = false;
                    }
                }
            }

            // Check if the inputs are wrong or the player wins 
            if (!bandera)
            {
                MessageBox.Show("Wrong inputs");
            }
            else
            {
                MessageBox.Show("You Wins");
            }
        }

        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;

            // Do nothing if the cell is locked
            if (cell.IsLocked)
                return;

            int value;

            // Add the pressed key value in the cell only if it is a number
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                // Clear the cell value if pressed key is zero
                if (value == 0)
                {
                    cell.Clear();
                    cell.BackColor = ((coorx_selected / 3) + (coory_selected / 3)) % 2 == 0 ? Color.FromArgb(255, 255, 255) : SystemColors.InactiveBorder;
                    cell.Value = value;
                }
                else
                {
                    if (esPosibleInsertarInput(coorx_selected, coory_selected, value))
                    {
                        cell.ForeColor = SystemColors.MenuHighlight;
                        cell.BackColor = ((coorx_selected / 3) + (coory_selected / 3)) % 2 == 0 ? Color.FromArgb(255, 255, 255) : SystemColors.InactiveBorder;
                    }
                    else
                    {
                        cell.ForeColor = Color.Red;
                        cell.BackColor = Color.FromArgb(255, 236, 236);
                    }
                    cell.Text = value.ToString();
                    cell.Value = value;
                }
            }
        }

        private void cell_Click(object sender, EventArgs e)
        {
            // Obtener el control SudokuCell que disparó el evento
            var cell = sender as SudokuCell;

            // Actualizar las etiquetas label_coorx y label_coory con las coordenadas X e Y de la celda

            coorx_selected = cell.X;
            coory_selected = cell.Y;

            // Do something when the cell is clicked
            // Puedes agregar aquí la lógica que deseas realizar cuando el usuario hace clic en la celda
        }





        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnResolver_MouseEnter(object sender, EventArgs e)
        {
            this.btnResolver.BackColor = SystemColors.MenuHighlight;
            this.btnResolver.ForeColor = SystemColors.ButtonHighlight;
        }

        private void btnResolver_MouseLeave(object sender, EventArgs e)
        {
            this.btnResolver.BackColor = SystemColors.ButtonHighlight;
            this.btnResolver.ForeColor = SystemColors.MenuHighlight;
        }

        private void btn_num1_Click(object sender, EventArgs e)
        {
            value_selected = 1;
            if (value_selected >= 0 && coorx_selected >= 0 && coory_selected >= 0 && !cells[coorx_selected, coory_selected].IsLocked)
            {
                establecerInputValue();
            }
            reestablecerInputsSeleccionados();
        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            value_selected = 2;
            if (value_selected >= 0 && coorx_selected >= 0 && coory_selected >= 0 && !cells[coorx_selected, coory_selected].IsLocked)
            {
                establecerInputValue();
            }
            reestablecerInputsSeleccionados();
        }

        private void btn_num3_Click(object sender, EventArgs e)
        {
            value_selected = 3;
            if (value_selected >= 0 && coorx_selected >= 0 && coory_selected >= 0 && !cells[coorx_selected, coory_selected].IsLocked)
            {
                establecerInputValue();
            }
            reestablecerInputsSeleccionados();
        }

        private void btn_num4_Click(object sender, EventArgs e)
        {
            value_selected = 4;
            if (value_selected >= 0 && coorx_selected >= 0 && coory_selected >= 0 && !cells[coorx_selected, coory_selected].IsLocked)
            {
                establecerInputValue();
            }
            reestablecerInputsSeleccionados();
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            value_selected = 5;
            if (value_selected >= 0 && coorx_selected >= 0 && coory_selected >= 0 && !cells[coorx_selected, coory_selected].IsLocked)
            {
                establecerInputValue();
            }
            reestablecerInputsSeleccionados();
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            value_selected = 6;
            if (value_selected >= 0 && coorx_selected >= 0 && coory_selected >= 0 && !cells[coorx_selected, coory_selected].IsLocked)
            {
                establecerInputValue();
            }
            reestablecerInputsSeleccionados();
        }

        private void btn_num7_Click(object sender, EventArgs e)
        {
            value_selected = 7;
            if (value_selected >= 0 && coorx_selected >= 0 && coory_selected >= 0 && !cells[coorx_selected, coory_selected].IsLocked)
            {
                establecerInputValue();
            }
            reestablecerInputsSeleccionados();
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            value_selected = 8;
            if (value_selected >= 0 && coorx_selected >= 0 && coory_selected >= 0 && !cells[coorx_selected, coory_selected].IsLocked)
            {
                establecerInputValue();
            }
            reestablecerInputsSeleccionados();
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            value_selected = 9;
            if (value_selected >= 0 && coorx_selected >= 0 && coory_selected >= 0 && !cells[coorx_selected, coory_selected].IsLocked)
            {
                establecerInputValue();
            }
            reestablecerInputsSeleccionados();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            resolver();
        }

        public static int parentX, parentY;

        private void button1_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (ModalForm modal = new ModalForm(this))
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();

            }
        }

        private void establecerInputValue()
        {
            if (value_selected == 0)
            {
                cells[coorx_selected, coory_selected].Clear();
                cells[coorx_selected, coory_selected].BackColor = ((coorx_selected / 3) + (coory_selected / 3)) % 2 == 0 ? Color.FromArgb(255, 255, 255) : SystemColors.InactiveBorder;
                cells[coorx_selected, coory_selected].Value = value_selected;
            }
            else
            {
                if (esPosibleInsertarInput(coorx_selected, coory_selected, value_selected))
                {
                    cells[coorx_selected, coory_selected].ForeColor = SystemColors.MenuHighlight;
                    cells[coorx_selected, coory_selected].BackColor = ((coorx_selected / 3) + (coory_selected / 3)) % 2 == 0 ? Color.FromArgb(255, 255, 255) : SystemColors.InactiveBorder;
                }
                else
                {
                    cells[coorx_selected, coory_selected].ForeColor = Color.Red;
                    cells[coorx_selected, coory_selected].BackColor = Color.FromArgb(255, 236, 236);
                }
                cells[coorx_selected, coory_selected].Text = value_selected.ToString();
                cells[coorx_selected, coory_selected].Value = value_selected;
            }
        }

        public void reestablecerInputsSeleccionados()
        {
            //value_selected = -1;
            //coorx_selected = -1;
            //coory_selected = -1;
        }
    }
}
