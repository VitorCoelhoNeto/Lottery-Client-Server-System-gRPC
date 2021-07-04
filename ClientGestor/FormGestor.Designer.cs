
namespace ClientGestor
{
    partial class FormGestor
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
            this.buttonVencedores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegistarVencedora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVencedores
            // 
            this.buttonVencedores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonVencedores.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVencedores.Location = new System.Drawing.Point(76, 59);
            this.buttonVencedores.Name = "buttonVencedores";
            this.buttonVencedores.Size = new System.Drawing.Size(202, 30);
            this.buttonVencedores.TabIndex = 2;
            this.buttonVencedores.Text = "Ver Apostas Vencedoras";
            this.buttonVencedores.UseVisualStyleBackColor = true;
            this.buttonVencedores.Click += new System.EventHandler(this.buttonVencedores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem-vindo Gestor";
            // 
            // buttonRegistarVencedora
            // 
            this.buttonRegistarVencedora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRegistarVencedora.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistarVencedora.Location = new System.Drawing.Point(76, 110);
            this.buttonRegistarVencedora.Name = "buttonRegistarVencedora";
            this.buttonRegistarVencedora.Size = new System.Drawing.Size(202, 30);
            this.buttonRegistarVencedora.TabIndex = 4;
            this.buttonRegistarVencedora.Text = "Registar Chave Vencedora";
            this.buttonRegistarVencedora.UseVisualStyleBackColor = true;
            this.buttonRegistarVencedora.Click += new System.EventHandler(this.buttonRegistarVencedora_Click);
            // 
            // FormGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(358, 201);
            this.Controls.Add(this.buttonRegistarVencedora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVencedores);
            this.Name = "FormGestor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVencedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegistarVencedora;
    }
}

