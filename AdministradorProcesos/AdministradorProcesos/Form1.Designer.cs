namespace AdministradorProcesos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvProcesos = new DataGridView();
            colPID = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colMemoria = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnActualizar = new Button();
            btnDetalles = new Button();
            btnFinalizar = new Button();
            lblCantidad = new Label();
            btnMostrarTodo = new Button();
            lblMemoriaTotal = new Label();
            lblUltimaActualizacion = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProcesos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(404, 45);
            label1.TabIndex = 0;
            label1.Text = "Administrador de Procesos";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(138, 71);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(204, 25);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(363, 71);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvProcesos
            // 
            dgvProcesos.AllowUserToAddRows = false;
            dgvProcesos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProcesos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcesos.Columns.AddRange(new DataGridViewColumn[] { colPID, colNombre, colMemoria, colEstado });
            dgvProcesos.Location = new Point(47, 112);
            dgvProcesos.MultiSelect = false;
            dgvProcesos.Name = "dgvProcesos";
            dgvProcesos.ReadOnly = true;
            dgvProcesos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProcesos.Size = new Size(511, 410);
            dgvProcesos.TabIndex = 4;
            // 
            // colPID
            // 
            colPID.HeaderText = "PID";
            colPID.Name = "colPID";
            colPID.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Proceso";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colMemoria
            // 
            colMemoria.HeaderText = "Memoria";
            colMemoria.Name = "colMemoria";
            colMemoria.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 74);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 5;
            label2.Text = "Buscar:";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(605, 144);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(605, 193);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(75, 23);
            btnDetalles.TabIndex = 7;
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinalizar.Location = new Point(605, 247);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(79, 23);
            btnFinalizar.TabIndex = 8;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(583, 350);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(216, 25);
            lblCantidad.TabIndex = 9;
            lblCantidad.Text = "Procesos encontrados: 0";
            // 
            // btnMostrarTodo
            // 
            btnMostrarTodo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarTodo.Location = new Point(458, 73);
            btnMostrarTodo.Name = "btnMostrarTodo";
            btnMostrarTodo.Size = new Size(125, 23);
            btnMostrarTodo.TabIndex = 10;
            btnMostrarTodo.Text = "Mostrar Todo";
            btnMostrarTodo.UseVisualStyleBackColor = true;
            btnMostrarTodo.Click += btnMostrarTodo_Click;
            // 
            // lblMemoriaTotal
            // 
            lblMemoriaTotal.AutoSize = true;
            lblMemoriaTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMemoriaTotal.Location = new Point(583, 391);
            lblMemoriaTotal.Name = "lblMemoriaTotal";
            lblMemoriaTotal.Size = new Size(217, 25);
            lblMemoriaTotal.TabIndex = 11;
            lblMemoriaTotal.Text = "Memoria utilizada: 0 MB";
            // 
            // lblUltimaActualizacion
            // 
            lblUltimaActualizacion.AutoSize = true;
            lblUltimaActualizacion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUltimaActualizacion.Location = new Point(585, 436);
            lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            lblUltimaActualizacion.Size = new Size(208, 25);
            lblUltimaActualizacion.TabIndex = 12;
            lblUltimaActualizacion.Text = "Última actualización: --";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(981, 534);
            Controls.Add(lblUltimaActualizacion);
            Controls.Add(lblMemoriaTotal);
            Controls.Add(btnMostrarTodo);
            Controls.Add(lblCantidad);
            Controls.Add(btnFinalizar);
            Controls.Add(btnDetalles);
            Controls.Add(btnActualizar);
            Controls.Add(label2);
            Controls.Add(dgvProcesos);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProcesos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }






        #endregion

        private Label label1;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgvProcesos;
        private Label label2;
        private Button btnActualizar;
        private Button btnDetalles;
        private Button btnFinalizar;
        private Label lblCantidad;
        private DataGridViewTextBoxColumn colPID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colMemoria;
        private DataGridViewTextBoxColumn colEstado;
        private Button btnMostrarTodo;
        private Label lblMemoriaTotal;
        private Label lblUltimaActualizacion;
    }
}
