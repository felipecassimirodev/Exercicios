
namespace PrimeiroProjeto
{
    partial class frm_produtos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.CB_categoria = new System.Windows.Forms.ComboBox();
            this.BT_novo = new System.Windows.Forms.Button();
            this.Bt_excluir = new System.Windows.Forms.Button();
            this.Bt_cadastrar = new System.Windows.Forms.Button();
            this.BT_cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(76, 19);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(100, 23);
            this.txt_descricao.TabIndex = 1;
            this.txt_descricao.TextChanged += new System.EventHandler(this.txt_descricao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "categoria";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(319, 19);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 23);
            this.txt_valor.TabIndex = 4;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            // 
            // CB_categoria
            // 
            this.CB_categoria.FormattingEnabled = true;
            this.CB_categoria.Location = new System.Drawing.Point(590, 22);
            this.CB_categoria.Name = "CB_categoria";
            this.CB_categoria.Size = new System.Drawing.Size(121, 23);
            this.CB_categoria.TabIndex = 6;
            // 
            // BT_novo
            // 
            this.BT_novo.Location = new System.Drawing.Point(113, 191);
            this.BT_novo.Name = "BT_novo";
            this.BT_novo.Size = new System.Drawing.Size(75, 23);
            this.BT_novo.TabIndex = 7;
            this.BT_novo.Text = "novo";
            this.BT_novo.UseVisualStyleBackColor = true;
            // 
            // Bt_excluir
            // 
            this.Bt_excluir.Location = new System.Drawing.Point(424, 191);
            this.Bt_excluir.Name = "Bt_excluir";
            this.Bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.Bt_excluir.TabIndex = 8;
            this.Bt_excluir.Text = "excluir";
            this.Bt_excluir.UseVisualStyleBackColor = true;
            // 
            // Bt_cadastrar
            // 
            this.Bt_cadastrar.Location = new System.Drawing.Point(280, 191);
            this.Bt_cadastrar.Name = "Bt_cadastrar";
            this.Bt_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Bt_cadastrar.TabIndex = 9;
            this.Bt_cadastrar.Text = "cadastar";
            this.Bt_cadastrar.UseVisualStyleBackColor = true;
            // 
            // BT_cancelar
            // 
            this.BT_cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BT_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_cancelar.Location = new System.Drawing.Point(558, 191);
            this.BT_cancelar.Name = "BT_cancelar";
            this.BT_cancelar.Size = new System.Drawing.Size(75, 23);
            this.BT_cancelar.TabIndex = 10;
            this.BT_cancelar.Text = "cancelar";
            this.BT_cancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // frm_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BT_cancelar);
            this.Controls.Add(this.Bt_cadastrar);
            this.Controls.Add(this.Bt_excluir);
            this.Controls.Add(this.BT_novo);
            this.Controls.Add(this.CB_categoria);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label1);
            this.Name = "frm_produtos";
            this.Text = "produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox CB_categoria;
        private System.Windows.Forms.Button BT_novo;
        private System.Windows.Forms.Button Bt_excluir;
        private System.Windows.Forms.Button Bt_cadastrar;
        private System.Windows.Forms.Button BT_cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}