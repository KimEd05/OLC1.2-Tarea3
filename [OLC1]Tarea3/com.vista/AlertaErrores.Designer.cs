namespace _OLC1_Tarea3.com.vista
{
    partial class AlertaErrores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertaErrores));
            this.labelSemanticos = new System.Windows.Forms.Label();
            this.labelSintacticos = new System.Windows.Forms.Label();
            this.labelLexicos = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSemanticos
            // 
            this.labelSemanticos.AutoSize = true;
            this.labelSemanticos.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemanticos.ForeColor = System.Drawing.Color.White;
            this.labelSemanticos.Location = new System.Drawing.Point(59, 113);
            this.labelSemanticos.Name = "labelSemanticos";
            this.labelSemanticos.Size = new System.Drawing.Size(112, 15);
            this.labelSemanticos.TabIndex = 11;
            this.labelSemanticos.Text = "Errores Semánticos:";
            this.labelSemanticos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSintacticos
            // 
            this.labelSintacticos.AutoSize = true;
            this.labelSintacticos.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSintacticos.ForeColor = System.Drawing.Color.White;
            this.labelSintacticos.Location = new System.Drawing.Point(59, 75);
            this.labelSintacticos.Name = "labelSintacticos";
            this.labelSintacticos.Size = new System.Drawing.Size(108, 15);
            this.labelSintacticos.TabIndex = 10;
            this.labelSintacticos.Text = "Errores Sintácticos:";
            this.labelSintacticos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLexicos
            // 
            this.labelLexicos.AutoSize = true;
            this.labelLexicos.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLexicos.ForeColor = System.Drawing.Color.White;
            this.labelLexicos.Location = new System.Drawing.Point(59, 37);
            this.labelLexicos.Name = "labelLexicos";
            this.labelLexicos.Size = new System.Drawing.Size(92, 15);
            this.labelLexicos.TabIndex = 9;
            this.labelLexicos.Text = "Errores Léxicos:";
            this.labelLexicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOK
            // 
            this.buttonOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOK.BackgroundImage")));
            this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(308, 113);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 80);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // AlertaErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(446, 231);
            this.Controls.Add(this.labelSemanticos);
            this.Controls.Add(this.labelSintacticos);
            this.Controls.Add(this.labelLexicos);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(333, 225);
            this.Name = "AlertaErrores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AlertaErrores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSemanticos;
        private System.Windows.Forms.Label labelSintacticos;
        private System.Windows.Forms.Label labelLexicos;
        private System.Windows.Forms.Button buttonOK;
    }
}