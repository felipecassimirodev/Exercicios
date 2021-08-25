
namespace PrimeiroProjeto
{
    partial class frm_categotia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BT_cancelar = new System.Windows.Forms.Button();
            this.Bt_cadastrar = new System.Windows.Forms.Button();
            this.Bt_excluir = new System.Windows.Forms.Button();
            this.BT_novo = new System.Windows.Forms.Button();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(685, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // BT_cancelar
            // 
            this.BT_cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BT_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_cancelar.Location = new System.Drawing.Point(563, 125);
            this.BT_cancelar.Name = "BT_cancelar";
            this.BT_cancelar.Size = new System.Drawing.Size(75, 23);
            this.BT_cancelar.TabIndex = 21;
            this.BT_cancelar.Text = "cancelar";
            this.BT_cancelar.UseVisualStyleBackColor = true;
            // 
            // Bt_cadastrar
            // 
            this.Bt_cadastrar.Location = new System.Drawing.Point(287, 125);
            this.Bt_cadastrar.Name = "Bt_cadastrar";
            this.Bt_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Bt_cadastrar.TabIndex = 20;
            this.Bt_cadastrar.Text = "cadastar";
            this.Bt_cadastrar.UseVisualStyleBackColor = true;
            // 
            // Bt_excluir
            // 
            this.Bt_excluir.Location = new System.Drawing.Point(423, 125);
            this.Bt_excluir.Name = "Bt_excluir";
            this.Bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.Bt_excluir.TabIndex = 19;
            this.Bt_excluir.Text = "excluir";
            this.Bt_excluir.UseVisualStyleBackColor = true;
            // 
            // BT_novo
            // 
            this.BT_novo.Location = new System.Drawing.Point(138, 125);
            this.BT_novo.Name = "BT_novo";
            this.BT_novo.Size = new System.Drawing.Size(75, 23);
            this.BT_novo.TabIndex = 18;
            this.BT_novo.Text = "novo";
            this.BT_novo.UseVisualStyleBackColor = true;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(363, 41);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(100, 23);
            this.txt_descricao.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Categoria";
            // 
            // frm_categotia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BT_cancelar);
            this.Controls.Add(this.Bt_cadastrar);
            this.Controls.Add(this.Bt_excluir);
            this.Controls.Add(this.BT_novo);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label1);
            this.Name = "frm_categotia";
            this.Text = "categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BT_cancelar;
        private System.Windows.Forms.Button Bt_cadastrar;
        private System.Windows.Forms.Button Bt_excluir;
        private System.Windows.Forms.Button BT_novo;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label1;
    }
}