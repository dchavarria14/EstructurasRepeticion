namespace pjControlRegistroParticipantes
{
    partial class frmParticipantes
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtParticipantes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lvParticipantes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label11 = new System.Windows.Forms.Label();
            this.lvEstadisticas = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tHora = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de Registro de Participante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(121, 33);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(38, 15);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(121, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(121, 104);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 15);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nombre Completo del Participante";
            // 
            // txtParticipantes
            // 
            this.txtParticipantes.Location = new System.Drawing.Point(26, 179);
            this.txtParticipantes.Name = "txtParticipantes";
            this.txtParticipantes.Size = new System.Drawing.Size(368, 23);
            this.txtParticipantes.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cargo";
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Jefe",
            "Operario",
            "Administrativo",
            "Practicante "});
            this.cboCargo.Location = new System.Drawing.Point(425, 179);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(195, 23);
            this.cboCargo.TabIndex = 10;
            this.cboCargo.Text = "(Seleccione el cargo)";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(713, 179);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Listado de Participantes";
            // 
            // lvParticipantes
            // 
            this.lvParticipantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvParticipantes.GridLines = true;
            this.lvParticipantes.Location = new System.Drawing.Point(26, 255);
            this.lvParticipantes.Name = "lvParticipantes";
            this.lvParticipantes.Size = new System.Drawing.Size(762, 119);
            this.lvParticipantes.TabIndex = 13;
            this.lvParticipantes.UseCompatibleStateImageBehavior = false;
            this.lvParticipantes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Número";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Participante";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cargo";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hora";
            this.columnHeader5.Width = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "Estadísticas";
            // 
            // lvEstadisticas
            // 
            this.lvEstadisticas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.lvEstadisticas.GridLines = true;
            this.lvEstadisticas.Location = new System.Drawing.Point(26, 424);
            this.lvEstadisticas.Name = "lvEstadisticas";
            this.lvEstadisticas.Size = new System.Drawing.Size(517, 97);
            this.lvEstadisticas.TabIndex = 15;
            this.lvEstadisticas.UseCompatibleStateImageBehavior = false;
            this.lvEstadisticas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cargos";
            this.columnHeader6.Width = 300;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Totalizador";
            this.columnHeader7.Width = 200;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 498);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tHora
            // 
            this.tHora.Tick += new System.EventHandler(this.tHora_Tick);
            // 
            // frmParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvEstadisticas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lvParticipantes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtParticipantes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmParticipantes";
            this.Text = "Control de Registro de Participantes";
            this.Load += new System.EventHandler(this.frmParticipantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblNumero;
        private Label label4;
        private Label lblFecha;
        private Label label6;
        private Label lblHora;
        private Label label8;
        private TextBox txtParticipantes;
        private Label label9;
        private ComboBox cboCargo;
        private Button btnRegistrar;
        private Label label10;
        private ListView lvParticipantes;
        private Label label11;
        private ListView lvEstadisticas;
        private Button btnSalir;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private System.Windows.Forms.Timer tHora;
    }
}