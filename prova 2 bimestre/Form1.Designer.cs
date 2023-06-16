namespace prova_2_bimestre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_codigo = new System.Windows.Forms.TextBox();
            this.combobox_unidade = new System.Windows.Forms.ComboBox();
            this.tx_descricao = new System.Windows.Forms.TextBox();
            this.tx_valor = new System.Windows.Forms.TextBox();
            this.tx_pis = new System.Windows.Forms.TextBox();
            this.tx_icms = new System.Windows.Forms.TextBox();
            this.tx_confins = new System.Windows.Forms.TextBox();
            this.tx_lucro = new System.Windows.Forms.TextBox();
            this.lb_valorVenda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "PIS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "ICMS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 235);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "CONFINS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 282);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Lucro:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 334);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Valor da Venda:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_codigo
            // 
            this.tx_codigo.Location = new System.Drawing.Point(105, 75);
            this.tx_codigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tx_codigo.Name = "tx_codigo";
            this.tx_codigo.Size = new System.Drawing.Size(204, 26);
            this.tx_codigo.TabIndex = 12;
            // 
            // combobox_unidade
            // 
            this.combobox_unidade.FormattingEnabled = true;
            this.combobox_unidade.Items.AddRange(new object[] {
            "UN",
            "LT",
            "KL"});
            this.combobox_unidade.Location = new System.Drawing.Point(399, 74);
            this.combobox_unidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combobox_unidade.Name = "combobox_unidade";
            this.combobox_unidade.Size = new System.Drawing.Size(180, 28);
            this.combobox_unidade.TabIndex = 13;
            // 
            // tx_descricao
            // 
            this.tx_descricao.Location = new System.Drawing.Point(126, 123);
            this.tx_descricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tx_descricao.Name = "tx_descricao";
            this.tx_descricao.Size = new System.Drawing.Size(452, 26);
            this.tx_descricao.TabIndex = 14;
            // 
            // tx_valor
            // 
            this.tx_valor.AutoCompleteCustomSource.AddRange(new string[] {
            "0,00"});
            this.tx_valor.Location = new System.Drawing.Point(96, 172);
            this.tx_valor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(160, 26);
            this.tx_valor.TabIndex = 15;
            // 
            // tx_pis
            // 
            this.tx_pis.Location = new System.Drawing.Point(339, 172);
            this.tx_pis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tx_pis.Name = "tx_pis";
            this.tx_pis.Size = new System.Drawing.Size(182, 26);
            this.tx_pis.TabIndex = 16;
            // 
            // tx_icms
            // 
            this.tx_icms.Location = new System.Drawing.Point(96, 231);
            this.tx_icms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tx_icms.Name = "tx_icms";
            this.tx_icms.Size = new System.Drawing.Size(160, 26);
            this.tx_icms.TabIndex = 17;
            // 
            // tx_confins
            // 
            this.tx_confins.Location = new System.Drawing.Point(384, 231);
            this.tx_confins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tx_confins.Name = "tx_confins";
            this.tx_confins.Size = new System.Drawing.Size(138, 26);
            this.tx_confins.TabIndex = 18;
            // 
            // tx_lucro
            // 
            this.tx_lucro.Location = new System.Drawing.Point(96, 277);
            this.tx_lucro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tx_lucro.Name = "tx_lucro";
            this.tx_lucro.Size = new System.Drawing.Size(138, 26);
            this.tx_lucro.TabIndex = 20;
            // 
            // lb_valorVenda
            // 
            this.lb_valorVenda.AutoSize = true;
            this.lb_valorVenda.Location = new System.Drawing.Point(166, 334);
            this.lb_valorVenda.Name = "lb_valorVenda";
            this.lb_valorVenda.Size = new System.Drawing.Size(60, 20);
            this.lb_valorVenda.TabIndex = 21;
            this.lb_valorVenda.Text = "label11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 434);
            this.Controls.Add(this.lb_valorVenda);
            this.Controls.Add(this.tx_lucro);
            this.Controls.Add(this.tx_confins);
            this.Controls.Add(this.tx_icms);
            this.Controls.Add(this.tx_pis);
            this.Controls.Add(this.tx_valor);
            this.Controls.Add(this.tx_descricao);
            this.Controls.Add(this.combobox_unidade);
            this.Controls.Add(this.tx_codigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_codigo;
        private System.Windows.Forms.ComboBox combobox_unidade;
        private System.Windows.Forms.TextBox tx_descricao;
        private System.Windows.Forms.TextBox tx_valor;
        private System.Windows.Forms.TextBox tx_pis;
        private System.Windows.Forms.TextBox tx_icms;
        private System.Windows.Forms.TextBox tx_confins;
        private System.Windows.Forms.TextBox tx_lucro;
        private System.Windows.Forms.Label lb_valorVenda;
    }
}

