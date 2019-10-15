namespace _OLC1_Tarea3.com.vista
{
    partial class MenuErrores
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
            this.buttonAST = new System.Windows.Forms.Button();
            this.buttonErrores = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAST
            // 
            this.buttonAST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.buttonAST.FlatAppearance.BorderSize = 0;
            this.buttonAST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAST.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAST.ForeColor = System.Drawing.Color.White;
            this.buttonAST.Location = new System.Drawing.Point(0, 42);
            this.buttonAST.Name = "buttonAST";
            this.buttonAST.Size = new System.Drawing.Size(171, 44);
            this.buttonAST.TabIndex = 2;
            this.buttonAST.Text = "      GenerarAST";
            this.buttonAST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAST.UseVisualStyleBackColor = false;
            this.buttonAST.Click += new System.EventHandler(this.buttonAST_Click);
            // 
            // buttonErrores
            // 
            this.buttonErrores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.buttonErrores.FlatAppearance.BorderSize = 0;
            this.buttonErrores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErrores.Font = new System.Drawing.Font("Dream Orphans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErrores.ForeColor = System.Drawing.Color.White;
            this.buttonErrores.Location = new System.Drawing.Point(0, 0);
            this.buttonErrores.Name = "buttonErrores";
            this.buttonErrores.Size = new System.Drawing.Size(171, 44);
            this.buttonErrores.TabIndex = 1;
            this.buttonErrores.Text = "      Errores";
            this.buttonErrores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonErrores.UseVisualStyleBackColor = false;
            this.buttonErrores.Click += new System.EventHandler(this.buttonErrores_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.buttonPanel.Controls.Add(this.buttonAST);
            this.buttonPanel.Controls.Add(this.buttonErrores);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(171, 92);
            this.buttonPanel.TabIndex = 3;
            // 
            // MenuErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 92);
            this.Controls.Add(this.buttonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(181, 116);
            this.Name = "MenuErrores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MenuErrores";
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAST;
        private System.Windows.Forms.Button buttonErrores;
        private System.Windows.Forms.Panel buttonPanel;
    }
}