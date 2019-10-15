namespace _OLC1_Tarea3.com.vista
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.labelColumna = new System.Windows.Forms.Label();
            this.Valor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabSimbolos = new System.Windows.Forms.TabPage();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabConsola = new System.Windows.Forms.TabPage();
            this.richConsola = new System.Windows.Forms.RichTextBox();
            this.tabSalida = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLinea = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCompilar = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonArchivo = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.buttonPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabSimbolos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabConsola.SuspendLayout();
            this.tabSalida.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.logoPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelColumna
            // 
            this.labelColumna.AutoSize = true;
            this.labelColumna.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumna.Location = new System.Drawing.Point(940, 425);
            this.labelColumna.Name = "labelColumna";
            this.labelColumna.Size = new System.Drawing.Size(56, 15);
            this.labelColumna.TabIndex = 11;
            this.labelColumna.Text = "Columna: ";
            // 
            // Valor3
            // 
            this.Valor3.Frozen = true;
            this.Valor3.HeaderText = "";
            this.Valor3.MinimumWidth = 153;
            this.Valor3.Name = "Valor3";
            this.Valor3.ReadOnly = true;
            this.Valor3.Width = 153;
            // 
            // Valor2
            // 
            this.Valor2.Frozen = true;
            this.Valor2.HeaderText = "";
            this.Valor2.MinimumWidth = 153;
            this.Valor2.Name = "Valor2";
            this.Valor2.ReadOnly = true;
            this.Valor2.Width = 153;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Valor.FillWeight = 200F;
            this.Valor.Frozen = true;
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 153;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Valor.Width = 153;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 180;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 180;
            // 
            // Columna
            // 
            this.Columna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Columna.Frozen = true;
            this.Columna.HeaderText = "Columna";
            this.Columna.MinimumWidth = 95;
            this.Columna.Name = "Columna";
            this.Columna.ReadOnly = true;
            this.Columna.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Columna.Width = 95;
            // 
            // Linea
            // 
            this.Linea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Linea.Frozen = true;
            this.Linea.HeaderText = "Línea";
            this.Linea.MinimumWidth = 95;
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            this.Linea.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Linea.Width = 95;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linea,
            this.Columna,
            this.ID,
            this.Valor,
            this.Valor2,
            this.Valor3});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(865, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabSimbolos
            // 
            this.tabSimbolos.Controls.Add(this.dataGridView1);
            this.tabSimbolos.Location = new System.Drawing.Point(4, 24);
            this.tabSimbolos.Name = "tabSimbolos";
            this.tabSimbolos.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimbolos.Size = new System.Drawing.Size(871, 181);
            this.tabSimbolos.TabIndex = 1;
            this.tabSimbolos.Text = "Tabla de Símbolos";
            this.tabSimbolos.UseVisualStyleBackColor = true;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(867, 14);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(27, 27);
            this.buttonMinimize.TabIndex = 3;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(899, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tabConsola
            // 
            this.tabConsola.Controls.Add(this.richConsola);
            this.tabConsola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsola.Location = new System.Drawing.Point(4, 24);
            this.tabConsola.Name = "tabConsola";
            this.tabConsola.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsola.Size = new System.Drawing.Size(871, 181);
            this.tabConsola.TabIndex = 0;
            this.tabConsola.Text = "Consola";
            this.tabConsola.UseVisualStyleBackColor = true;
            // 
            // richConsola
            // 
            this.richConsola.Location = new System.Drawing.Point(3, 3);
            this.richConsola.Name = "richConsola";
            this.richConsola.ReadOnly = true;
            this.richConsola.Size = new System.Drawing.Size(865, 174);
            this.richConsola.TabIndex = 0;
            this.richConsola.Text = "";
            // 
            // tabSalida
            // 
            this.tabSalida.Controls.Add(this.tabConsola);
            this.tabSalida.Controls.Add(this.tabSimbolos);
            this.tabSalida.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSalida.Location = new System.Drawing.Point(203, 444);
            this.tabSalida.Name = "tabSalida";
            this.tabSalida.SelectedIndex = 0;
            this.tabSalida.Size = new System.Drawing.Size(879, 209);
            this.tabSalida.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dream Orphans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Proyecto 2 [Organización de Lenguajes y Compiladores 1]";
            // 
            // labelLinea
            // 
            this.labelLinea.AutoSize = true;
            this.labelLinea.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinea.Location = new System.Drawing.Point(819, 425);
            this.labelLinea.Name = "labelLinea";
            this.labelLinea.Size = new System.Drawing.Size(39, 15);
            this.labelLinea.TabIndex = 7;
            this.labelLinea.Text = "Línea: ";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.buttonMinimize);
            this.headerPanel.Controls.Add(this.buttonClose);
            this.headerPanel.Controls.Add(this.pictureBox2);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(171, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(941, 64);
            this.headerPanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(15, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dream Orphans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "OLC1\r\nInterpreter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonCompilar
            // 
            this.buttonCompilar.FlatAppearance.BorderSize = 0;
            this.buttonCompilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompilar.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompilar.ForeColor = System.Drawing.Color.White;
            this.buttonCompilar.Location = new System.Drawing.Point(0, 148);
            this.buttonCompilar.Name = "buttonCompilar";
            this.buttonCompilar.Size = new System.Drawing.Size(171, 44);
            this.buttonCompilar.TabIndex = 3;
            this.buttonCompilar.Text = "      Compilar";
            this.buttonCompilar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompilar.UseVisualStyleBackColor = true;
            this.buttonCompilar.Click += new System.EventHandler(this.buttonCompilar_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.FlatAppearance.BorderSize = 0;
            this.buttonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportes.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportes.ForeColor = System.Drawing.Color.White;
            this.buttonReportes.Location = new System.Drawing.Point(0, 106);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(171, 44);
            this.buttonReportes.TabIndex = 2;
            this.buttonReportes.Text = "      Reportes";
            this.buttonReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportes.UseVisualStyleBackColor = true;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // buttonArchivo
            // 
            this.buttonArchivo.FlatAppearance.BorderSize = 0;
            this.buttonArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArchivo.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArchivo.ForeColor = System.Drawing.Color.White;
            this.buttonArchivo.Location = new System.Drawing.Point(0, 64);
            this.buttonArchivo.Name = "buttonArchivo";
            this.buttonArchivo.Size = new System.Drawing.Size(171, 44);
            this.buttonArchivo.TabIndex = 1;
            this.buttonArchivo.Text = "      Archivo";
            this.buttonArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArchivo.UseVisualStyleBackColor = true;
            this.buttonArchivo.Click += new System.EventHandler(this.buttonArchivo_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Controls.Add(this.label2);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(171, 67);
            this.logoPanel.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(203, 91);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(879, 318);
            this.tabControl.TabIndex = 9;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.buttonPanel.Controls.Add(this.buttonCompilar);
            this.buttonPanel.Controls.Add(this.buttonReportes);
            this.buttonPanel.Controls.Add(this.buttonArchivo);
            this.buttonPanel.Controls.Add(this.logoPanel);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(171, 682);
            this.buttonPanel.TabIndex = 6;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1112, 682);
            this.Controls.Add(this.labelColumna);
            this.Controls.Add(this.tabSalida);
            this.Controls.Add(this.labelLinea);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabSimbolos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabConsola.ResumeLayout(false);
            this.tabSalida.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabSimbolos;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabConsola;
        private System.Windows.Forms.RichTextBox richConsola;
        private System.Windows.Forms.TabControl tabSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLinea;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCompilar;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonArchivo;
        private System.Windows.Forms.Panel logoPanel;
        public System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Panel buttonPanel;
    }
}