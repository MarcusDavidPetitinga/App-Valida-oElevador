
namespace ValidacaoElevador.Forms
{
    partial class FormConsultarElevCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarElevCad));
            this.RBConsultList = new System.Windows.Forms.RadioButton();
            this.RBConsulNSerie = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textConsultaNSerie = new System.Windows.Forms.TextBox();
            this.btnconsultElevCadVoltar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RBConsultList
            // 
            this.RBConsultList.AutoSize = true;
            this.RBConsultList.Location = new System.Drawing.Point(35, 23);
            this.RBConsultList.Name = "RBConsultList";
            this.RBConsultList.Size = new System.Drawing.Size(100, 19);
            this.RBConsultList.TabIndex = 1;
            this.RBConsultList.TabStop = true;
            this.RBConsultList.Text = "Consultar lista";
            this.RBConsultList.UseVisualStyleBackColor = true;
            this.RBConsultList.CheckedChanged += new System.EventHandler(this.RBConsultList_CheckedChanged);
            // 
            // RBConsulNSerie
            // 
            this.RBConsulNSerie.AutoSize = true;
            this.RBConsulNSerie.Location = new System.Drawing.Point(35, 48);
            this.RBConsulNSerie.Name = "RBConsulNSerie";
            this.RBConsulNSerie.Size = new System.Drawing.Size(185, 19);
            this.RBConsulNSerie.TabIndex = 2;
            this.RBConsulNSerie.TabStop = true;
            this.RBConsulNSerie.Text = "Consultar por número de série";
            this.RBConsulNSerie.UseVisualStyleBackColor = true;
            this.RBConsulNSerie.CheckedChanged += new System.EventHandler(this.RBConsulNSerie_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(584, 125);
            this.dataGridView1.TabIndex = 3;
            // 
            // textConsultaNSerie
            // 
            this.textConsultaNSerie.Location = new System.Drawing.Point(226, 48);
            this.textConsultaNSerie.Name = "textConsultaNSerie";
            this.textConsultaNSerie.Size = new System.Drawing.Size(201, 23);
            this.textConsultaNSerie.TabIndex = 4;
            // 
            // btnconsultElevCadVoltar
            // 
            this.btnconsultElevCadVoltar.Location = new System.Drawing.Point(12, 242);
            this.btnconsultElevCadVoltar.Name = "btnconsultElevCadVoltar";
            this.btnconsultElevCadVoltar.Size = new System.Drawing.Size(102, 31);
            this.btnconsultElevCadVoltar.TabIndex = 5;
            this.btnconsultElevCadVoltar.Text = "Voltar";
            this.btnconsultElevCadVoltar.UseVisualStyleBackColor = true;
            this.btnconsultElevCadVoltar.Click += new System.EventHandler(this.btnconsultElevCadVoltar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(245, 240);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(132, 33);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormConsultarElevCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnconsultElevCadVoltar);
            this.Controls.Add(this.textConsultaNSerie);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RBConsulNSerie);
            this.Controls.Add(this.RBConsultList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultarElevCad";
            this.Text = "Validação elevador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RBConsultList;
        private System.Windows.Forms.RadioButton RBConsulNSerie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textConsultaNSerie;
        private System.Windows.Forms.Button btnconsultElevCadVoltar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
    }
}