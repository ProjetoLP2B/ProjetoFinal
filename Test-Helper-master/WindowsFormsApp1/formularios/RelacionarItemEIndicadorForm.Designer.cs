namespace WindowsFormsApp1
{
    partial class RelacionarItemEIndicadorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelacionarItemEIndicadorForm));
            this.dtgIndicadores = new System.Windows.Forms.DataGridView();
            this.dtgItens = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionarRelacao = new System.Windows.Forms.Button();
            this.lblNovaRelItemInd = new System.Windows.Forms.Label();
            this.txtObervacao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIndicadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgIndicadores
            // 
            this.dtgIndicadores.AllowUserToAddRows = false;
            this.dtgIndicadores.AllowUserToDeleteRows = false;
            this.dtgIndicadores.AllowUserToResizeColumns = false;
            this.dtgIndicadores.AllowUserToResizeRows = false;
            this.dtgIndicadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgIndicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIndicadores.Location = new System.Drawing.Point(444, 184);
            this.dtgIndicadores.MultiSelect = false;
            this.dtgIndicadores.Name = "dtgIndicadores";
            this.dtgIndicadores.ReadOnly = true;
            this.dtgIndicadores.Size = new System.Drawing.Size(357, 125);
            this.dtgIndicadores.TabIndex = 43;
            // 
            // dtgItens
            // 
            this.dtgItens.AllowUserToAddRows = false;
            this.dtgItens.AllowUserToDeleteRows = false;
            this.dtgItens.AllowUserToResizeColumns = false;
            this.dtgItens.AllowUserToResizeRows = false;
            this.dtgItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItens.Location = new System.Drawing.Point(28, 184);
            this.dtgItens.MultiSelect = false;
            this.dtgItens.Name = "dtgItens";
            this.dtgItens.ReadOnly = true;
            this.dtgItens.Size = new System.Drawing.Size(355, 125);
            this.dtgItens.TabIndex = 42;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(43, 37);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(312, 20);
            this.txtId.TabIndex = 41;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(472, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(295, 20);
            this.txtNome.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(28, 363);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(355, 81);
            this.txtDescricao.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(579, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Indicadores:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Itens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 33);
            this.label3.TabIndex = 35;
            this.label3.Text = "Item Indicador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(643, 470);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 33);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionarRelacao
            // 
            this.btnAdicionarRelacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarRelacao.Location = new System.Drawing.Point(462, 470);
            this.btnAdicionarRelacao.Name = "btnAdicionarRelacao";
            this.btnAdicionarRelacao.Size = new System.Drawing.Size(158, 33);
            this.btnAdicionarRelacao.TabIndex = 31;
            this.btnAdicionarRelacao.Text = "Confirmar";
            this.btnAdicionarRelacao.UseVisualStyleBackColor = true;
            this.btnAdicionarRelacao.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblNovaRelItemInd
            // 
            this.lblNovaRelItemInd.AutoSize = true;
            this.lblNovaRelItemInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaRelItemInd.Location = new System.Drawing.Point(441, 342);
            this.lblNovaRelItemInd.Name = "lblNovaRelItemInd";
            this.lblNovaRelItemInd.Size = new System.Drawing.Size(93, 18);
            this.lblNovaRelItemInd.TabIndex = 30;
            this.lblNovaRelItemInd.Text = "Observação:";
            // 
            // txtObervacao
            // 
            this.txtObervacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObervacao.Location = new System.Drawing.Point(444, 363);
            this.txtObervacao.Multiline = true;
            this.txtObervacao.Name = "txtObervacao";
            this.txtObervacao.Size = new System.Drawing.Size(357, 81);
            this.txtObervacao.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(28, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 89);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // RelacionarItemEIndicadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(829, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgIndicadores);
            this.Controls.Add(this.dtgItens);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionarRelacao);
            this.Controls.Add(this.lblNovaRelItemInd);
            this.Controls.Add(this.txtObervacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelacionarItemEIndicadorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Indicador";
            this.Load += new System.EventHandler(this.RelacionarItemEIndicadorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIndicadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgIndicadores;
        private System.Windows.Forms.DataGridView dtgItens;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionarRelacao;
        private System.Windows.Forms.Label lblNovaRelItemInd;
        private System.Windows.Forms.TextBox txtObervacao;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}