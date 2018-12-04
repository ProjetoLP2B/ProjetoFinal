namespace WindowsFormsApp1
{
    partial class InserirItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirItem));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdItem = new System.Windows.Forms.TextBox();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.txtDescricaoItem = new System.Windows.Forms.TextBox();
            this.txtObservacaoItem = new System.Windows.Forms.TextBox();
            this.btnConfirmarItem = new System.Windows.Forms.Button();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserir item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Observação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descrição:";
            // 
            // txtIdItem
            // 
            this.txtIdItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIdItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdItem.Location = new System.Drawing.Point(66, 61);
            this.txtIdItem.Name = "txtIdItem";
            this.txtIdItem.ReadOnly = true;
            this.txtIdItem.Size = new System.Drawing.Size(311, 20);
            this.txtIdItem.TabIndex = 5;
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeItem.Location = new System.Drawing.Point(66, 94);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(311, 20);
            this.txtNomeItem.TabIndex = 6;
            // 
            // txtDescricaoItem
            // 
            this.txtDescricaoItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoItem.Location = new System.Drawing.Point(18, 291);
            this.txtDescricaoItem.Multiline = true;
            this.txtDescricaoItem.Name = "txtDescricaoItem";
            this.txtDescricaoItem.Size = new System.Drawing.Size(359, 98);
            this.txtDescricaoItem.TabIndex = 7;
            // 
            // txtObservacaoItem
            // 
            this.txtObservacaoItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacaoItem.Location = new System.Drawing.Point(18, 155);
            this.txtObservacaoItem.Multiline = true;
            this.txtObservacaoItem.Name = "txtObservacaoItem";
            this.txtObservacaoItem.Size = new System.Drawing.Size(359, 98);
            this.txtObservacaoItem.TabIndex = 8;
            // 
            // btnConfirmarItem
            // 
            this.btnConfirmarItem.Location = new System.Drawing.Point(190, 402);
            this.btnConfirmarItem.Name = "btnConfirmarItem";
            this.btnConfirmarItem.Size = new System.Drawing.Size(81, 34);
            this.btnConfirmarItem.TabIndex = 9;
            this.btnConfirmarItem.Text = "Confirmar";
            this.btnConfirmarItem.UseVisualStyleBackColor = true;
            this.btnConfirmarItem.Click += new System.EventHandler(this.btnConfirmarItem_Click);
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.Location = new System.Drawing.Point(297, 402);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(81, 34);
            this.btnCancelarItem.TabIndex = 10;
            this.btnCancelarItem.Text = "Cancelar";
            this.btnCancelarItem.UseVisualStyleBackColor = true;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // InserirItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(405, 448);
            this.Controls.Add(this.btnCancelarItem);
            this.Controls.Add(this.btnConfirmarItem);
            this.Controls.Add(this.txtObservacaoItem);
            this.Controls.Add(this.txtDescricaoItem);
            this.Controls.Add(this.txtNomeItem);
            this.Controls.Add(this.txtIdItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InserirItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.InserirItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdItem;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.TextBox txtDescricaoItem;
        private System.Windows.Forms.TextBox txtObservacaoItem;
        private System.Windows.Forms.Button btnConfirmarItem;
        private System.Windows.Forms.Button btnCancelarItem;
    }
}