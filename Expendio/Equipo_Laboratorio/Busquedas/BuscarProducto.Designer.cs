namespace Equipo_Laboratorio.Busquedas
{
   partial class BuscarProducto
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProducto));
         this.dtgvProducto = new System.Windows.Forms.DataGridView();
         this.txtBusqueda = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnBuscar = new System.Windows.Forms.Button();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.txtCategoria = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtPrecio = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.txtInventario = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.rbtnNombre = new System.Windows.Forms.RadioButton();
         this.rbtnCodigo = new System.Windows.Forms.RadioButton();
         this.btnAñadir = new System.Windows.Forms.Button();
         this.txtCantidad = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.rbtnCategoria = new System.Windows.Forms.RadioButton();
         ((System.ComponentModel.ISupportInitialize)(this.dtgvProducto)).BeginInit();
         this.SuspendLayout();
         // 
         // dtgvProducto
         // 
         this.dtgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.dtgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
         this.dtgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.dtgvProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dtgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dtgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dtgvProducto.DefaultCellStyle = dataGridViewCellStyle2;
         this.dtgvProducto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
         this.dtgvProducto.Location = new System.Drawing.Point(12, 34);
         this.dtgvProducto.Name = "dtgvProducto";
         this.dtgvProducto.ReadOnly = true;
         this.dtgvProducto.RowHeadersVisible = false;
         this.dtgvProducto.Size = new System.Drawing.Size(683, 429);
         this.dtgvProducto.TabIndex = 1;
         this.dtgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProducto_CellClick);
         // 
         // txtBusqueda
         // 
         this.txtBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtBusqueda.ForeColor = System.Drawing.Color.White;
         this.txtBusqueda.Location = new System.Drawing.Point(705, 91);
         this.txtBusqueda.Name = "txtBusqueda";
         this.txtBusqueda.Size = new System.Drawing.Size(173, 22);
         this.txtBusqueda.TabIndex = 4;
         this.txtBusqueda.Text = "Nombre Producto";
         this.txtBusqueda.Enter += new System.EventHandler(this.txtBusqueda_Enter);
         this.txtBusqueda.Leave += new System.EventHandler(this.txtBusqueda_Leave);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(701, 102);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(185, 21);
         this.label1.TabIndex = 5;
         this.label1.Text = "_________________________";
         // 
         // btnBuscar
         // 
         this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
         this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
         this.btnBuscar.Location = new System.Drawing.Point(902, 78);
         this.btnBuscar.Name = "btnBuscar";
         this.btnBuscar.Size = new System.Drawing.Size(72, 46);
         this.btnBuscar.TabIndex = 13;
         this.btnBuscar.UseVisualStyleBackColor = true;
         this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
         // 
         // txtNombre
         // 
         this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtNombre.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNombre.ForeColor = System.Drawing.Color.White;
         this.txtNombre.Location = new System.Drawing.Point(741, 152);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.ReadOnly = true;
         this.txtNombre.Size = new System.Drawing.Size(173, 22);
         this.txtNombre.TabIndex = 14;
         this.txtNombre.Text = "Nombre Producto";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.ForeColor = System.Drawing.Color.White;
         this.label2.Location = new System.Drawing.Point(737, 163);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(185, 21);
         this.label2.TabIndex = 15;
         this.label2.Text = "_________________________";
         // 
         // txtCategoria
         // 
         this.txtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtCategoria.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtCategoria.ForeColor = System.Drawing.Color.White;
         this.txtCategoria.Location = new System.Drawing.Point(741, 206);
         this.txtCategoria.Name = "txtCategoria";
         this.txtCategoria.ReadOnly = true;
         this.txtCategoria.Size = new System.Drawing.Size(173, 22);
         this.txtCategoria.TabIndex = 16;
         this.txtCategoria.Text = "Categoria";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.ForeColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(737, 217);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(185, 21);
         this.label3.TabIndex = 17;
         this.label3.Text = "_________________________";
         // 
         // txtPrecio
         // 
         this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtPrecio.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPrecio.ForeColor = System.Drawing.Color.White;
         this.txtPrecio.Location = new System.Drawing.Point(741, 261);
         this.txtPrecio.Name = "txtPrecio";
         this.txtPrecio.ReadOnly = true;
         this.txtPrecio.Size = new System.Drawing.Size(173, 22);
         this.txtPrecio.TabIndex = 18;
         this.txtPrecio.Text = "Precio";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.ForeColor = System.Drawing.Color.White;
         this.label4.Location = new System.Drawing.Point(737, 272);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(185, 21);
         this.label4.TabIndex = 19;
         this.label4.Text = "_________________________";
         // 
         // txtInventario
         // 
         this.txtInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.txtInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtInventario.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtInventario.ForeColor = System.Drawing.Color.White;
         this.txtInventario.Location = new System.Drawing.Point(741, 354);
         this.txtInventario.Name = "txtInventario";
         this.txtInventario.ReadOnly = true;
         this.txtInventario.Size = new System.Drawing.Size(173, 22);
         this.txtInventario.TabIndex = 20;
         this.txtInventario.Text = "Inventario";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.ForeColor = System.Drawing.Color.White;
         this.label5.Location = new System.Drawing.Point(737, 365);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(185, 21);
         this.label5.TabIndex = 21;
         this.label5.Text = "_________________________";
         // 
         // rbtnNombre
         // 
         this.rbtnNombre.AutoSize = true;
         this.rbtnNombre.Checked = true;
         this.rbtnNombre.Location = new System.Drawing.Point(705, 34);
         this.rbtnNombre.Name = "rbtnNombre";
         this.rbtnNombre.Size = new System.Drawing.Size(86, 25);
         this.rbtnNombre.TabIndex = 22;
         this.rbtnNombre.TabStop = true;
         this.rbtnNombre.Text = "Nombre";
         this.rbtnNombre.UseVisualStyleBackColor = true;
         // 
         // rbtnCodigo
         // 
         this.rbtnCodigo.AutoSize = true;
         this.rbtnCodigo.Location = new System.Drawing.Point(797, 34);
         this.rbtnCodigo.Name = "rbtnCodigo";
         this.rbtnCodigo.Size = new System.Drawing.Size(78, 25);
         this.rbtnCodigo.TabIndex = 23;
         this.rbtnCodigo.Text = "Codigo";
         this.rbtnCodigo.UseVisualStyleBackColor = true;
         // 
         // btnAñadir
         // 
         this.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
         this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
         this.btnAñadir.Location = new System.Drawing.Point(714, 409);
         this.btnAñadir.Name = "btnAñadir";
         this.btnAñadir.Size = new System.Drawing.Size(241, 54);
         this.btnAñadir.TabIndex = 24;
         this.btnAñadir.UseVisualStyleBackColor = true;
         this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
         // 
         // txtCantidad
         // 
         this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtCantidad.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtCantidad.ForeColor = System.Drawing.Color.White;
         this.txtCantidad.Location = new System.Drawing.Point(741, 306);
         this.txtCantidad.Name = "txtCantidad";
         this.txtCantidad.ReadOnly = true;
         this.txtCantidad.Size = new System.Drawing.Size(173, 22);
         this.txtCantidad.TabIndex = 25;
         this.txtCantidad.Text = "1";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.ForeColor = System.Drawing.Color.White;
         this.label6.Location = new System.Drawing.Point(737, 319);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(185, 21);
         this.label6.TabIndex = 26;
         this.label6.Text = "_________________________";
         // 
         // rbtnCategoria
         // 
         this.rbtnCategoria.AutoSize = true;
         this.rbtnCategoria.Location = new System.Drawing.Point(881, 34);
         this.rbtnCategoria.Name = "rbtnCategoria";
         this.rbtnCategoria.Size = new System.Drawing.Size(95, 25);
         this.rbtnCategoria.TabIndex = 27;
         this.rbtnCategoria.Text = "Categoria";
         this.rbtnCategoria.UseVisualStyleBackColor = true;
         // 
         // BuscarProducto
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.ClientSize = new System.Drawing.Size(979, 486);
         this.Controls.Add(this.rbtnCategoria);
         this.Controls.Add(this.txtCantidad);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.btnAñadir);
         this.Controls.Add(this.rbtnCodigo);
         this.Controls.Add(this.rbtnNombre);
         this.Controls.Add(this.txtInventario);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.txtPrecio);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.txtCategoria);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtNombre);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.btnBuscar);
         this.Controls.Add(this.txtBusqueda);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dtgvProducto);
         this.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MaximizeBox = false;
         this.Name = "BuscarProducto";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "PRODUCTOS";
         this.Load += new System.EventHandler(this.BuscarProducto_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dtgvProducto)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dtgvProducto;
      private System.Windows.Forms.TextBox txtBusqueda;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnBuscar;
      private System.Windows.Forms.TextBox txtNombre;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtCategoria;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtPrecio;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtInventario;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.RadioButton rbtnNombre;
      private System.Windows.Forms.RadioButton rbtnCodigo;
      private System.Windows.Forms.Button btnAñadir;
      private System.Windows.Forms.TextBox txtCantidad;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.RadioButton rbtnCategoria;
   }
}