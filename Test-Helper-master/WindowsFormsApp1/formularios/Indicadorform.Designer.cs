namespace WindowsFormsApp1
{
    partial class Indicadorform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indicadorform));
            this.btnDeletarIndicador = new System.Windows.Forms.Button();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.btnAlterarIndicador = new System.Windows.Forms.Button();
            this.btnInserirIndicador = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnexibir = new System.Windows.Forms.Button();
            this.cbxPesquisar = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletarIndicador
            // 
            this.btnDeletarIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarIndicador.Location = new System.Drawing.Point(539, 347);
            this.btnDeletarIndicador.Name = "btnDeletarIndicador";
            this.btnDeletarIndicador.Size = new System.Drawing.Size(83, 39);
            this.btnDeletarIndicador.TabIndex = 23;
            this.btnDeletarIndicador.Text = "Deletar";
            this.btnDeletarIndicador.UseVisualStyleBackColor = true;
            this.btnDeletarIndicador.Click += new System.EventHandler(this.btnDeletarIndicador_Click);
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenu.Location = new System.Drawing.Point(743, 347);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(83, 39);
            this.btnVoltarMenu.TabIndex = 22;
            this.btnVoltarMenu.Text = "Voltar";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnAlterarIndicador
            // 
            this.btnAlterarIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarIndicador.Location = new System.Drawing.Point(441, 347);
            this.btnAlterarIndicador.Name = "btnAlterarIndicador";
            this.btnAlterarIndicador.Size = new System.Drawing.Size(83, 39);
            this.btnAlterarIndicador.TabIndex = 21;
            this.btnAlterarIndicador.Text = "Alterar";
            this.btnAlterarIndicador.UseVisualStyleBackColor = true;
            this.btnAlterarIndicador.Click += new System.EventHandler(this.btnAlterarIndicador_Click);
            // 
            // btnInserirIndicador
            // 
            this.btnInserirIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirIndicador.Location = new System.Drawing.Point(342, 347);
            this.btnInserirIndicador.Name = "btnInserirIndicador";
            this.btnInserirIndicador.Size = new System.Drawing.Size(83, 39);
            this.btnInserirIndicador.TabIndex = 20;
            this.btnInserirIndicador.Text = "Adicionar";
            this.btnInserirIndicador.UseVisualStyleBackColor = true;
            this.btnInserirIndicador.Click += new System.EventHandler(this.btnInserirIndicador_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.AutoSize = true;
            this.Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.Location = new System.Drawing.Point(304, 12);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(211, 42);
            this.Usuarios.TabIndex = 24;
            this.Usuarios.Text = "Indicadores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 114);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(803, 224);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnexibir
            // 
            this.btnexibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexibir.Location = new System.Drawing.Point(640, 347);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(83, 39);
            this.btnexibir.TabIndex = 26;
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // cbxPesquisar
            // 
            this.cbxPesquisar.FormattingEnabled = true;
            this.cbxPesquisar.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Descrição",
            "Observação"});
            this.cbxPesquisar.Location = new System.Drawing.Point(155, 78);
            this.cbxPesquisar.Name = "cbxPesquisar";
            this.cbxPesquisar.Size = new System.Drawing.Size(121, 21);
            this.cbxPesquisar.TabIndex = 32;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(297, 80);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(527, 20);
            this.txtPesquisar.TabIndex = 31;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(21, 68);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(118, 39);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.pesquisar;
            this.pictureBox1.Location = new System.Drawing.Point(32, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Indicadorform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(846, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Usuarios);
            this.Controls.Add(this.btnDeletarIndicador);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.btnAlterarIndicador);
            this.Controls.Add(this.btnInserirIndicador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Indicadorform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indicador";
            this.Load += new System.EventHandler(this.Indicadorform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletarIndicador;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Button btnAlterarIndicador;
        private System.Windows.Forms.Button btnInserirIndicador;
        private System.Windows.Forms.Label Usuarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.ComboBox cbxPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}