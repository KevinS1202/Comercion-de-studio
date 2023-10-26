namespace Lab7
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
            this.cpecialBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.buchenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cpecialBtn
            // 
            this.cpecialBtn.Location = new System.Drawing.Point(29, 21);
            this.cpecialBtn.Name = "cpecialBtn";
            this.cpecialBtn.Size = new System.Drawing.Size(149, 88);
            this.cpecialBtn.TabIndex = 0;
            this.cpecialBtn.Text = "СПЕЦИАЛЬНОСТИ";
            this.cpecialBtn.UseVisualStyleBackColor = true;
            this.cpecialBtn.Click += new System.EventHandler(this.cpecialBtn_Click);
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(29, 140);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(149, 88);
            this.studentBtn.TabIndex = 1;
            this.studentBtn.Text = "СТУДЕНТЫ";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // buchenBtn
            // 
            this.buchenBtn.Location = new System.Drawing.Point(29, 266);
            this.buchenBtn.Name = "buchenBtn";
            this.buchenBtn.Size = new System.Drawing.Size(149, 88);
            this.buchenBtn.TabIndex = 2;
            this.buchenBtn.Text = "ОБУЧЕНИЕ";
            this.buchenBtn.UseVisualStyleBackColor = true;
            this.buchenBtn.Click += new System.EventHandler(this.buchenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 368);
            this.Controls.Add(this.buchenBtn);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.cpecialBtn);
            this.Name = "Form1";
            this.Text = "Коммерческое обучение в вузе";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cpecialBtn;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Button buchenBtn;
    }
}

