
namespace ClientGestor
{
    partial class FormRegistarChaveVencedora
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNome = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderData = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderChave = new System.Windows.Forms.ColumnHeader();
            this.buttonListaApostas = new System.Windows.Forms.Button();
            this.buttonApostar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Estrelas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Números:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 23);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 23);
            this.textBox1.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderData,
            this.columnHeaderChave});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(152, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(454, 398);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Tag = "";
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 150;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data da Aposta";
            this.columnHeaderData.Width = 150;
            // 
            // columnHeaderChave
            // 
            this.columnHeaderChave.Text = "As suas Chaves";
            this.columnHeaderChave.Width = 150;
            // 
            // buttonListaApostas
            // 
            this.buttonListaApostas.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonListaApostas.Location = new System.Drawing.Point(12, 224);
            this.buttonListaApostas.Name = "buttonListaApostas";
            this.buttonListaApostas.Size = new System.Drawing.Size(95, 46);
            this.buttonListaApostas.TabIndex = 13;
            this.buttonListaApostas.Text = "Ver Apostas";
            this.buttonListaApostas.UseVisualStyleBackColor = true;
            this.buttonListaApostas.Click += new System.EventHandler(this.buttonListaApostas_Click);
            // 
            // buttonApostar
            // 
            this.buttonApostar.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApostar.Location = new System.Drawing.Point(12, 178);
            this.buttonApostar.Name = "buttonApostar";
            this.buttonApostar.Size = new System.Drawing.Size(95, 40);
            this.buttonApostar.TabIndex = 12;
            this.buttonApostar.Text = "Registar Chave";
            this.buttonApostar.UseVisualStyleBackColor = true;
            this.buttonApostar.Click += new System.EventHandler(this.buttonApostar_Click);
            // 
            // FormRegistarChaveVencedora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(618, 424);
            this.Controls.Add(this.buttonListaApostas);
            this.Controls.Add(this.buttonApostar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "FormRegistarChaveVencedora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistarChaveVencedora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderChave;
        private System.Windows.Forms.Button buttonListaApostas;
        private System.Windows.Forms.Button buttonApostar;
    }
}