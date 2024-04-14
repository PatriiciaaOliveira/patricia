namespace patricia
{
    partial class frm_Reserva
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
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.cbPeriodo1 = new System.Windows.Forms.ComboBox();
            this.lblPeriodo1 = new System.Windows.Forms.Label();
            this.lblReserva1 = new System.Windows.Forms.Label();
            this.cbReserva1 = new System.Windows.Forms.ComboBox();
            this.cbDisci = new System.Windows.Forms.ComboBox();
            this.btnSair1 = new System.Windows.Forms.Button();
            this.btnLimpar1 = new System.Windows.Forms.Button();
            this.btnConfirmar1 = new System.Windows.Forms.Button();
            this.lblDisci = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.mcCalendario1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // txtNome1
            // 
            this.txtNome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome1.Location = new System.Drawing.Point(199, 75);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(160, 26);
            this.txtNome1.TabIndex = 76;
            // 
            // cbPeriodo1
            // 
            this.cbPeriodo1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodo1.FormattingEnabled = true;
            this.cbPeriodo1.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Noite"});
            this.cbPeriodo1.Location = new System.Drawing.Point(199, 116);
            this.cbPeriodo1.Name = "cbPeriodo1";
            this.cbPeriodo1.Size = new System.Drawing.Size(160, 27);
            this.cbPeriodo1.TabIndex = 75;
            // 
            // lblPeriodo1
            // 
            this.lblPeriodo1.AutoSize = true;
            this.lblPeriodo1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo1.Location = new System.Drawing.Point(90, 116);
            this.lblPeriodo1.Name = "lblPeriodo1";
            this.lblPeriodo1.Size = new System.Drawing.Size(78, 22);
            this.lblPeriodo1.TabIndex = 74;
            this.lblPeriodo1.Text = "Período";
            // 
            // lblReserva1
            // 
            this.lblReserva1.AutoSize = true;
            this.lblReserva1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva1.Location = new System.Drawing.Point(90, 238);
            this.lblReserva1.Name = "lblReserva1";
            this.lblReserva1.Size = new System.Drawing.Size(81, 22);
            this.lblReserva1.TabIndex = 73;
            this.lblReserva1.Text = "Reserva";
            // 
            // cbReserva1
            // 
            this.cbReserva1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReserva1.FormattingEnabled = true;
            this.cbReserva1.Items.AddRange(new object[] {
            "Datashows",
            "TV  com VCR",
            "TV com DVD",
            "Projetor de slides",
            "Microfone",
            "Notebooks",
            "Tablets",
            "Jogos"});
            this.cbReserva1.Location = new System.Drawing.Point(199, 233);
            this.cbReserva1.Name = "cbReserva1";
            this.cbReserva1.Size = new System.Drawing.Size(160, 27);
            this.cbReserva1.TabIndex = 72;
            // 
            // cbDisci
            // 
            this.cbDisci.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDisci.FormattingEnabled = true;
            this.cbDisci.Items.AddRange(new object[] {
            "Matemática",
            "Português",
            "História",
            "Geografia",
            "Inglês",
            "Artes",
            "Ciências",
            "L.P.T",
            "Ed. Fisíca"});
            this.cbDisci.Location = new System.Drawing.Point(199, 174);
            this.cbDisci.Name = "cbDisci";
            this.cbDisci.Size = new System.Drawing.Size(160, 27);
            this.cbDisci.TabIndex = 71;
            // 
            // btnSair1
            // 
            this.btnSair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair1.Location = new System.Drawing.Point(462, 349);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Size = new System.Drawing.Size(90, 31);
            this.btnSair1.TabIndex = 70;
            this.btnSair1.Text = "Sair";
            this.btnSair1.UseVisualStyleBackColor = true;
            this.btnSair1.Click += new System.EventHandler(this.btnSair1_Click);
            // 
            // btnLimpar1
            // 
            this.btnLimpar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar1.Location = new System.Drawing.Point(332, 349);
            this.btnLimpar1.Name = "btnLimpar1";
            this.btnLimpar1.Size = new System.Drawing.Size(90, 31);
            this.btnLimpar1.TabIndex = 69;
            this.btnLimpar1.Text = "Limpar";
            this.btnLimpar1.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar1
            // 
            this.btnConfirmar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar1.Location = new System.Drawing.Point(215, 349);
            this.btnConfirmar1.Name = "btnConfirmar1";
            this.btnConfirmar1.Size = new System.Drawing.Size(90, 31);
            this.btnConfirmar1.TabIndex = 68;
            this.btnConfirmar1.Text = "Confirmar";
            this.btnConfirmar1.UseVisualStyleBackColor = true;
            this.btnConfirmar1.Click += new System.EventHandler(this.btnConfirmar1_Click);
            // 
            // lblDisci
            // 
            this.lblDisci.AutoSize = true;
            this.lblDisci.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisci.Location = new System.Drawing.Point(90, 176);
            this.lblDisci.Name = "lblDisci";
            this.lblDisci.Size = new System.Drawing.Size(104, 22);
            this.lblDisci.TabIndex = 67;
            this.lblDisci.Text = "Disciplina";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(90, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 22);
            this.lblNome.TabIndex = 66;
            this.lblNome.Text = "Nome";
            // 
            // mcCalendario1
            // 
            this.mcCalendario1.Location = new System.Drawing.Point(484, 71);
            this.mcCalendario1.Name = "mcCalendario1";
            this.mcCalendario1.TabIndex = 65;
            // 
            // frm_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNome1);
            this.Controls.Add(this.cbPeriodo1);
            this.Controls.Add(this.lblPeriodo1);
            this.Controls.Add(this.lblReserva1);
            this.Controls.Add(this.cbReserva1);
            this.Controls.Add(this.cbDisci);
            this.Controls.Add(this.btnSair1);
            this.Controls.Add(this.btnLimpar1);
            this.Controls.Add(this.btnConfirmar1);
            this.Controls.Add(this.lblDisci);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.mcCalendario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.ComboBox cbPeriodo1;
        private System.Windows.Forms.Label lblPeriodo1;
        private System.Windows.Forms.Label lblReserva1;
        private System.Windows.Forms.ComboBox cbReserva1;
        private System.Windows.Forms.ComboBox cbDisci;
        private System.Windows.Forms.Button btnSair1;
        private System.Windows.Forms.Button btnLimpar1;
        private System.Windows.Forms.Button btnConfirmar1;
        private System.Windows.Forms.Label lblDisci;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MonthCalendar mcCalendario1;
    }
}