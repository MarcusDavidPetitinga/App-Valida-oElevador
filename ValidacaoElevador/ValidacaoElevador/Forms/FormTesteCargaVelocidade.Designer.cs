
namespace ValidacaoElevador.Forms
{
    partial class FormTesteCargaVelocidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTesteCargaVelocidade));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textVelMax = new System.Windows.Forms.TextBox();
            this.textData = new System.Windows.Forms.TextBox();
            this.textCargaMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNSerie = new System.Windows.Forms.TextBox();
            this.textSensorBotoes = new System.Windows.Forms.TextBox();
            this.textSensorVelocidade = new System.Windows.Forms.TextBox();
            this.textSensorStop = new System.Windows.Forms.TextBox();
            this.textSensorPorta = new System.Windows.Forms.TextBox();
            this.textSensorCarga = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textAndares = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.butSair = new System.Windows.Forms.Button();
            this.caixaRelatorio = new System.Windows.Forms.RichTextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Executar teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Velocidade máxima km/h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Carga máxima  Kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data do teste";
            // 
            // textVelMax
            // 
            this.textVelMax.Location = new System.Drawing.Point(174, 90);
            this.textVelMax.Name = "textVelMax";
            this.textVelMax.Size = new System.Drawing.Size(100, 23);
            this.textVelMax.TabIndex = 5;
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(125, 12);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(150, 23);
            this.textData.TabIndex = 6;
            // 
            // textCargaMax
            // 
            this.textCargaMax.Location = new System.Drawing.Point(135, 140);
            this.textCargaMax.Name = "textCargaMax";
            this.textCargaMax.Size = new System.Drawing.Size(139, 23);
            this.textCargaMax.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número de série";
            // 
            // textNSerie
            // 
            this.textNSerie.Location = new System.Drawing.Point(414, 12);
            this.textNSerie.Name = "textNSerie";
            this.textNSerie.Size = new System.Drawing.Size(149, 23);
            this.textNSerie.TabIndex = 9;
            // 
            // textSensorBotoes
            // 
            this.textSensorBotoes.Location = new System.Drawing.Point(404, 195);
            this.textSensorBotoes.Name = "textSensorBotoes";
            this.textSensorBotoes.Size = new System.Drawing.Size(202, 23);
            this.textSensorBotoes.TabIndex = 29;
            // 
            // textSensorVelocidade
            // 
            this.textSensorVelocidade.Location = new System.Drawing.Point(425, 106);
            this.textSensorVelocidade.Name = "textSensorVelocidade";
            this.textSensorVelocidade.Size = new System.Drawing.Size(181, 23);
            this.textSensorVelocidade.TabIndex = 28;
            // 
            // textSensorStop
            // 
            this.textSensorStop.Location = new System.Drawing.Point(391, 136);
            this.textSensorStop.Name = "textSensorStop";
            this.textSensorStop.Size = new System.Drawing.Size(215, 23);
            this.textSensorStop.TabIndex = 27;
            // 
            // textSensorPorta
            // 
            this.textSensorPorta.Location = new System.Drawing.Point(391, 165);
            this.textSensorPorta.Name = "textSensorPorta";
            this.textSensorPorta.Size = new System.Drawing.Size(215, 23);
            this.textSensorPorta.TabIndex = 26;
            // 
            // textSensorCarga
            // 
            this.textSensorCarga.Location = new System.Drawing.Point(397, 78);
            this.textSensorCarga.Name = "textSensorCarga";
            this.textSensorCarga.Size = new System.Drawing.Size(209, 23);
            this.textSensorCarga.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Sensor carga";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(317, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Sensor Velocidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(317, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Sensor stop";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "Sensor porta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "Sensor botões";
            // 
            // textAndares
            // 
            this.textAndares.Location = new System.Drawing.Point(125, 190);
            this.textAndares.Name = "textAndares";
            this.textAndares.Size = new System.Drawing.Size(150, 23);
            this.textAndares.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Andares";
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(423, 253);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(172, 23);
            this.btnGerarRelatorio.TabIndex = 34;
            this.btnGerarRelatorio.Text = "Gerar relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Status";
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(246, 258);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(100, 23);
            this.textStatus.TabIndex = 38;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 587);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 39;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // butSair
            // 
            this.butSair.Location = new System.Drawing.Point(559, 587);
            this.butSair.Name = "butSair";
            this.butSair.Size = new System.Drawing.Size(170, 23);
            this.butSair.TabIndex = 40;
            this.butSair.Text = "Sair";
            this.butSair.UseVisualStyleBackColor = true;
            this.butSair.Click += new System.EventHandler(this.butSair_Click);
            // 
            // caixaRelatorio
            // 
            this.caixaRelatorio.Location = new System.Drawing.Point(12, 296);
            this.caixaRelatorio.Name = "caixaRelatorio";
            this.caixaRelatorio.Size = new System.Drawing.Size(735, 244);
            this.caixaRelatorio.TabIndex = 41;
            this.caixaRelatorio.Text = "";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(333, 587);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 42;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument;
            this.printDialog1.UseEXDialog = true;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument;
            // 
            // FormTesteCargaVelocidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 642);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.caixaRelatorio);
            this.Controls.Add(this.butSair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.textAndares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSensorBotoes);
            this.Controls.Add(this.textSensorVelocidade);
            this.Controls.Add(this.textSensorStop);
            this.Controls.Add(this.textSensorPorta);
            this.Controls.Add(this.textSensorCarga);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textNSerie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCargaMax);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.textVelMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTesteCargaVelocidade";
            this.Text = "Validação elevador -Teste ";
            this.Load += new System.EventHandler(this.FormTesteCargaVelocidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textVelMax;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.TextBox textCargaMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNSerie;
        private System.Windows.Forms.TextBox textSensorBotoes;
        private System.Windows.Forms.TextBox textSensorVelocidade;
        private System.Windows.Forms.TextBox textSensorStop;
        private System.Windows.Forms.TextBox textSensorPorta;
        private System.Windows.Forms.TextBox textSensorCarga;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textAndares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button butSair;
        private System.Windows.Forms.RichTextBox caixaRelatorio;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}