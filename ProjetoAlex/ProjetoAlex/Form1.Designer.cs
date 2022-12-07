namespace ProjetoAlex
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
            this.botao = new System.Windows.Forms.Button();
            this.primeiramensagem = new System.Windows.Forms.Label();
            this.botao2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chega = new System.Windows.Forms.Button();
            this.ultimamensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao
            // 
            this.botao.BackColor = System.Drawing.Color.Black;
            this.botao.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botao.Location = new System.Drawing.Point(-2, 1);
            this.botao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(457, 101);
            this.botao.TabIndex = 0;
            this.botao.Text = "clique";
            this.botao.UseVisualStyleBackColor = false;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // primeiramensagem
            // 
            this.primeiramensagem.AutoSize = true;
            this.primeiramensagem.BackColor = System.Drawing.Color.Black;
            this.primeiramensagem.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeiramensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.primeiramensagem.Location = new System.Drawing.Point(13, 106);
            this.primeiramensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.primeiramensagem.Name = "primeiramensagem";
            this.primeiramensagem.Size = new System.Drawing.Size(211, 39);
            this.primeiramensagem.TabIndex = 1;
            this.primeiramensagem.Text = "mensagem";
            // 
            // botao2
            // 
            this.botao2.BackColor = System.Drawing.Color.Black;
            this.botao2.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botao2.Location = new System.Drawing.Point(-2, 149);
            this.botao2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(531, 114);
            this.botao2.TabIndex = 2;
            this.botao2.Text = "clique aqui para saber se ta tudo certo?";
            this.botao2.UseVisualStyleBackColor = false;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(13, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // chega
            // 
            this.chega.BackColor = System.Drawing.Color.Black;
            this.chega.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chega.Location = new System.Drawing.Point(-2, 310);
            this.chega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chega.Name = "chega";
            this.chega.Size = new System.Drawing.Size(278, 107);
            this.chega.TabIndex = 4;
            this.chega.Text = "Fim!";
            this.chega.UseVisualStyleBackColor = false;
            this.chega.Click += new System.EventHandler(this.chega_Click);
            // 
            // ultimamensagem
            // 
            this.ultimamensagem.AutoSize = true;
            this.ultimamensagem.BackColor = System.Drawing.Color.Black;
            this.ultimamensagem.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimamensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ultimamensagem.Location = new System.Drawing.Point(0, 421);
            this.ultimamensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ultimamensagem.Name = "ultimamensagem";
            this.ultimamensagem.Size = new System.Drawing.Size(139, 41);
            this.ultimamensagem.TabIndex = 5;
            this.ultimamensagem.Text = "chega";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(954, 530);
            this.Controls.Add(this.ultimamensagem);
            this.Controls.Add(this.chega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.primeiramensagem);
            this.Controls.Add(this.botao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "mensagem";
            this.Load += new System.EventHandler(this.load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.Label primeiramensagem;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chega;
        private System.Windows.Forms.Label ultimamensagem;
    }
}

