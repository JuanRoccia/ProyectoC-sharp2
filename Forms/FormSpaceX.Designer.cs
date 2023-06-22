namespace FERNANDES_ROCCIA_TAPIA
{
    partial class FormSpaceX
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpaceX));
            this.dgv_tesla = new System.Windows.Forms.DataGridView();
            this.duenio = new System.Windows.Forms.TextBox();
            this.colores = new System.Windows.Forms.ComboBox();
            this.hsActual = new System.Windows.Forms.TextBox();
            this.anios = new System.Windows.Forms.ComboBox();
            this.modelos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            //this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grupoDatos = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            //this.panel1 = new System.Windows.Forms.Panel();
            this.btnEscanear = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            //this.panel3 = new System.Windows.Forms.Panel();
            //this.groupBox1 = new System.Windows.Forms.GroupBox();
            //this.panel4 = new System.Windows.Forms.Panel();
            this.btnMostrarTeslaMasKm = new System.Windows.Forms.Button();
            this.labelEscaneo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tesla)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grupoDatos.SuspendLayout();
            //this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tesla
            // 
            this.dgv_tesla.AllowUserToAddRows = false;
            this.dgv_tesla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tesla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_tesla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.dgv_tesla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tesla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_tesla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tesla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tesla.ColumnHeadersHeight = 30;
            this.dgv_tesla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_tesla.EnableHeadersVisualStyles = false;
            this.dgv_tesla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.dgv_tesla.Location = new System.Drawing.Point(9, 42);
            this.dgv_tesla.Name = "dgv_tesla";
            this.dgv_tesla.ReadOnly = true;
            this.dgv_tesla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tesla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tesla.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_tesla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_tesla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tesla.Size = new System.Drawing.Size(988, 276);
            this.dgv_tesla.TabIndex = 2;
            //this.dgv_tesla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tesla_CellClick_1);
            // 
            // duenio
            // 
            this.duenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.duenio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duenio.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.errorProvider1.SetIconAlignment(this.duenio, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.duenio.Location = new System.Drawing.Point(410, 31);
            this.duenio.Name = "duenio";
            this.duenio.Size = new System.Drawing.Size(243, 22);
            this.duenio.TabIndex = 9;
            // 
            // colores
            // 
            this.colores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.colores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colores.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colores.FormattingEnabled = true;
            this.colores.Location = new System.Drawing.Point(261, 30);
            this.colores.Name = "colores";
            this.colores.Size = new System.Drawing.Size(85, 22);
            this.colores.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(233, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kms. Actuales:";
            // 
            // hsActuales
            // 
            this.hsActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.hsActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hsActual.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsActual.Location = new System.Drawing.Point(348, 76);
            this.hsActual.Margin = new System.Windows.Forms.Padding(4);
            this.hsActual.Name = "kmActuales";
            this.hsActual.Size = new System.Drawing.Size(113, 26);
            this.hsActual.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(233, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(481, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dueño:";
            // 
            // anios
            // 
            this.anios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.anios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anios.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anios.FormattingEnabled = true;
            this.anios.Location = new System.Drawing.Point(100, 76);
            this.anios.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.anios.Name = "anios";
            this.anios.Size = new System.Drawing.Size(112, 26);
            this.anios.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(547, 75);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 31);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // modelos
            // 
            this.modelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.modelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelos.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelos.FormattingEnabled = true;
            this.modelos.Location = new System.Drawing.Point(100, 37);
            this.modelos.Margin = new System.Windows.Forms.Padding(4);
            this.modelos.Name = "modelos";
            this.modelos.Size = new System.Drawing.Size(112, 26);
            this.modelos.TabIndex = 5;
            // 
            // grupoDatos
            // 
            this.grupoDatos.Controls.Add(this.duenio);
            this.grupoDatos.Controls.Add(this.panel2);
            this.grupoDatos.Controls.Add(this.label2);
            this.grupoDatos.Controls.Add(this.label3);
            this.grupoDatos.Controls.Add(this.colores);
            this.grupoDatos.Controls.Add(this.label4);
            this.grupoDatos.Controls.Add(this.hsActual);
            this.grupoDatos.Controls.Add(this.label5);
            this.grupoDatos.Controls.Add(this.label6);
            this.grupoDatos.Controls.Add(this.anios);
            this.grupoDatos.Controls.Add(this.btnGuardar);
            this.grupoDatos.Controls.Add(this.modelos);
            this.grupoDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.grupoDatos.Location = new System.Drawing.Point(12, 12);
            this.grupoDatos.Margin = new System.Windows.Forms.Padding(4);
            this.grupoDatos.Name = "grupoDatos";
            this.grupoDatos.Padding = new System.Windows.Forms.Padding(4);
            this.grupoDatos.Size = new System.Drawing.Size(658, 100);
            this.grupoDatos.TabIndex = 16;
            this.grupoDatos.TabStop = false;
            this.grupoDatos.Text = "Dar de alta un SpaceX";
            //this.grupoDatos.Enter += new System.EventHandler(this.grupoDatos_Enter);
            // 
            // duenio
            // 
            this.duenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.duenio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duenio.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duenio.Location = new System.Drawing.Point(547, 38);
            this.duenio.Margin = new System.Windows.Forms.Padding(4);
            this.duenio.Name = "duenio";
            this.duenio.Size = new System.Drawing.Size(323, 26);
            this.duenio.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(708, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 31);
            this.panel2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(41, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Año:";
            // 
            // btnMostrarTeslaMasKm
            // 
            this.btnMostrarTeslaMasKm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.btnMostrarTeslaMasKm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarTeslaMasKm.FlatAppearance.BorderSize = 0;
            this.btnMostrarTeslaMasKm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMostrarTeslaMasKm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTeslaMasKm.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnMostrarTeslaMasKm.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMostrarTeslaMasKm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarTeslaMasKm.Location = new System.Drawing.Point(441, 538);
            this.btnMostrarTeslaMasKm.Margin = new System.Windows.Forms.Padding(0);
            this.btnMostrarTeslaMasKm.Name = "btnMostrarTeslaMasKm";
            this.btnMostrarTeslaMasKm.Size = new System.Drawing.Size(385, 31);
            this.btnMostrarTeslaMasKm.TabIndex = 28;
            this.btnMostrarTeslaMasKm.Text = "Mostrar Tesla con más Kilometraje";
            this.btnMostrarTeslaMasKm.UseVisualStyleBackColor = false;
            // 
            // labelEscaneo
            // 
            this.labelEscaneo.Location = new System.Drawing.Point(55, 573);
            this.labelEscaneo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEscaneo.Name = "labelEscaneo";
            this.labelEscaneo.Size = new System.Drawing.Size(467, 148);
            this.labelEscaneo.TabIndex = 27;
            this.labelEscaneo.Text = "Escaneo";
            this.labelEscaneo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sistema de Gestión";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(250, 538);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 31);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgv_tesla
            // 
            this.dgv_tesla.AllowUserToAddRows = false;
            this.dgv_tesla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tesla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_tesla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.dgv_tesla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tesla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_tesla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tesla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tesla.ColumnHeadersHeight = 30;
            this.dgv_tesla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_tesla.EnableHeadersVisualStyles = false;
            this.dgv_tesla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.dgv_tesla.Location = new System.Drawing.Point(13, 190);
            this.dgv_tesla.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_tesla.Name = "dgv_tesla";
            this.dgv_tesla.ReadOnly = true;
            this.dgv_tesla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tesla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tesla.RowHeadersVisible = false;
            this.dgv_tesla.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_tesla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_tesla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tesla.Size = new System.Drawing.Size(1317, 340);
            this.dgv_tesla.TabIndex = 22;
            // 
            // btnEscanear
            // 
            this.btnEscanear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.btnEscanear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscanear.FlatAppearance.BorderSize = 0;
            this.btnEscanear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEscanear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscanear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscanear.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEscanear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEscanear.Location = new System.Drawing.Point(58, 538);
            this.btnEscanear.Margin = new System.Windows.Forms.Padding(4);
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(165, 31);
            this.btnEscanear.TabIndex = 23;
            this.btnEscanear.Text = "Escanear";
            this.btnEscanear.UseVisualStyleBackColor = false;
            // 
            // FormSpaceX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1440, 862);
            this.Controls.Add(this.grupoDatos);
            this.Controls.Add(this.btnMostrarTeslaMasKm);
            this.Controls.Add(this.labelEscaneo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgv_tesla);
            this.Controls.Add(this.btnEscanear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSpaceX";
            this.Text = "FormSpaceX";
            this.grupoDatos.ResumeLayout(false);
            this.grupoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tesla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tesla;
        private System.Windows.Forms.TextBox duenio;
        private System.Windows.Forms.ComboBox colores;
        private System.Windows.Forms.TextBox hsActual;
        private System.Windows.Forms.ComboBox anios;
        private System.Windows.Forms.ComboBox modelos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEscanear;
        private System.Windows.Forms.GroupBox grupoDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEscaneo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMostrarTeslaMasKm;
    }
}