
namespace ClientUtilizador
{
    partial class FormMenuUtilizador
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
            this.buttonApostar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApostas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonApostar
            // 
            this.buttonApostar.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApostar.Location = new System.Drawing.Point(73, 78);
            this.buttonApostar.Name = "buttonApostar";
            this.buttonApostar.Size = new System.Drawing.Size(145, 29);
            this.buttonApostar.TabIndex = 6;
            this.buttonApostar.Text = "Apostar";
            this.buttonApostar.UseVisualStyleBackColor = true;
            this.buttonApostar.Click += new System.EventHandler(this.buttonApostar_Click_1);
            // 
            // labelNome
            // 
            this.labelNome.AutoEllipsis = true;
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(174, 40);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(0, 19);
            this.labelNome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bem-vindo";
            // 
            // buttonApostas
            // 
            this.buttonApostas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonApostas.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApostas.Location = new System.Drawing.Point(73, 124);
            this.buttonApostas.Name = "buttonApostas";
            this.buttonApostas.Size = new System.Drawing.Size(145, 30);
            this.buttonApostas.TabIndex = 7;
            this.buttonApostas.Text = "Ver Apostas Vencedoras";
            this.buttonApostas.UseVisualStyleBackColor = true;
            this.buttonApostas.Click += new System.EventHandler(this.buttonApostas_Click);
            // 
            // FormMenuUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(342, 214);
            this.Controls.Add(this.buttonApostas);
            this.Controls.Add(this.buttonApostar);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label1);
            this.Name = "FormMenuUtilizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuUtilizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonApostar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApostas;
    }
}