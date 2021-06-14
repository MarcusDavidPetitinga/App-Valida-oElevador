
namespace ValidacaoElevador.Forms
{
    partial class FormCadastrarElevador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarElevador));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButcadElevCadastrar = new System.Windows.Forms.Button();
            this.textCadElevNSerie = new System.Windows.Forms.TextBox();
            this.textCadElevAndares = new System.Windows.Forms.TextBox();
            this.textCadElevCargMax = new System.Windows.Forms.TextBox();
            this.textCadElevVelMax = new System.Windows.Forms.TextBox();
            this.ButcadElevVoltar = new System.Windows.Forms.Button();
            this.ButcadElevSair = new System.Windows.Forms.Button();
            this.ButCadElevGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar elevador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de série";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carga máxima /Kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Andares";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Velocidade máxima  m/s";
            // 
            // ButcadElevCadastrar
            // 
            this.ButcadElevCadastrar.Location = new System.Drawing.Point(143, 266);
            this.ButcadElevCadastrar.Name = "ButcadElevCadastrar";
            this.ButcadElevCadastrar.Size = new System.Drawing.Size(109, 23);
            this.ButcadElevCadastrar.TabIndex = 6;
            this.ButcadElevCadastrar.Text = "Cadastrar";
            this.ButcadElevCadastrar.UseVisualStyleBackColor = true;
            this.ButcadElevCadastrar.Click += new System.EventHandler(this.ButcadElevCadastrar_Click);
            // 
            // textCadElevNSerie
            // 
            this.textCadElevNSerie.Location = new System.Drawing.Point(200, 96);
            this.textCadElevNSerie.Name = "textCadElevNSerie";
            this.textCadElevNSerie.Size = new System.Drawing.Size(170, 23);
            this.textCadElevNSerie.TabIndex = 7;
            this.textCadElevNSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCadElevNSerie_KeyPress);
            // 
            // textCadElevAndares
            // 
            this.textCadElevAndares.Location = new System.Drawing.Point(200, 127);
            this.textCadElevAndares.Name = "textCadElevAndares";
            this.textCadElevAndares.Size = new System.Drawing.Size(100, 23);
            this.textCadElevAndares.TabIndex = 8;
            this.textCadElevAndares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCadElevAndares_KeyPress);
            // 
            // textCadElevCargMax
            // 
            this.textCadElevCargMax.Location = new System.Drawing.Point(200, 163);
            this.textCadElevCargMax.Name = "textCadElevCargMax";
            this.textCadElevCargMax.Size = new System.Drawing.Size(100, 23);
            this.textCadElevCargMax.TabIndex = 9;
            this.textCadElevCargMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCadElevCargMax_KeyPress);
            // 
            // textCadElevVelMax
            // 
            this.textCadElevVelMax.Location = new System.Drawing.Point(200, 203);
            this.textCadElevVelMax.Name = "textCadElevVelMax";
            this.textCadElevVelMax.Size = new System.Drawing.Size(100, 23);
            this.textCadElevVelMax.TabIndex = 10;
            this.textCadElevVelMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCadElevVelMax_KeyPress);
            // 
            // ButcadElevVoltar
            // 
            this.ButcadElevVoltar.Location = new System.Drawing.Point(40, 266);
            this.ButcadElevVoltar.Name = "ButcadElevVoltar";
            this.ButcadElevVoltar.Size = new System.Drawing.Size(67, 23);
            this.ButcadElevVoltar.TabIndex = 11;
            this.ButcadElevVoltar.Text = "Voltar";
            this.ButcadElevVoltar.UseVisualStyleBackColor = true;
            this.ButcadElevVoltar.Click += new System.EventHandler(this.ButcadElevVoltar_Click);
            // 
            // ButcadElevSair
            // 
            this.ButcadElevSair.Location = new System.Drawing.Point(286, 266);
            this.ButcadElevSair.Name = "ButcadElevSair";
            this.ButcadElevSair.Size = new System.Drawing.Size(66, 23);
            this.ButcadElevSair.TabIndex = 12;
            this.ButcadElevSair.Text = "Sair";
            this.ButcadElevSair.UseVisualStyleBackColor = true;
            this.ButcadElevSair.Click += new System.EventHandler(this.ButcadElevSair_Click);
            // 
            // ButCadElevGerar
            // 
            this.ButCadElevGerar.Location = new System.Drawing.Point(376, 96);
            this.ButCadElevGerar.Name = "ButCadElevGerar";
            this.ButCadElevGerar.Size = new System.Drawing.Size(55, 23);
            this.ButCadElevGerar.TabIndex = 13;
            this.ButCadElevGerar.Text = "Gerar";
            this.ButCadElevGerar.UseVisualStyleBackColor = true;
            this.ButCadElevGerar.Click += new System.EventHandler(this.ButCadElevGerar_Click);
            // 
            // FormCadastrarElevador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 332);
            this.Controls.Add(this.ButCadElevGerar);
            this.Controls.Add(this.ButcadElevSair);
            this.Controls.Add(this.ButcadElevVoltar);
            this.Controls.Add(this.textCadElevVelMax);
            this.Controls.Add(this.textCadElevCargMax);
            this.Controls.Add(this.textCadElevAndares);
            this.Controls.Add(this.textCadElevNSerie);
            this.Controls.Add(this.ButcadElevCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastrarElevador";
            this.Text = "Validação elevador";
            this.Load += new System.EventHandler(this.FormCadastrarElevador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButcadElevCadastrar;
        private System.Windows.Forms.TextBox textCadElevNSerie;
        private System.Windows.Forms.TextBox textCadElevAndares;
        private System.Windows.Forms.TextBox textCadElevCargMax;
        private System.Windows.Forms.TextBox textCadElevVelMax;
        private System.Windows.Forms.Button ButcadElevVoltar;
        private System.Windows.Forms.Button ButcadElevSair;
        private System.Windows.Forms.Button ButCadElevGerar;
    }
}