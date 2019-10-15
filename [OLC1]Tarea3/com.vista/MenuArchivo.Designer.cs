namespace _OLC1_Tarea3.com.vista
{
    partial class MenuArchivo
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
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardarComo = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.buttonPanel.Controls.Add(this.buttonEliminar);
            this.buttonPanel.Controls.Add(this.buttonGuardarComo);
            this.buttonPanel.Controls.Add(this.buttonGuardar);
            this.buttonPanel.Controls.Add(this.buttonAbrir);
            this.buttonPanel.Controls.Add(this.buttonCrear);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPanel.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(171, 217);
            this.buttonPanel.TabIndex = 2;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(0, 168);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(171, 44);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.Text = "      Eliminar pestaña";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardarComo
            // 
            this.buttonGuardarComo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.buttonGuardarComo.FlatAppearance.BorderSize = 0;
            this.buttonGuardarComo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarComo.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarComo.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarComo.Location = new System.Drawing.Point(0, 126);
            this.buttonGuardarComo.Name = "buttonGuardarComo";
            this.buttonGuardarComo.Size = new System.Drawing.Size(171, 44);
            this.buttonGuardarComo.TabIndex = 4;
            this.buttonGuardarComo.Text = "      Guardar como";
            this.buttonGuardarComo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarComo.UseVisualStyleBackColor = false;
            this.buttonGuardarComo.Click += new System.EventHandler(this.buttonGuardarComo_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(0, 84);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(171, 44);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "      Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.buttonAbrir.FlatAppearance.BorderSize = 0;
            this.buttonAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrir.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrir.ForeColor = System.Drawing.Color.White;
            this.buttonAbrir.Location = new System.Drawing.Point(0, 42);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(171, 44);
            this.buttonAbrir.TabIndex = 2;
            this.buttonAbrir.Text = "      Abrir";
            this.buttonAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbrir.UseVisualStyleBackColor = false;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.buttonCrear.FlatAppearance.BorderSize = 0;
            this.buttonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrear.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.ForeColor = System.Drawing.Color.White;
            this.buttonCrear.Location = new System.Drawing.Point(0, 0);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(171, 44);
            this.buttonCrear.TabIndex = 1;
            this.buttonCrear.Text = "      Crear";
            this.buttonCrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // MenuArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 217);
            this.Controls.Add(this.buttonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(181, 74);
            this.Name = "MenuArchivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MenuArchivo";
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardarComo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.Button buttonCrear;
    }
}