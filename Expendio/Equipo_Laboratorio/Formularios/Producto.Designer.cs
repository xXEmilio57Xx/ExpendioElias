namespace Equipo_Laboratorio.Formularios
{
   partial class Producto
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.txtCodigo = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label10 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.btnOk = new System.Windows.Forms.Button();
         this.label8 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.txtPrecioProv = new System.Windows.Forms.TextBox();
         this.txtPorcentaje = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.txtPrecio = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.txtCantidad = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.cmbCategoria = new System.Windows.Forms.ComboBox();
         this.txtDescripcion = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.bntAñadir = new System.Windows.Forms.Button();
         this.btnEditar = new System.Windows.Forms.Button();
         this.btnAñadirCat = new System.Windows.Forms.Button();
         this.btnEliminar = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.panel1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(16, 13);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(48, 48);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pictureBox1.TabIndex = 7;
         this.pictureBox1.TabStop = false;
         // 
         // txtCodigo
         // 
         this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtCodigo.ForeColor = System.Drawing.Color.White;
         this.txtCodigo.Location = new System.Drawing.Point(98, 24);
         this.txtCodigo.Name = "txtCodigo";
         this.txtCodigo.Size = new System.Drawing.Size(173, 22);
         this.txtCodigo.TabIndex = 1;
         this.txtCodigo.Text = "Codigo";
         this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
         this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
         this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(94, 37);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(177, 20);
         this.label1.TabIndex = 6;
         this.label1.Text = "____________________________";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(458, 45);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(133, 28);
         this.label5.TabIndex = 15;
         this.label5.Text = "PRODUCTOS";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.panel1.Controls.Add(this.groupBox1);
         this.panel1.Controls.Add(this.btnAñadirCat);
         this.panel1.Controls.Add(this.label6);
         this.panel1.Controls.Add(this.txtPrecio);
         this.panel1.Controls.Add(this.label4);
         this.panel1.Controls.Add(this.txtCantidad);
         this.panel1.Controls.Add(this.label3);
         this.panel1.Controls.Add(this.cmbCategoria);
         this.panel1.Controls.Add(this.txtDescripcion);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Controls.Add(this.txtCodigo);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Location = new System.Drawing.Point(160, 105);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(747, 321);
         this.panel1.TabIndex = 16;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label10);
         this.groupBox1.Controls.Add(this.label9);
         this.groupBox1.Controls.Add(this.btnOk);
         this.groupBox1.Controls.Add(this.label8);
         this.groupBox1.Controls.Add(this.label7);
         this.groupBox1.Controls.Add(this.txtPrecioProv);
         this.groupBox1.Controls.Add(this.txtPorcentaje);
         this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.groupBox1.ForeColor = System.Drawing.Color.White;
         this.groupBox1.Location = new System.Drawing.Point(362, 126);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(336, 174);
         this.groupBox1.TabIndex = 16;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Caculos (Opcional)";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(6, 68);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(17, 20);
         this.label10.TabIndex = 21;
         this.label10.Text = "$";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(172, 142);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(21, 20);
         this.label9.TabIndex = 20;
         this.label9.Text = "%";
         // 
         // btnOk
         // 
         this.btnOk.BackColor = System.Drawing.Color.SeaGreen;
         this.btnOk.FlatAppearance.BorderSize = 0;
         this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnOk.Location = new System.Drawing.Point(226, 136);
         this.btnOk.Name = "btnOk";
         this.btnOk.Size = new System.Drawing.Size(84, 29);
         this.btnOk.TabIndex = 19;
         this.btnOk.Text = "OK";
         this.btnOk.UseVisualStyleBackColor = false;
         this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(22, 41);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(122, 20);
         this.label8.TabIndex = 18;
         this.label8.Text = "Precio Proveedor";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(22, 105);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(144, 20);
         this.label7.TabIndex = 17;
         this.label7.Text = "Porcentaje Ganancia";
         // 
         // txtPrecioProv
         // 
         this.txtPrecioProv.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPrecioProv.Location = new System.Drawing.Point(26, 68);
         this.txtPrecioProv.Name = "txtPrecioProv";
         this.txtPrecioProv.Size = new System.Drawing.Size(140, 23);
         this.txtPrecioProv.TabIndex = 1;
         // 
         // txtPorcentaje
         // 
         this.txtPorcentaje.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPorcentaje.Location = new System.Drawing.Point(26, 140);
         this.txtPorcentaje.Name = "txtPorcentaje";
         this.txtPorcentaje.Size = new System.Drawing.Size(140, 23);
         this.txtPorcentaje.TabIndex = 0;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(455, 13);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(74, 20);
         this.label6.TabIndex = 15;
         this.label6.Text = "Categoria";
         // 
         // txtPrecio
         // 
         this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtPrecio.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPrecio.ForeColor = System.Drawing.Color.White;
         this.txtPrecio.Location = new System.Drawing.Point(98, 199);
         this.txtPrecio.Name = "txtPrecio";
         this.txtPrecio.Size = new System.Drawing.Size(173, 22);
         this.txtPrecio.TabIndex = 7;
         this.txtPrecio.Text = "$Precio";
         this.txtPrecio.Enter += new System.EventHandler(this.txtPrecio_Enter);
         this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.label4.ForeColor = System.Drawing.Color.White;
         this.label4.Location = new System.Drawing.Point(94, 212);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(177, 20);
         this.label4.TabIndex = 14;
         this.label4.Text = "____________________________";
         // 
         // txtCantidad
         // 
         this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtCantidad.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtCantidad.ForeColor = System.Drawing.Color.White;
         this.txtCantidad.Location = new System.Drawing.Point(98, 267);
         this.txtCantidad.Name = "txtCantidad";
         this.txtCantidad.Size = new System.Drawing.Size(173, 22);
         this.txtCantidad.TabIndex = 9;
         this.txtCantidad.Text = "Inventario Cant.";
         this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
         this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.label3.ForeColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(94, 280);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(177, 20);
         this.label3.TabIndex = 12;
         this.label3.Text = "____________________________";
         // 
         // cmbCategoria
         // 
         this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.cmbCategoria.FormattingEnabled = true;
         this.cmbCategoria.Location = new System.Drawing.Point(372, 37);
         this.cmbCategoria.Name = "cmbCategoria";
         this.cmbCategoria.Size = new System.Drawing.Size(261, 28);
         this.cmbCategoria.TabIndex = 3;
         // 
         // txtDescripcion
         // 
         this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDescripcion.ForeColor = System.Drawing.Color.White;
         this.txtDescripcion.Location = new System.Drawing.Point(98, 113);
         this.txtDescripcion.Name = "txtDescripcion";
         this.txtDescripcion.Size = new System.Drawing.Size(173, 22);
         this.txtDescripcion.TabIndex = 5;
         this.txtDescripcion.Text = "Descripcion";
         this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
         this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.label2.ForeColor = System.Drawing.Color.White;
         this.label2.Location = new System.Drawing.Point(94, 126);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(177, 20);
         this.label2.TabIndex = 9;
         this.label2.Text = "____________________________";
         // 
         // bntAñadir
         // 
         this.bntAñadir.BackColor = System.Drawing.Color.SeaGreen;
         this.bntAñadir.FlatAppearance.BorderSize = 0;
         this.bntAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.bntAñadir.ForeColor = System.Drawing.Color.White;
         this.bntAñadir.Location = new System.Drawing.Point(396, 453);
         this.bntAñadir.Name = "bntAñadir";
         this.bntAñadir.Size = new System.Drawing.Size(251, 43);
         this.bntAñadir.TabIndex = 11;
         this.bntAñadir.Text = "AÑADIR";
         this.bntAñadir.UseVisualStyleBackColor = false;
         this.bntAñadir.Click += new System.EventHandler(this.bntAñadir_Click);
         // 
         // btnEditar
         // 
         this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.btnEditar.FlatAppearance.BorderSize = 0;
         this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
         this.btnEditar.Location = new System.Drawing.Point(850, 45);
         this.btnEditar.Name = "btnEditar";
         this.btnEditar.Size = new System.Drawing.Size(57, 58);
         this.btnEditar.TabIndex = 22;
         this.btnEditar.UseVisualStyleBackColor = false;
         this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
         // 
         // btnAñadirCat
         // 
         this.btnAñadirCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
         this.btnAñadirCat.FlatAppearance.BorderSize = 0;
         this.btnAñadirCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnAñadirCat.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadirCat.Image")));
         this.btnAñadirCat.Location = new System.Drawing.Point(656, 29);
         this.btnAñadirCat.Name = "btnAñadirCat";
         this.btnAñadirCat.Size = new System.Drawing.Size(42, 43);
         this.btnAñadirCat.TabIndex = 23;
         this.btnAñadirCat.UseVisualStyleBackColor = false;
         // 
         // btnEliminar
         // 
         this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.btnEliminar.FlatAppearance.BorderSize = 0;
         this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
         this.btnEliminar.Location = new System.Drawing.Point(775, 41);
         this.btnEliminar.Name = "btnEliminar";
         this.btnEliminar.Size = new System.Drawing.Size(57, 58);
         this.btnEliminar.TabIndex = 24;
         this.btnEliminar.UseVisualStyleBackColor = false;
         this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
         // 
         // Producto
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
         this.ClientSize = new System.Drawing.Size(1103, 545);
         this.Controls.Add(this.btnEliminar);
         this.Controls.Add(this.btnEditar);
         this.Controls.Add(this.bntAñadir);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label5);
         this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ForeColor = System.Drawing.Color.White;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "Producto";
         this.Load += new System.EventHandler(this.Producto_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.TextBox txtCodigo;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.TextBox txtDescripcion;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox txtPrecio;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtCantidad;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox cmbCategoria;
      private System.Windows.Forms.Button bntAñadir;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox txtPorcentaje;
      private System.Windows.Forms.Button btnOk;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox txtPrecioProv;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Button btnEditar;
      private System.Windows.Forms.Button btnAñadirCat;
      private System.Windows.Forms.Button btnEliminar;
   }
}