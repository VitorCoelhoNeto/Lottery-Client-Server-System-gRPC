
namespace ClientAdministrador
{
    partial class FormAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonListaUtilizadores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonListaApostas = new System.Windows.Forms.Button();
            this.buttonArquivarApostas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonListaUtilizadores
            // 
            this.buttonListaUtilizadores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonListaUtilizadores.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonListaUtilizadores.Location = new System.Drawing.Point(69, 76);
            this.buttonListaUtilizadores.Name = "buttonListaUtilizadores";
            this.buttonListaUtilizadores.Size = new System.Drawing.Size(203, 28);
            this.buttonListaUtilizadores.TabIndex = 3;
            this.buttonListaUtilizadores.Text = "Ver Utilizadores ";
            this.buttonListaUtilizadores.UseVisualStyleBackColor = true;
            this.buttonListaUtilizadores.Click += new System.EventHandler(this.buttonListaUtilizadores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bem-vindo Administrador";
            // 
            // buttonListaApostas
            // 
            this.buttonListaApostas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonListaApostas.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonListaApostas.Location = new System.Drawing.Point(69, 123);
            this.buttonListaApostas.Name = "buttonListaApostas";
            this.buttonListaApostas.Size = new System.Drawing.Size(203, 28);
            this.buttonListaApostas.TabIndex = 5;
            this.buttonListaApostas.Text = "Ver Apostas";
            this.buttonListaApostas.UseVisualStyleBackColor = true;
            this.buttonListaApostas.Click += new System.EventHandler(this.buttonListaApostas_Click);
            // 
            // buttonArquivarApostas
            // 
            this.buttonArquivarApostas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonArquivarApostas.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonArquivarApostas.Location = new System.Drawing.Point(69, 169);
            this.buttonArquivarApostas.Name = "buttonArquivarApostas";
            this.buttonArquivarApostas.Size = new System.Drawing.Size(203, 28);
            this.buttonArquivarApostas.TabIndex = 6;
            this.buttonArquivarApostas.Text = "Arquivar Apostas";
            this.buttonArquivarApostas.UseVisualStyleBackColor = true;
            this.buttonArquivarApostas.Click += new System.EventHandler(this.buttonArquivarApostas_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(344, 243);
            this.Controls.Add(this.buttonArquivarApostas);
            this.Controls.Add(this.buttonListaApostas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonListaUtilizadores);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListaUtilizadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonListaApostas;
        private System.Windows.Forms.Button buttonArquivarApostas;
    }
}

