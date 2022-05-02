
namespace TreinamentoDLL
{
    partial class FormTestes
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
            this.btnConsultaStatusNFe = new System.Windows.Forms.Button();
            this.btnConsultaSituacao = new System.Windows.Forms.Button();
            this.groupBoxNFe = new System.Windows.Forms.GroupBox();
            this.textBoxArqCert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSenhaCert = new System.Windows.Forms.TextBox();
            this.textBox_resultado = new System.Windows.Forms.TextBox();
            this.groupBoxNFe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultaStatusNFe
            // 
            this.btnConsultaStatusNFe.Location = new System.Drawing.Point(6, 21);
            this.btnConsultaStatusNFe.Name = "btnConsultaStatusNFe";
            this.btnConsultaStatusNFe.Size = new System.Drawing.Size(169, 23);
            this.btnConsultaStatusNFe.TabIndex = 0;
            this.btnConsultaStatusNFe.Text = "Consulta Status";
            this.btnConsultaStatusNFe.UseVisualStyleBackColor = true;
            this.btnConsultaStatusNFe.Click += new System.EventHandler(this.btnConsultaStatusNFe_Click);
            // 
            // btnConsultaSituacao
            // 
            this.btnConsultaSituacao.Location = new System.Drawing.Point(6, 50);
            this.btnConsultaSituacao.Name = "btnConsultaSituacao";
            this.btnConsultaSituacao.Size = new System.Drawing.Size(169, 23);
            this.btnConsultaSituacao.TabIndex = 1;
            this.btnConsultaSituacao.Text = "Consulta Situação";
            this.btnConsultaSituacao.UseVisualStyleBackColor = true;
            this.btnConsultaSituacao.Click += new System.EventHandler(this.btnConsultaSituacao_Click);
            // 
            // groupBoxNFe
            // 
            this.groupBoxNFe.Controls.Add(this.btnConsultaStatusNFe);
            this.groupBoxNFe.Controls.Add(this.btnConsultaSituacao);
            this.groupBoxNFe.Location = new System.Drawing.Point(12, 59);
            this.groupBoxNFe.Name = "groupBoxNFe";
            this.groupBoxNFe.Size = new System.Drawing.Size(301, 309);
            this.groupBoxNFe.TabIndex = 2;
            this.groupBoxNFe.TabStop = false;
            this.groupBoxNFe.Text = "NFe";
            // 
            // textBoxArqCert
            // 
            this.textBoxArqCert.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxArqCert.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBoxArqCert.Location = new System.Drawing.Point(13, 30);
            this.textBoxArqCert.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArqCert.Name = "textBoxArqCert";
            this.textBoxArqCert.Size = new System.Drawing.Size(943, 22);
            this.textBoxArqCert.TabIndex = 20;
            this.textBoxArqCert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxArqCert_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Arquivo do Certificado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(965, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Senha do Certificado";
            // 
            // textBoxSenhaCert
            // 
            this.textBoxSenhaCert.Location = new System.Drawing.Point(965, 30);
            this.textBoxSenhaCert.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSenhaCert.Name = "textBoxSenhaCert";
            this.textBoxSenhaCert.Size = new System.Drawing.Size(308, 22);
            this.textBoxSenhaCert.TabIndex = 22;
            this.textBoxSenhaCert.UseSystemPasswordChar = true;
            this.textBoxSenhaCert.TextChanged += new System.EventHandler(this.textBoxSenhaCert_TextChanged);
            // 
            // textBox_resultado
            // 
            this.textBox_resultado.Location = new System.Drawing.Point(12, 403);
            this.textBox_resultado.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_resultado.Multiline = true;
            this.textBox_resultado.Name = "textBox_resultado";
            this.textBox_resultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_resultado.Size = new System.Drawing.Size(1261, 237);
            this.textBox_resultado.TabIndex = 24;
            // 
            // FormTestes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.textBox_resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSenhaCert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxArqCert);
            this.Controls.Add(this.groupBoxNFe);
            this.Name = "FormTestes";
            this.Text = "Form Testes";
            this.Load += new System.EventHandler(this.FormTestes_Load);
            this.groupBoxNFe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaStatusNFe;
        private System.Windows.Forms.Button btnConsultaSituacao;
        private System.Windows.Forms.GroupBox groupBoxNFe;
        private System.Windows.Forms.TextBox textBoxArqCert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSenhaCert;
        private System.Windows.Forms.TextBox textBox_resultado;
    }
}

