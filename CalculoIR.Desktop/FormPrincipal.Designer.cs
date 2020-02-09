namespace CalculoIR.Desktop
{
    partial class FormPrincipal
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
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.numDependentes = new System.Windows.Forms.NumericUpDown();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRendaMensal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCalculo = new System.Windows.Forms.TabPage();
            this.txtResultadoCalculo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TabPrincipal.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDependentes)).BeginInit();
            this.tabCalculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPrincipal.Controls.Add(this.tabCadastro);
            this.TabPrincipal.Controls.Add(this.tabCalculo);
            this.TabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(432, 381);
            this.TabPrincipal.TabIndex = 0;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.txtResultado);
            this.tabCadastro.Controls.Add(this.btnCadastrar);
            this.tabCadastro.Controls.Add(this.numDependentes);
            this.tabCadastro.Controls.Add(this.txtCPF);
            this.tabCadastro.Controls.Add(this.label4);
            this.tabCadastro.Controls.Add(this.label3);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Controls.Add(this.txtRendaMensal);
            this.tabCadastro.Controls.Add(this.txtNome);
            this.tabCadastro.Controls.Add(this.label1);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(424, 355);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastro Contribuinte";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.Location = new System.Drawing.Point(14, 151);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(404, 198);
            this.txtResultado.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(14, 122);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // numDependentes
            // 
            this.numDependentes.Location = new System.Drawing.Point(111, 95);
            this.numDependentes.Name = "numDependentes";
            this.numDependentes.Size = new System.Drawing.Size(60, 20);
            this.numDependentes.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(111, 42);
            this.txtCPF.Mask = "999.999.999/99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(95, 20);
            this.txtCPF.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qtd. Dependentes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Renda Mensal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF";
            // 
            // txtRendaMensal
            // 
            this.txtRendaMensal.Location = new System.Drawing.Point(111, 68);
            this.txtRendaMensal.Name = "txtRendaMensal";
            this.txtRendaMensal.Size = new System.Drawing.Size(117, 20);
            this.txtRendaMensal.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(111, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(307, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tabCalculo
            // 
            this.tabCalculo.Controls.Add(this.txtResultadoCalculo);
            this.tabCalculo.Controls.Add(this.button1);
            this.tabCalculo.Controls.Add(this.txtSalarioMinimo);
            this.tabCalculo.Controls.Add(this.label6);
            this.tabCalculo.Location = new System.Drawing.Point(4, 22);
            this.tabCalculo.Name = "tabCalculo";
            this.tabCalculo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculo.Size = new System.Drawing.Size(424, 355);
            this.tabCalculo.TabIndex = 1;
            this.tabCalculo.Text = "Calculo IR";
            this.tabCalculo.UseVisualStyleBackColor = true;
            // 
            // txtResultadoCalculo
            // 
            this.txtResultadoCalculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultadoCalculo.Location = new System.Drawing.Point(11, 33);
            this.txtResultadoCalculo.Multiline = true;
            this.txtResultadoCalculo.Name = "txtResultadoCalculo";
            this.txtResultadoCalculo.ReadOnly = true;
            this.txtResultadoCalculo.Size = new System.Drawing.Size(407, 316);
            this.txtResultadoCalculo.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(338, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalarioMinimo.Location = new System.Drawing.Point(92, 6);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(240, 20);
            this.txtSalarioMinimo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Salário Mínimo";
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(77, 387);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(345, 20);
            this.txtURL.TabIndex = 13;
            this.txtURL.Text = "https://localhost:44334";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "URL Base";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TabPrincipal);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "FormPrincipal";
            this.Text = "Calculo IR";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.TabPrincipal.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDependentes)).EndInit();
            this.tabCalculo.ResumeLayout(false);
            this.tabCalculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabPrincipal;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCalculo;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRendaMensal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown numDependentes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtResultadoCalculo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label5;
    }
}

