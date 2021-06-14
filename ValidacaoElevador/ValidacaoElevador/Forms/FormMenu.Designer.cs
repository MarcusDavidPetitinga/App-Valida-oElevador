
namespace ValidacaoElevador.Forms
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.MenuRBCadastrar = new System.Windows.Forms.RadioButton();
            this.MenuRBSair = new System.Windows.Forms.RadioButton();
            this.RBListElevCadast = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuSeguir = new System.Windows.Forms.Button();
            this.RBTesteCargaVel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // MenuRBCadastrar
            // 
            this.MenuRBCadastrar.AutoSize = true;
            this.MenuRBCadastrar.Location = new System.Drawing.Point(35, 80);
            this.MenuRBCadastrar.Name = "MenuRBCadastrar";
            this.MenuRBCadastrar.Size = new System.Drawing.Size(123, 19);
            this.MenuRBCadastrar.TabIndex = 1;
            this.MenuRBCadastrar.TabStop = true;
            this.MenuRBCadastrar.Text = "Cadastrar Elevador";
            this.MenuRBCadastrar.UseVisualStyleBackColor = true;
            this.MenuRBCadastrar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // MenuRBSair
            // 
            this.MenuRBSair.AutoSize = true;
            this.MenuRBSair.Location = new System.Drawing.Point(35, 130);
            this.MenuRBSair.Name = "MenuRBSair";
            this.MenuRBSair.Size = new System.Drawing.Size(44, 19);
            this.MenuRBSair.TabIndex = 2;
            this.MenuRBSair.TabStop = true;
            this.MenuRBSair.Text = "Sair";
            this.MenuRBSair.UseVisualStyleBackColor = true;
            this.MenuRBSair.CheckedChanged += new System.EventHandler(this.MenuRBSair_CheckedChanged);
            // 
            // RBListElevCadast
            // 
            this.RBListElevCadast.AutoSize = true;
            this.RBListElevCadast.Location = new System.Drawing.Point(35, 55);
            this.RBListElevCadast.Name = "RBListElevCadast";
            this.RBListElevCadast.Size = new System.Drawing.Size(178, 19);
            this.RBListElevCadast.TabIndex = 3;
            this.RBListElevCadast.TabStop = true;
            this.RBListElevCadast.Text = "Listar elevadores cadastrados";
            this.RBListElevCadast.UseVisualStyleBackColor = true;
            this.RBListElevCadast.CheckedChanged += new System.EventHandler(this.RBListElevCadast_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu";
            // 
            // btnMenuSeguir
            // 
            this.btnMenuSeguir.Location = new System.Drawing.Point(92, 167);
            this.btnMenuSeguir.Name = "btnMenuSeguir";
            this.btnMenuSeguir.Size = new System.Drawing.Size(75, 23);
            this.btnMenuSeguir.TabIndex = 5;
            this.btnMenuSeguir.Text = "Seguir";
            this.btnMenuSeguir.UseVisualStyleBackColor = true;
            this.btnMenuSeguir.Click += new System.EventHandler(this.btnMenuSeguir_Click_1);
            // 
            // RBTesteCargaVel
            // 
            this.RBTesteCargaVel.AutoSize = true;
            this.RBTesteCargaVel.Location = new System.Drawing.Point(35, 105);
            this.RBTesteCargaVel.Name = "RBTesteCargaVel";
            this.RBTesteCargaVel.Size = new System.Drawing.Size(103, 19);
            this.RBTesteCargaVel.TabIndex = 6;
            this.RBTesteCargaVel.TabStop = true;
            this.RBTesteCargaVel.Text = "Testar Elevador";
            this.RBTesteCargaVel.UseVisualStyleBackColor = true;
            this.RBTesteCargaVel.CheckedChanged += new System.EventHandler(this.RBTesteCargaVel_CheckedChanged);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 221);
            this.Controls.Add(this.RBTesteCargaVel);
            this.Controls.Add(this.MenuRBCadastrar);
            this.Controls.Add(this.MenuRBSair);
            this.Controls.Add(this.RBListElevCadast);
            this.Controls.Add(this.btnMenuSeguir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Validação elevador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton MenuRBCadastrar;
        private System.Windows.Forms.RadioButton MenuRBSair;
        private System.Windows.Forms.RadioButton RBListElevCadast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuSeguir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBTesteCargaVel;
    }
}