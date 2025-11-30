namespace Equipo_Laboratorio
{
   partial class Venta
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
         this.dtgvVenta = new System.Windows.Forms.DataGridView();
         this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
         this.txtCodigo = new System.Windows.Forms.TextBox();
         this.btnBuscar = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.txtDescuento = new System.Windows.Forms.TextBox();
         this.txtSubtotal = new System.Windows.Forms.TextBox();
         this.txtTotal = new System.Windows.Forms.TextBox();
         this.btnMas = new System.Windows.Forms.Button();
         this.btnMenos = new System.Windows.Forms.Button();
         this.btnIgual = new System.Windows.Forms.Button();
         this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dtgvVenta)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // dtgvVenta
         // 
         this.dtgvVenta.AllowUserToAddRows = false;
         this.dtgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.dtgvVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
         this.dtgvVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.dtgvVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dtgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dtgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ELIMINAR});
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dtgvVenta.DefaultCellStyle = dataGridViewCellStyle3;
         this.dtgvVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
         this.dtgvVenta.Location = new System.Drawing.Point(12, 24);
         this.dtgvVenta.Name = "dtgvVenta";
         this.dtgvVenta.ReadOnly = true;
         this.dtgvVenta.RowHeadersVisible = false;
         this.dtgvVenta.Size = new System.Drawing.Size(740, 429);
         this.dtgvVenta.TabIndex = 0;
         this.dtgvVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVenta_CellClick);
         // 
         // ELIMINAR
         // 
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle2.NullValue = "Properties.Resources.trash";
         this.ELIMINAR.DefaultCellStyle = dataGridViewCellStyle2;
         this.ELIMINAR.HeaderText = "";
         this.ELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("ELIMINAR.Image")));
         this.ELIMINAR.Name = "ELIMINAR";
         this.ELIMINAR.ReadOnly = true;
         this.ELIMINAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.ELIMINAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         this.ELIMINAR.Width = 19;
         // 
         // txtCodigo
         // 
         this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtCodigo.ForeColor = System.Drawing.Color.White;
         this.txtCodigo.Location = new System.Drawing.Point(853, 134);
         this.txtCodigo.Name = "txtCodigo";
         this.txtCodigo.Size = new System.Drawing.Size(173, 22);
         this.txtCodigo.TabIndex = 1;
         this.txtCodigo.Text = "Codigo";
         this.txtCodigo.Enter += new System.EventHandler(this.txtProducto_Enter);
         this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
         this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
         // 
         // btnBuscar
         // 
         this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
         this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
         this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnBuscar.Location = new System.Drawing.Point(784, 24);
         this.btnBuscar.Name = "btnBuscar";
         this.btnBuscar.Size = new System.Drawing.Size(242, 57);
         this.btnBuscar.TabIndex = 9;
         this.btnBuscar.Text = "      Buscar Producto";
         this.btnBuscar.UseVisualStyleBackColor = true;
         this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(849, 145);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(177, 20);
         this.label1.TabIndex = 3;
         this.label1.Text = "____________________________";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(784, 117);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(48, 48);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pictureBox1.TabIndex = 4;
         this.pictureBox1.TabStop = false;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.ForeColor = System.Drawing.Color.White;
         this.label2.Location = new System.Drawing.Point(780, 209);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(110, 20);
         this.label2.TabIndex = 6;
         this.label2.Text = "Descuento % :  ";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.ForeColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(780, 241);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(84, 20);
         this.label3.TabIndex = 7;
         this.label3.Text = "Subtotal $ :";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.ForeColor = System.Drawing.Color.White;
         this.label4.Location = new System.Drawing.Point(780, 275);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(66, 20);
         this.label4.TabIndex = 8;
         this.label4.Text = "Total $ : ";
         // 
         // txtDescuento
         // 
         this.txtDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.txtDescuento.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDescuento.ForeColor = System.Drawing.Color.White;
         this.txtDescuento.Location = new System.Drawing.Point(882, 205);
         this.txtDescuento.Name = "txtDescuento";
         this.txtDescuento.Size = new System.Drawing.Size(107, 27);
         this.txtDescuento.TabIndex = 9;
         this.txtDescuento.Text = "0";
         this.txtDescuento.Enter += new System.EventHandler(this.txtDescuento_Enter);
         this.txtDescuento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescuento_KeyUp);
         // 
         // txtSubtotal
         // 
         this.txtSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtSubtotal.ForeColor = System.Drawing.Color.White;
         this.txtSubtotal.Location = new System.Drawing.Point(882, 241);
         this.txtSubtotal.Name = "txtSubtotal";
         this.txtSubtotal.ReadOnly = true;
         this.txtSubtotal.Size = new System.Drawing.Size(107, 27);
         this.txtSubtotal.TabIndex = 10;
         this.txtSubtotal.Text = "0";
         // 
         // txtTotal
         // 
         this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.txtTotal.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtTotal.ForeColor = System.Drawing.Color.White;
         this.txtTotal.Location = new System.Drawing.Point(882, 276);
         this.txtTotal.Name = "txtTotal";
         this.txtTotal.ReadOnly = true;
         this.txtTotal.Size = new System.Drawing.Size(107, 27);
         this.txtTotal.TabIndex = 11;
         this.txtTotal.Text = "0";
         // 
         // btnMas
         // 
         this.btnMas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
         this.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnMas.Image = ((System.Drawing.Image)(resources.GetObject("btnMas.Image")));
         this.btnMas.Location = new System.Drawing.Point(771, 387);
         this.btnMas.Name = "btnMas";
         this.btnMas.Size = new System.Drawing.Size(75, 66);
         this.btnMas.TabIndex = 3;
         this.btnMas.UseVisualStyleBackColor = true;
         this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
         // 
         // btnMenos
         // 
         this.btnMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
         this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnMenos.Image = ((System.Drawing.Image)(resources.GetObject("btnMenos.Image")));
         this.btnMenos.Location = new System.Drawing.Point(871, 387);
         this.btnMenos.Name = "btnMenos";
         this.btnMenos.Size = new System.Drawing.Size(75, 66);
         this.btnMenos.TabIndex = 5;
         this.btnMenos.UseVisualStyleBackColor = true;
         this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
         // 
         // btnIgual
         // 
         this.btnIgual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
         this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnIgual.Image = ((System.Drawing.Image)(resources.GetObject("btnIgual.Image")));
         this.btnIgual.Location = new System.Drawing.Point(962, 387);
         this.btnIgual.Name = "btnIgual";
         this.btnIgual.Size = new System.Drawing.Size(75, 66);
         this.btnIgual.TabIndex = 7;
         this.btnIgual.UseVisualStyleBackColor = true;
         this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
         // 
         // CODIGO
         // 
         this.CODIGO.HeaderText = "CODIGO";
         this.CODIGO.Name = "CODIGO";
         this.CODIGO.Visible = false;
         this.CODIGO.Width = 90;
         // 
         // ARTICULO
         // 
         this.ARTICULO.HeaderText = "PRODUCTO";
         this.ARTICULO.Name = "ARTICULO";
         this.ARTICULO.Width = 111;
         // 
         // CATEGORIA
         // 
         this.CATEGORIA.HeaderText = "CATEGORIA";
         this.CATEGORIA.Name = "CATEGORIA";
         this.CATEGORIA.Width = 113;
         // 
         // PRECIO
         // 
         this.PRECIO.HeaderText = "PRECIO";
         this.PRECIO.Name = "PRECIO";
         this.PRECIO.Width = 83;
         // 
         // CANTIDAD
         // 
         this.CANTIDAD.HeaderText = "CANTIDAD";
         this.CANTIDAD.Name = "CANTIDAD";
         this.CANTIDAD.Width = 108;
         // 
         // Venta
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.ClientSize = new System.Drawing.Size(1103, 545);
         this.Controls.Add(this.btnIgual);
         this.Controls.Add(this.btnMenos);
         this.Controls.Add(this.btnMas);
         this.Controls.Add(this.txtTotal);
         this.Controls.Add(this.txtSubtotal);
         this.Controls.Add(this.txtDescuento);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.btnBuscar);
         this.Controls.Add(this.txtCodigo);
         this.Controls.Add(this.dtgvVenta);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Venta";
         this.Text = "Venta";
         this.Load += new System.EventHandler(this.Venta_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dtgvVenta)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dtgvVenta;
      private System.Windows.Forms.TextBox txtCodigo;
      private System.Windows.Forms.Button btnBuscar;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtDescuento;
      private System.Windows.Forms.TextBox txtSubtotal;
      private System.Windows.Forms.TextBox txtTotal;
      private System.Windows.Forms.Button btnMas;
      private System.Windows.Forms.Button btnMenos;
      private System.Windows.Forms.Button btnIgual;
      private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
      private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
      private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
      private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
      private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
      private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
   }
}