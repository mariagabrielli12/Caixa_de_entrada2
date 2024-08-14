namespace Caixa_de_entrada2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textusuario = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnacess = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textusuario
            // 
            this.textusuario.AutoSize = true;
            this.textusuario.Location = new System.Drawing.Point(28, 27);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(43, 13);
            this.textusuario.TabIndex = 1;
            this.textusuario.Text = "Usuário";
            this.textusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.AutoSize = true;
            this.txtsenha.Location = new System.Drawing.Point(28, 82);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(38, 13);
            this.txtsenha.TabIndex = 2;
            this.txtsenha.Text = "Senha";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnacess
            // 
            this.btnacess.Location = new System.Drawing.Point(77, 118);
            this.btnacess.Name = "btnacess";
            this.btnacess.Size = new System.Drawing.Size(75, 23);
            this.btnacess.TabIndex = 4;
            this.btnacess.Text = "Entrar";
            this.btnacess.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 186);
            this.Controls.Add(this.btnacess);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.textusuario);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textusuario;
        private System.Windows.Forms.Label txtsenha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnacess;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

