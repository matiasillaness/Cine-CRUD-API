namespace FrontEnd.Presentaciones
{
    partial class frmAltaTickets
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoPagos = new System.Windows.Forms.ComboBox();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboButaca = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblProximoTicket = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.cboFuncion = new System.Windows.Forms.ComboBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.id_tipo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_butaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_funcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCosto2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(788, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(834, 387);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(135, 24);
            this.txtTotal.TabIndex = 16;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(739, 53);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(78, 24);
            this.txtDescuento.TabIndex = 10;
            this.txtDescuento.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(665, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descuento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(788, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Subtotal:";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(851, 357);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(118, 24);
            this.txtCosto.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de pago:";
            // 
            // cboTipoPagos
            // 
            this.cboTipoPagos.FormattingEnabled = true;
            this.cboTipoPagos.Location = new System.Drawing.Point(97, 54);
            this.cboTipoPagos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTipoPagos.Name = "cboTipoPagos";
            this.cboTipoPagos.Size = new System.Drawing.Size(299, 23);
            this.cboTipoPagos.TabIndex = 4;
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(452, 26);
            this.cboClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(198, 23);
            this.cboClientes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(402, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(823, 53);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 24);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(402, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Butaca:";
            // 
            // cboButaca
            // 
            this.cboButaca.FormattingEnabled = true;
            this.cboButaca.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cboButaca.Location = new System.Drawing.Point(452, 54);
            this.cboButaca.Margin = new System.Windows.Forms.Padding(2);
            this.cboButaca.Name = "cboButaca";
            this.cboButaca.Size = new System.Drawing.Size(199, 23);
            this.cboButaca.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(879, 416);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 22);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblProximoTicket
            // 
            this.lblProximoTicket.AutoSize = true;
            this.lblProximoTicket.BackColor = System.Drawing.Color.Transparent;
            this.lblProximoTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblProximoTicket.Location = new System.Drawing.Point(8, 8);
            this.lblProximoTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProximoTicket.Name = "lblProximoTicket";
            this.lblProximoTicket.Size = new System.Drawing.Size(69, 15);
            this.lblProximoTicket.TabIndex = 0;
            this.lblProximoTicket.Text = "TICKET N°: ";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(785, 416);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 22);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFuncion.Location = new System.Drawing.Point(8, 29);
            this.lblFuncion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(52, 15);
            this.lblFuncion.TabIndex = 1;
            this.lblFuncion.Text = "Función:";
            // 
            // cboFuncion
            // 
            this.cboFuncion.FormattingEnabled = true;
            this.cboFuncion.Location = new System.Drawing.Point(64, 26);
            this.cboFuncion.Margin = new System.Windows.Forms.Padding(2);
            this.cboFuncion.Name = "cboFuncion";
            this.cboFuncion.Size = new System.Drawing.Size(332, 23);
            this.cboFuncion.TabIndex = 2;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tipo_pago,
            this.id_butaca,
            this.id_funcion,
            this.costo,
            this.descuento,
            this.nom_cliente,
            this.ape_cliente});
            this.dgvDetalles.Location = new System.Drawing.Point(11, 84);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(958, 266);
            this.dgvDetalles.TabIndex = 12;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // id_tipo_pago
            // 
            this.id_tipo_pago.HeaderText = "Tipo Pago";
            this.id_tipo_pago.Name = "id_tipo_pago";
            this.id_tipo_pago.ReadOnly = true;
            // 
            // id_butaca
            // 
            this.id_butaca.HeaderText = "Butaca";
            this.id_butaca.Name = "id_butaca";
            this.id_butaca.ReadOnly = true;
            // 
            // id_funcion
            // 
            this.id_funcion.HeaderText = "Funcion";
            this.id_funcion.Name = "id_funcion";
            this.id_funcion.ReadOnly = true;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // nom_cliente
            // 
            this.nom_cliente.HeaderText = "Nombre";
            this.nom_cliente.Name = "nom_cliente";
            this.nom_cliente.ReadOnly = true;
            // 
            // ape_cliente
            // 
            this.ape_cliente.HeaderText = "Apellido";
            this.ape_cliente.Name = "ape_cliente";
            this.ape_cliente.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(8, 414);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 22);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCosto2
            // 
            this.txtCosto2.Location = new System.Drawing.Point(739, 23);
            this.txtCosto2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCosto2.Name = "txtCosto2";
            this.txtCosto2.Size = new System.Drawing.Size(78, 24);
            this.txtCosto2.TabIndex = 20;
            this.txtCosto2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(690, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Costo:";
            // 
            // frmAltaTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 440);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCosto2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipoPagos);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboButaca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblProximoTicket);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.cboFuncion);
            this.Controls.Add(this.dgvDetalles);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Name = "frmAltaTickets";
            this.Text = "CREAR TICKET";
            this.Load += new System.EventHandler(this.frmAltaTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private TextBox txtTotal;
        private TextBox txtDescuento;
        private Label label5;
        private Label label4;
        private TextBox txtCosto;
        private Label label3;
        private ComboBox cboTipoPagos;
        private ComboBox cboClientes;
        private Label label2;
        private Button btnAgregar;
        private Label label1;
        private ComboBox cboButaca;
        private Button btnCancelar;
        private Label lblProximoTicket;
        private Button btnAceptar;
        private Label lblFuncion;
        private ComboBox cboFuncion;
        private DataGridView dgvDetalles;
        private Button btnSalir;
        private TextBox txtCosto2;
        private DataGridViewTextBoxColumn id_tipo_pago;
        private DataGridViewTextBoxColumn id_butaca;
        private DataGridViewTextBoxColumn id_funcion;
        private DataGridViewTextBoxColumn costo;
        private DataGridViewTextBoxColumn descuento;
        private DataGridViewTextBoxColumn nom_cliente;
        private DataGridViewTextBoxColumn ape_cliente;
        private Label label7;
    }
}