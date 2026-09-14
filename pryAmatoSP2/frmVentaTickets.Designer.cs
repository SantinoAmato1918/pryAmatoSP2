namespace pryAmatoSP2
{
    partial class frmVentaTickets
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
            dtpFecha = new DateTimePicker();
            txtNumeroTicket = new TextBox();
            cmbTipoTicket = new ComboBox();
            btnRegistrar = new Button();
            lblNumeroTicket = new Label();
            lstVentas = new ListBox();
            lblTipoTicket = new Label();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(98, 12);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(171, 23);
            dtpFecha.TabIndex = 0;
            // 
            // txtNumeroTicket
            // 
            txtNumeroTicket.Location = new Point(130, 55);
            txtNumeroTicket.Name = "txtNumeroTicket";
            txtNumeroTicket.Size = new Size(100, 23);
            txtNumeroTicket.TabIndex = 1;
            txtNumeroTicket.TextChanged += txtNumeroTicket_TextChanged;
            txtNumeroTicket.KeyPress += txtNumeroTicket_KeyPress;
            // 
            // cmbTipoTicket
            // 
            cmbTipoTicket.Enabled = false;
            cmbTipoTicket.FormattingEnabled = true;
            cmbTipoTicket.Items.AddRange(new object[] { "Básico", "Estándar", "Premium" });
            cmbTipoTicket.Location = new Point(130, 94);
            cmbTipoTicket.Name = "cmbTipoTicket";
            cmbTipoTicket.Size = new Size(121, 23);
            cmbTipoTicket.TabIndex = 2;
            cmbTipoTicket.SelectedIndexChanged += cmbTipoTicket_SelectedIndexChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(252, 142);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(90, 35);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblNumeroTicket
            // 
            lblNumeroTicket.AutoSize = true;
            lblNumeroTicket.Location = new Point(22, 63);
            lblNumeroTicket.Name = "lblNumeroTicket";
            lblNumeroTicket.Size = new Size(102, 15);
            lblNumeroTicket.TabIndex = 4;
            lblNumeroTicket.Text = "Número de Ticket";
            lblNumeroTicket.Click += lblNumeroTicket_Click;
            // 
            // lstVentas
            // 
            lstVentas.FormattingEnabled = true;
            lstVentas.Location = new Point(22, 201);
            lstVentas.Name = "lstVentas";
            lstVentas.Size = new Size(320, 139);
            lstVentas.TabIndex = 5;
            // 
            // lblTipoTicket
            // 
            lblTipoTicket.AutoSize = true;
            lblTipoTicket.Location = new Point(22, 102);
            lblTipoTicket.Name = "lblTipoTicket";
            lblTipoTicket.Size = new Size(82, 15);
            lblTipoTicket.TabIndex = 6;
            lblTipoTicket.Text = "Tipo de Ticket";
            // 
            // frmVentaTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 376);
            Controls.Add(lblTipoTicket);
            Controls.Add(lstVentas);
            Controls.Add(lblNumeroTicket);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbTipoTicket);
            Controls.Add(txtNumeroTicket);
            Controls.Add(dtpFecha);
            MaximizeBox = false;
            Name = "frmVentaTickets";
            Text = "Qlokura.tv - Venta de Tickets";
            Load += frmVentaTickets_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private TextBox txtNumeroTicket;
        private ComboBox cmbTipoTicket;
        private Button btnRegistrar;
        private Label lblNumeroTicket;
        private ListBox lstVentas;
        private Label lblTipoTicket;
    }
}