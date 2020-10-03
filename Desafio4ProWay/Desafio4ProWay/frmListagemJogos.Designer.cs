namespace Desafio4ProWay
{
    partial class frmListagemJogos
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
            this.btnAdicionarJogo = new System.Windows.Forms.Button();
            this.dgJogos = new System.Windows.Forms.DataGridView();
            this.Jogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgJogos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarJogo
            // 
            this.btnAdicionarJogo.Location = new System.Drawing.Point(581, 56);
            this.btnAdicionarJogo.Name = "btnAdicionarJogo";
            this.btnAdicionarJogo.Size = new System.Drawing.Size(137, 23);
            this.btnAdicionarJogo.TabIndex = 0;
            this.btnAdicionarJogo.Text = "Adicionar Jogo";
            this.btnAdicionarJogo.UseVisualStyleBackColor = true;
            this.btnAdicionarJogo.Click += new System.EventHandler(this.btnAdicionarJogo_Click);
            // 
            // dgJogos
            // 
            this.dgJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jogo,
            this.Placar});
            this.dgJogos.Location = new System.Drawing.Point(45, 146);
            this.dgJogos.Name = "dgJogos";
            this.dgJogos.Size = new System.Drawing.Size(706, 266);
            this.dgJogos.TabIndex = 1;
            // 
            // Jogo
            // 
            this.Jogo.DataPropertyName = "Codigo";
            this.Jogo.HeaderText = "Jogo";
            this.Jogo.Name = "Jogo";
            // 
            // Placar
            // 
            this.Placar.DataPropertyName = "Placar";
            this.Placar.HeaderText = "Placar";
            this.Placar.Name = "Placar";
            // 
            // frmListagemJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgJogos);
            this.Controls.Add(this.btnAdicionarJogo);
            this.Name = "frmListagemJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem Jogos";
            ((System.ComponentModel.ISupportInitialize)(this.dgJogos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarJogo;
        private System.Windows.Forms.DataGridView dgJogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placar;
    }
}