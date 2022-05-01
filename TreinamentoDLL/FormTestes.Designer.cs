
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
            this.groupBoxNFe.Location = new System.Drawing.Point(13, 13);
            this.groupBoxNFe.Name = "groupBoxNFe";
            this.groupBoxNFe.Size = new System.Drawing.Size(301, 309);
            this.groupBoxNFe.TabIndex = 2;
            this.groupBoxNFe.TabStop = false;
            this.groupBoxNFe.Text = "NFe";
            // 
            // FormTestes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxNFe);
            this.Name = "FormTestes";
            this.Text = "Form Testes";
            this.Load += new System.EventHandler(this.FormTestes_Load);
            this.groupBoxNFe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaStatusNFe;
        private System.Windows.Forms.Button btnConsultaSituacao;
        private System.Windows.Forms.GroupBox groupBoxNFe;
    }
}

