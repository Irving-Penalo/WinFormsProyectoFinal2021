
namespace WinFormsProyectoFinal2021
{
    partial class FormCRUD_Prendas
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
            this.InputId_Talla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InputId_Marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.InputId = new System.Windows.Forms.TextBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.PanelManipulacion = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.InputNombrePrendas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InputId_Proveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InputId_Departamento = new System.Windows.Forms.TextBox();
            this.InputPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.InputCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PanelManipulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // InputId_Talla
            // 
            this.InputId_Talla.Location = new System.Drawing.Point(124, 393);
            this.InputId_Talla.Name = "InputId_Talla";
            this.InputId_Talla.Size = new System.Drawing.Size(143, 20);
            this.InputId_Talla.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(8, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 75;
            this.label4.Text = "Id_Talla";
            // 
            // InputId_Marca
            // 
            this.InputId_Marca.Location = new System.Drawing.Point(124, 365);
            this.InputId_Marca.Name = "InputId_Marca";
            this.InputId_Marca.Size = new System.Drawing.Size(143, 20);
            this.InputId_Marca.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 73;
            this.label2.Text = "Id_Prendas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 72;
            this.label1.Text = "Id_Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(255, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 45);
            this.label3.TabIndex = 71;
            this.label3.Text = "Tabla Prendas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalir.Location = new System.Drawing.Point(605, 416);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSalir.Size = new System.Drawing.Size(203, 23);
            this.BtnSalir.TabIndex = 70;
            this.BtnSalir.Text = "Salir/Cerrar";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // InputId
            // 
            this.InputId.Location = new System.Drawing.Point(124, 334);
            this.InputId.Name = "InputId";
            this.InputId.Size = new System.Drawing.Size(143, 20);
            this.InputId.TabIndex = 69;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSeleccionar.Location = new System.Drawing.Point(712, 333);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(96, 23);
            this.BtnSeleccionar.TabIndex = 68;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnInsertar.Location = new System.Drawing.Point(605, 333);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(101, 23);
            this.BtnInsertar.TabIndex = 67;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // PanelManipulacion
            // 
            this.PanelManipulacion.BackgroundColor = System.Drawing.Color.LightCyan;
            this.PanelManipulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PanelManipulacion.Location = new System.Drawing.Point(12, 85);
            this.PanelManipulacion.Name = "PanelManipulacion";
            this.PanelManipulacion.Size = new System.Drawing.Size(796, 231);
            this.PanelManipulacion.TabIndex = 66;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.Location = new System.Drawing.Point(712, 377);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(96, 23);
            this.BtnEliminar.TabIndex = 65;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActualizar.Location = new System.Drawing.Point(605, 377);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(101, 23);
            this.BtnActualizar.TabIndex = 64;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // InputNombrePrendas
            // 
            this.InputNombrePrendas.Location = new System.Drawing.Point(435, 395);
            this.InputNombrePrendas.Name = "InputNombrePrendas";
            this.InputNombrePrendas.Size = new System.Drawing.Size(143, 20);
            this.InputNombrePrendas.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(279, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 81;
            this.label5.Text = "Nombre Prendas";
            // 
            // InputId_Proveedor
            // 
            this.InputId_Proveedor.Location = new System.Drawing.Point(435, 367);
            this.InputId_Proveedor.Name = "InputId_Proveedor";
            this.InputId_Proveedor.Size = new System.Drawing.Size(143, 20);
            this.InputId_Proveedor.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(279, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 21);
            this.label6.TabIndex = 79;
            this.label6.Text = "Id_Departamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(279, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 78;
            this.label7.Text = "Id_Proveedor";
            // 
            // InputId_Departamento
            // 
            this.InputId_Departamento.Location = new System.Drawing.Point(435, 336);
            this.InputId_Departamento.Name = "InputId_Departamento";
            this.InputId_Departamento.Size = new System.Drawing.Size(143, 20);
            this.InputId_Departamento.TabIndex = 77;
            // 
            // InputPrecio
            // 
            this.InputPrecio.Location = new System.Drawing.Point(124, 421);
            this.InputPrecio.Name = "InputPrecio";
            this.InputPrecio.Size = new System.Drawing.Size(143, 20);
            this.InputPrecio.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(11, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 83;
            this.label8.Text = "Precio";
            // 
            // InputCantidad
            // 
            this.InputCantidad.Location = new System.Drawing.Point(435, 421);
            this.InputCantidad.Name = "InputCantidad";
            this.InputCantidad.Size = new System.Drawing.Size(143, 20);
            this.InputCantidad.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(279, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 85;
            this.label9.Text = "Cantidad";
            // 
            // FormCRUD_Prendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(819, 480);
            this.Controls.Add(this.InputCantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.InputPrecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InputNombrePrendas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InputId_Proveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InputId_Departamento);
            this.Controls.Add(this.InputId_Talla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputId_Marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.InputId);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.PanelManipulacion);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Name = "FormCRUD_Prendas";
            this.Text = "FormCRUD_Prendas";
            this.Load += new System.EventHandler(this.FormCRUD_Prendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelManipulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputId_Talla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputId_Marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox InputId;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.DataGridView PanelManipulacion;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox InputNombrePrendas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputId_Proveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InputId_Departamento;
        private System.Windows.Forms.TextBox InputPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox InputCantidad;
        private System.Windows.Forms.Label label9;
    }
}