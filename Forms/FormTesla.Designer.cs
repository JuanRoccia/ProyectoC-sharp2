using FERNANDES_ROCCIA_TAPIA.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FERNANDES_ROCCIA_TAPIA
{
    partial class FormTesla
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

        // Lista para almacenar los datos ingresado
        // Crear la lista de vehículos en el ámbito de la clase
        private List<Tesla> vehiculos = new List<Tesla>();

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTesla));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_tesla = new System.Windows.Forms.DataGridView();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.duenio = new System.Windows.Forms.TextBox();
            this.colores = new System.Windows.Forms.ComboBox();
            this.kmActuales = new System.Windows.Forms.TextBox();
            this.anios = new System.Windows.Forms.ComboBox();
            this.modelos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearTesla = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tesla)).BeginInit();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tesla";
            // 
            // dgv_tesla
            // 
            this.dgv_tesla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tesla.Location = new System.Drawing.Point(81, 92);
            this.dgv_tesla.Name = "dgv_tesla";
            this.dgv_tesla.Size = new System.Drawing.Size(816, 198);
            this.dgv_tesla.TabIndex = 2;
            this.dgv_tesla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tesla_CellClick_1);
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.duenio);
            this.panelDatos.Controls.Add(this.colores);
            this.panelDatos.Controls.Add(this.kmActuales);
            this.panelDatos.Controls.Add(this.anios);
            this.panelDatos.Controls.Add(this.modelos);
            this.panelDatos.Controls.Add(this.label6);
            this.panelDatos.Controls.Add(this.label5);
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.label3);
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Location = new System.Drawing.Point(81, 9);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(816, 66);
            this.panelDatos.TabIndex = 4;
            // 
            // duenio
            // 
            this.duenio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duenio.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duenio.Location = new System.Drawing.Point(535, 34);
            this.duenio.Name = "duenio";
            this.duenio.Size = new System.Drawing.Size(168, 22);
            this.duenio.TabIndex = 9;
            // 
            // colores
            // 
            this.colores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colores.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colores.FormattingEnabled = true;
            this.colores.Location = new System.Drawing.Point(392, 33);
            this.colores.Name = "colores";
            this.colores.Size = new System.Drawing.Size(121, 22);
            this.colores.TabIndex = 8;
            // 
            // kmActuales
            // 
            this.kmActuales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kmActuales.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmActuales.Location = new System.Drawing.Point(234, 33);
            this.kmActuales.Name = "kmActuales";
            this.kmActuales.Size = new System.Drawing.Size(121, 22);
            this.kmActuales.TabIndex = 7;
            // 
            // anios
            // 
            this.anios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anios.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anios.FormattingEnabled = true;
            this.anios.Location = new System.Drawing.Point(113, 33);
            this.anios.Name = "anios";
            this.anios.Size = new System.Drawing.Size(87, 22);
            this.anios.TabIndex = 6;
            // 
            // modelos
            // 
            this.modelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelos.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelos.FormattingEnabled = true;
            this.modelos.Location = new System.Drawing.Point(3, 33);
            this.modelos.Name = "modelos";
            this.modelos.Size = new System.Drawing.Size(85, 22);
            this.modelos.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dueño";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kms. Actuales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modelo";
            // 
            // btnCrearTesla
            // 
            this.btnCrearTesla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnCrearTesla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.btnCrearTesla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTesla.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTesla.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearTesla.Location = new System.Drawing.Point(903, 21);
            this.btnCrearTesla.Name = "btnCrearTesla";
            this.btnCrearTesla.Size = new System.Drawing.Size(138, 44);
            this.btnCrearTesla.TabIndex = 9;
            this.btnCrearTesla.Text = "Crear Tesla";
            this.btnCrearTesla.UseVisualStyleBackColor = false;
            this.btnCrearTesla.Click += new System.EventHandler(this.btnCrearTesla_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(903, 92);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormTesla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrearTesla);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.dgv_tesla);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTesla";
            this.Text = "FormTesla";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tesla)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_tesla;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.TextBox duenio;
        private System.Windows.Forms.ComboBox colores;
        private System.Windows.Forms.TextBox kmActuales;
        private System.Windows.Forms.ComboBox anios;
        private System.Windows.Forms.ComboBox modelos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearTesla;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        private void btnCrearTesla_Click_(object sender, EventArgs e)
        {
            // Crear un nuevo vehículo Tesla con los valores ingresados por el usuario
            Tesla newTesla = new Tesla()
            {
                Model = modelos.SelectedItem.ToString(),
                Year = int.Parse(anios.SelectedItem.ToString()),
                Usage = int.Parse(kmActuales.Text),
                Color = colores.SelectedItem.ToString(),
                Owner = duenio.Text
            };

            // Agregar el nuevo vehículo a la lista de vehículos
            vehiculos.Add(newTesla);

            // Actualizar el DataGridView para mostrar el nuevo vehículo
            dgv_tesla.DataSource = null;
            dgv_tesla.DataSource = vehiculos;
        }
    }
}