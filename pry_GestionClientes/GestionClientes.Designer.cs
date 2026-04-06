namespace pry_GestionClientes
{
    partial class GestionClientes
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
            this.grbCargarDatos = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.grbConsultadeDATOS = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimitedeCrédito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotaldeDeuda = new System.Windows.Forms.Label();
            this.txtTotaldeDeuda = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.grbCargarDatos.SuspendLayout();
            this.grbConsultadeDATOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCargarDatos
            // 
            this.grbCargarDatos.Controls.Add(this.btnCargar);
            this.grbCargarDatos.Controls.Add(this.txtLimite);
            this.grbCargarDatos.Controls.Add(this.txtUsuario);
            this.grbCargarDatos.Controls.Add(this.lblLimite);
            this.grbCargarDatos.Controls.Add(this.lblUsuario);
            this.grbCargarDatos.Controls.Add(this.txtDeuda);
            this.grbCargarDatos.Controls.Add(this.txtCodigo);
            this.grbCargarDatos.Controls.Add(this.lblDeuda);
            this.grbCargarDatos.Controls.Add(this.lblCodigo);
            this.grbCargarDatos.Location = new System.Drawing.Point(24, 30);
            this.grbCargarDatos.Name = "grbCargarDatos";
            this.grbCargarDatos.Size = new System.Drawing.Size(495, 179);
            this.grbCargarDatos.TabIndex = 0;
            this.grbCargarDatos.TabStop = false;
            this.grbCargarDatos.Text = "Cargar Datos";
            this.grbCargarDatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCodigo.Location = new System.Drawing.Point(17, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDeuda.Location = new System.Drawing.Point(17, 93);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(42, 13);
            this.lblDeuda.TabIndex = 1;
            this.lblDeuda.Text = "Deuda:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(66, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(65, 89);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(100, 20);
            this.txtDeuda.TabIndex = 3;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(333, 89);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 20);
            this.txtLimite.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(334, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(285, 93);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(34, 13);
            this.lblLimite.TabIndex = 5;
            this.lblLimite.Text = "Limite";
            this.lblLimite.Click += new System.EventHandler(this.lblLimite_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(285, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(316, 134);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(117, 26);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // grbConsultadeDATOS
            // 
            this.grbConsultadeDATOS.Controls.Add(this.dataGridView1);
            this.grbConsultadeDATOS.Location = new System.Drawing.Point(24, 228);
            this.grbConsultadeDATOS.Name = "grbConsultadeDATOS";
            this.grbConsultadeDATOS.Size = new System.Drawing.Size(495, 191);
            this.grbConsultadeDATOS.TabIndex = 9;
            this.grbConsultadeDATOS.TabStop = false;
            this.grbConsultadeDATOS.Text = "Consulta de Datos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Usuario,
            this.LimitedeCrédito,
            this.Deuda});
            this.dataGridView1.Location = new System.Drawing.Point(20, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // LimitedeCrédito
            // 
            this.LimitedeCrédito.HeaderText = "Limite de Crédito";
            this.LimitedeCrédito.Name = "LimitedeCrédito";
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            // 
            // lblTotaldeDeuda
            // 
            this.lblTotaldeDeuda.AutoSize = true;
            this.lblTotaldeDeuda.Location = new System.Drawing.Point(322, 447);
            this.lblTotaldeDeuda.Name = "lblTotaldeDeuda";
            this.lblTotaldeDeuda.Size = new System.Drawing.Size(81, 13);
            this.lblTotaldeDeuda.TabIndex = 9;
            this.lblTotaldeDeuda.Text = "Total de Deuda";
            // 
            // txtTotaldeDeuda
            // 
            this.txtTotaldeDeuda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotaldeDeuda.Location = new System.Drawing.Point(419, 447);
            this.txtTotaldeDeuda.Name = "txtTotaldeDeuda";
            this.txtTotaldeDeuda.Size = new System.Drawing.Size(117, 13);
            this.txtTotaldeDeuda.TabIndex = 10;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(419, 479);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(117, 26);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtTotaldeDeuda);
            this.Controls.Add(this.lblTotaldeDeuda);
            this.Controls.Add(this.grbConsultadeDATOS);
            this.Controls.Add(this.grbCargarDatos);
            this.Name = "GestionClientes";
            this.Text = "GestionClientes";
            this.Load += new System.EventHandler(this.GestionClientes_Load);
            this.grbCargarDatos.ResumeLayout(false);
            this.grbCargarDatos.PerformLayout();
            this.grbConsultadeDATOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCargarDatos;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox grbConsultadeDATOS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimitedeCrédito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.Label lblTotaldeDeuda;
        private System.Windows.Forms.TextBox txtTotaldeDeuda;
        private System.Windows.Forms.Button btnListar;
    }
}