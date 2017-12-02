namespace EstudoEventos
{
    partial class rfmGerenciador
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
            this.btnLatir = new System.Windows.Forms.Button();
            this.pgbLatidos = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnLatir
            // 
            this.btnLatir.Location = new System.Drawing.Point(12, 12);
            this.btnLatir.Name = "btnLatir";
            this.btnLatir.Size = new System.Drawing.Size(75, 23);
            this.btnLatir.TabIndex = 0;
            this.btnLatir.Text = "Latir!";
            this.btnLatir.UseVisualStyleBackColor = true;
            this.btnLatir.Click += new System.EventHandler(this.btnLatir_Click);
            // 
            // pgbLatidos
            // 
            this.pgbLatidos.Location = new System.Drawing.Point(12, 65);
            this.pgbLatidos.Name = "pgbLatidos";
            this.pgbLatidos.Size = new System.Drawing.Size(493, 23);
            this.pgbLatidos.TabIndex = 1;
            // 
            // rfmGerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 137);
            this.Controls.Add(this.pgbLatidos);
            this.Controls.Add(this.btnLatir);
            this.Name = "rfmGerenciador";
            this.Text = "Gerenciador de latidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLatir;
        private System.Windows.Forms.ProgressBar pgbLatidos;
    }
}

