namespace WindowsFormsApp1
{
    partial class InserirIndicador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirIndicador));
            this.btnCancelarIndicador = new System.Windows.Forms.Button();
            this.btnConfirmarIndicador = new System.Windows.Forms.Button();
            this.txtObservacaoIndicador = new System.Windows.Forms.TextBox();
            this.txtDescricaoIndicador = new System.Windows.Forms.TextBox();
            this.txtNomeIndicador = new System.Windows.Forms.TextBox();
            this.txtIdIndicador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarIndicador
            // 
            this.btnCancelarIndicador.Location = new System.Drawing.Point(306, 406);
            this.btnCancelarIndicador.Name = "btnCancelarIndicador";
            this.btnCancelarIndicador.Size = new System.Drawing.Size(75, 33);
            this.btnCancelarIndicador.TabIndex = 21;
            this.btnCancelarIndicador.Text = "Cancelar";
            this.btnCancelarIndicador.UseVisualStyleBackColor = true;
            this.btnCancelarIndicador.Click += new System.EventHandler(this.btnCancelarIndicador_Click);
            // 
            // btnConfirmarIndicador
            // 
            this.btnConfirmarIndicador.Location = new System.Drawing.Point(203, 406);
            this.btnConfirmarIndicador.Name = "btnConfirmarIndicador";
            this.btnConfirmarIndicador.Size = new System.Drawing.Size(75, 33);
            this.btnConfirmarIndicador.TabIndex = 20;
            this.btnConfirmarIndicador.Text = "Confirmar";
            this.btnConfirmarIndicador.UseVisualStyleBackColor = true;
            this.btnConfirmarIndicador.Click += new System.EventHandler(this.btnConfirmarIndicador_Click);
            // 
            // txtObservacaoIndicador
            // 
            this.txtObservacaoIndicador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacaoIndicador.Location = new System.Drawing.Point(20, 157);
            this.txtObservacaoIndicador.Multiline = true;
            this.txtObservacaoIndicador.Name = "txtObservacaoIndicador";
            this.txtObservacaoIndicador.Size = new System.Drawing.Size(359, 98);
            this.txtObservacaoIndicador.TabIndex = 19;
            // 
            // txtDescricaoIndicador
            // 
            this.txtDescricaoIndicador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoIndicador.Location = new System.Drawing.Point(20, 290);
            this.txtDescricaoIndicador.Multiline = true;
            this.txtDescricaoIndicador.Name = "txtDescricaoIndicador";
            this.txtDescricaoIndicador.Size = new System.Drawing.Size(359, 98);
            this.txtDescricaoIndicador.TabIndex = 18;
            // 
            // txtNomeIndicador
            // 
            this.txtNomeIndicador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeIndicador.Location = new System.Drawing.Point(73, 96);
            this.txtNomeIndicador.Name = "txtNomeIndicador";
            this.txtNomeIndicador.Size = new System.Drawing.Size(306, 20);
            this.txtNomeIndicador.TabIndex = 17;
            // 
            // txtIdIndicador
            // 
            this.txtIdIndicador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIdIndicador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdIndicador.Location = new System.Drawing.Point(73, 64);
            this.txtIdIndicador.Name = "txtIdIndicador";
            this.txtIdIndicador.ReadOnly = true;
            this.txtIdIndicador.Size = new System.Drawing.Size(306, 20);
            this.txtIdIndicador.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Observação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Inserir Indicador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InserirIndicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(405, 448);
            this.Controls.Add(this.btnCancelarIndicador);
            this.Controls.Add(this.btnConfirmarIndicador);
            this.Controls.Add(this.txtObservacaoIndicador);
            this.Controls.Add(this.txtDescricaoIndicador);
            this.Controls.Add(this.txtNomeIndicador);
            this.Controls.Add(this.txtIdIndicador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InserirIndicador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indicador";
            this.Load += new System.EventHandler(this.InserirIndicador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarIndicador;
        private System.Windows.Forms.Button btnConfirmarIndicador;
        private System.Windows.Forms.TextBox txtObservacaoIndicador;
        private System.Windows.Forms.TextBox txtDescricaoIndicador;
        private System.Windows.Forms.TextBox txtNomeIndicador;
        private System.Windows.Forms.TextBox txtIdIndicador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}