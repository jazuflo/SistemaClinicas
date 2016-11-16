namespace DemoWF13
{
    partial class frmClinica
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpbCondicion = new System.Windows.Forms.GroupBox();
            this.rbtCondicionE = new System.Windows.Forms.RadioButton();
            this.rbtCondicionD = new System.Windows.Forms.RadioButton();
            this.rbtCondicionC = new System.Windows.Forms.RadioButton();
            this.rbtCondicionB = new System.Windows.Forms.RadioButton();
            this.rbtCondicionA = new System.Windows.Forms.RadioButton();
            this.gpbAnalisis = new System.Windows.Forms.GroupBox();
            this.nudCostoAnalisis = new System.Windows.Forms.NumericUpDown();
            this.chkOrina = new System.Windows.Forms.CheckBox();
            this.chkSangre = new System.Windows.Forms.CheckBox();
            this.rbtTipoAB2 = new System.Windows.Forms.RadioButton();
            this.rbtTipoAB1 = new System.Windows.Forms.RadioButton();
            this.rbtTipoB2 = new System.Windows.Forms.RadioButton();
            this.rbtTipoO2 = new System.Windows.Forms.RadioButton();
            this.rbtTipoO1 = new System.Windows.Forms.RadioButton();
            this.rbtTipoB1 = new System.Windows.Forms.RadioButton();
            this.rbtTipoA2 = new System.Windows.Forms.RadioButton();
            this.Label5 = new System.Windows.Forms.Label();
            this.rbtTipoA1 = new System.Windows.Forms.RadioButton();
            this.gpbEspecialidad = new System.Windows.Forms.GroupBox();
            this.nudCostoConsulta = new System.Windows.Forms.NumericUpDown();
            this.rbtPediatria = new System.Windows.Forms.RadioButton();
            this.rbtMedicina = new System.Windows.Forms.RadioButton();
            this.rbtGinecologia = new System.Windows.Forms.RadioButton();
            this.rbtOftalmologia = new System.Windows.Forms.RadioButton();
            this.rbtOdontologia = new System.Windows.Forms.RadioButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.nudSubTotal = new System.Windows.Forms.NumericUpDown();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.nudNetoPagar = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.gpbCondicion.SuspendLayout();
            this.gpbAnalisis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoAnalisis)).BeginInit();
            this.gpbEspecialidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetoPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(323, 471);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(239, 471);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(78, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(155, 471);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gpbCondicion
            // 
            this.gpbCondicion.Controls.Add(this.rbtCondicionE);
            this.gpbCondicion.Controls.Add(this.rbtCondicionD);
            this.gpbCondicion.Controls.Add(this.rbtCondicionC);
            this.gpbCondicion.Controls.Add(this.rbtCondicionB);
            this.gpbCondicion.Controls.Add(this.rbtCondicionA);
            this.gpbCondicion.Enabled = false;
            this.gpbCondicion.Location = new System.Drawing.Point(24, 331);
            this.gpbCondicion.Name = "gpbCondicion";
            this.gpbCondicion.Size = new System.Drawing.Size(377, 40);
            this.gpbCondicion.TabIndex = 3;
            this.gpbCondicion.TabStop = false;
            this.gpbCondicion.Text = "Condición Económica";
            // 
            // rbtCondicionE
            // 
            this.rbtCondicionE.AutoSize = true;
            this.rbtCondicionE.Location = new System.Drawing.Point(239, 14);
            this.rbtCondicionE.Name = "rbtCondicionE";
            this.rbtCondicionE.Size = new System.Drawing.Size(32, 17);
            this.rbtCondicionE.TabIndex = 4;
            this.rbtCondicionE.Text = "E";
            this.rbtCondicionE.UseVisualStyleBackColor = true;
            // 
            // rbtCondicionD
            // 
            this.rbtCondicionD.AutoSize = true;
            this.rbtCondicionD.Location = new System.Drawing.Point(188, 14);
            this.rbtCondicionD.Name = "rbtCondicionD";
            this.rbtCondicionD.Size = new System.Drawing.Size(33, 17);
            this.rbtCondicionD.TabIndex = 3;
            this.rbtCondicionD.TabStop = true;
            this.rbtCondicionD.Text = "D";
            this.rbtCondicionD.UseVisualStyleBackColor = true;
            // 
            // rbtCondicionC
            // 
            this.rbtCondicionC.AutoSize = true;
            this.rbtCondicionC.Location = new System.Drawing.Point(131, 15);
            this.rbtCondicionC.Name = "rbtCondicionC";
            this.rbtCondicionC.Size = new System.Drawing.Size(32, 17);
            this.rbtCondicionC.TabIndex = 2;
            this.rbtCondicionC.TabStop = true;
            this.rbtCondicionC.Text = "C";
            this.rbtCondicionC.UseVisualStyleBackColor = true;
            // 
            // rbtCondicionB
            // 
            this.rbtCondicionB.AutoSize = true;
            this.rbtCondicionB.Location = new System.Drawing.Point(76, 14);
            this.rbtCondicionB.Name = "rbtCondicionB";
            this.rbtCondicionB.Size = new System.Drawing.Size(32, 17);
            this.rbtCondicionB.TabIndex = 1;
            this.rbtCondicionB.TabStop = true;
            this.rbtCondicionB.Text = "B";
            this.rbtCondicionB.UseVisualStyleBackColor = true;
            // 
            // rbtCondicionA
            // 
            this.rbtCondicionA.AutoSize = true;
            this.rbtCondicionA.Checked = true;
            this.rbtCondicionA.Location = new System.Drawing.Point(19, 15);
            this.rbtCondicionA.Name = "rbtCondicionA";
            this.rbtCondicionA.Size = new System.Drawing.Size(32, 17);
            this.rbtCondicionA.TabIndex = 0;
            this.rbtCondicionA.TabStop = true;
            this.rbtCondicionA.Text = "A";
            this.rbtCondicionA.UseVisualStyleBackColor = true;
            // 
            // gpbAnalisis
            // 
            this.gpbAnalisis.Controls.Add(this.nudCostoAnalisis);
            this.gpbAnalisis.Controls.Add(this.chkOrina);
            this.gpbAnalisis.Controls.Add(this.chkSangre);
            this.gpbAnalisis.Controls.Add(this.rbtTipoAB2);
            this.gpbAnalisis.Controls.Add(this.rbtTipoAB1);
            this.gpbAnalisis.Controls.Add(this.rbtTipoB2);
            this.gpbAnalisis.Controls.Add(this.rbtTipoO2);
            this.gpbAnalisis.Controls.Add(this.rbtTipoO1);
            this.gpbAnalisis.Controls.Add(this.rbtTipoB1);
            this.gpbAnalisis.Controls.Add(this.rbtTipoA2);
            this.gpbAnalisis.Controls.Add(this.Label5);
            this.gpbAnalisis.Controls.Add(this.rbtTipoA1);
            this.gpbAnalisis.Enabled = false;
            this.gpbAnalisis.Location = new System.Drawing.Point(24, 229);
            this.gpbAnalisis.Name = "gpbAnalisis";
            this.gpbAnalisis.Size = new System.Drawing.Size(377, 91);
            this.gpbAnalisis.TabIndex = 2;
            this.gpbAnalisis.TabStop = false;
            this.gpbAnalisis.Text = "Análisis de Laboratorio";
            // 
            // nudCostoAnalisis
            // 
            this.nudCostoAnalisis.DecimalPlaces = 2;
            this.nudCostoAnalisis.Enabled = false;
            this.nudCostoAnalisis.ForeColor = System.Drawing.Color.Black;
            this.nudCostoAnalisis.Location = new System.Drawing.Point(125, 65);
            this.nudCostoAnalisis.Name = "nudCostoAnalisis";
            this.nudCostoAnalisis.Size = new System.Drawing.Size(103, 20);
            this.nudCostoAnalisis.TabIndex = 10;
            this.nudCostoAnalisis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkOrina
            // 
            this.chkOrina.AutoSize = true;
            this.chkOrina.Location = new System.Drawing.Point(138, 21);
            this.chkOrina.Name = "chkOrina";
            this.chkOrina.Size = new System.Drawing.Size(104, 17);
            this.chkOrina.TabIndex = 1;
            this.chkOrina.Text = "Análisis de Orina";
            this.chkOrina.UseVisualStyleBackColor = true;
            this.chkOrina.CheckedChanged += new System.EventHandler(this.CalcularCostoAnalisis);
            // 
            // chkSangre
            // 
            this.chkSangre.AutoSize = true;
            this.chkSangre.Location = new System.Drawing.Point(19, 22);
            this.chkSangre.Name = "chkSangre";
            this.chkSangre.Size = new System.Drawing.Size(113, 17);
            this.chkSangre.TabIndex = 0;
            this.chkSangre.Text = "Análisis de Sangre";
            this.chkSangre.UseVisualStyleBackColor = true;
            this.chkSangre.CheckedChanged += new System.EventHandler(this.CalcularCostoAnalisis);
            // 
            // rbtTipoAB2
            // 
            this.rbtTipoAB2.AutoSize = true;
            this.rbtTipoAB2.Location = new System.Drawing.Point(242, 43);
            this.rbtTipoAB2.Name = "rbtTipoAB2";
            this.rbtTipoAB2.Size = new System.Drawing.Size(42, 17);
            this.rbtTipoAB2.TabIndex = 7;
            this.rbtTipoAB2.TabStop = true;
            this.rbtTipoAB2.Text = "AB-";
            this.rbtTipoAB2.UseVisualStyleBackColor = true;
            this.rbtTipoAB2.CheckedChanged += new System.EventHandler(this.DeterminarTipoSangre);
            // 
            // rbtTipoAB1
            // 
            this.rbtTipoAB1.AutoSize = true;
            this.rbtTipoAB1.Location = new System.Drawing.Point(191, 42);
            this.rbtTipoAB1.Name = "rbtTipoAB1";
            this.rbtTipoAB1.Size = new System.Drawing.Size(45, 17);
            this.rbtTipoAB1.TabIndex = 6;
            this.rbtTipoAB1.TabStop = true;
            this.rbtTipoAB1.Text = "AB+";
            this.rbtTipoAB1.UseVisualStyleBackColor = true;
            this.rbtTipoAB1.CheckedChanged += new System.EventHandler(this.DeterminarTipoSangre);
            // 
            // rbtTipoB2
            // 
            this.rbtTipoB2.AutoSize = true;
            this.rbtTipoB2.Location = new System.Drawing.Point(148, 42);
            this.rbtTipoB2.Name = "rbtTipoB2";
            this.rbtTipoB2.Size = new System.Drawing.Size(35, 17);
            this.rbtTipoB2.TabIndex = 5;
            this.rbtTipoB2.TabStop = true;
            this.rbtTipoB2.Text = "B-";
            this.rbtTipoB2.UseVisualStyleBackColor = true;
            this.rbtTipoB2.CheckedChanged += new System.EventHandler(this.DeterminarTipoSangre);
            // 
            // rbtTipoO2
            // 
            this.rbtTipoO2.AutoSize = true;
            this.rbtTipoO2.Location = new System.Drawing.Point(332, 43);
            this.rbtTipoO2.Name = "rbtTipoO2";
            this.rbtTipoO2.Size = new System.Drawing.Size(36, 17);
            this.rbtTipoO2.TabIndex = 9;
            this.rbtTipoO2.TabStop = true;
            this.rbtTipoO2.Text = "O-";
            this.rbtTipoO2.UseVisualStyleBackColor = true;
            this.rbtTipoO2.CheckedChanged += new System.EventHandler(this.DeterminarTipoSangre);
            // 
            // rbtTipoO1
            // 
            this.rbtTipoO1.AutoSize = true;
            this.rbtTipoO1.Location = new System.Drawing.Point(288, 43);
            this.rbtTipoO1.Name = "rbtTipoO1";
            this.rbtTipoO1.Size = new System.Drawing.Size(39, 17);
            this.rbtTipoO1.TabIndex = 8;
            this.rbtTipoO1.TabStop = true;
            this.rbtTipoO1.Text = "O+";
            this.rbtTipoO1.UseVisualStyleBackColor = true;
            this.rbtTipoO1.CheckedChanged += new System.EventHandler(this.DeterminarTipoSangre);
            // 
            // rbtTipoB1
            // 
            this.rbtTipoB1.AutoSize = true;
            this.rbtTipoB1.Location = new System.Drawing.Point(107, 43);
            this.rbtTipoB1.Name = "rbtTipoB1";
            this.rbtTipoB1.Size = new System.Drawing.Size(38, 17);
            this.rbtTipoB1.TabIndex = 4;
            this.rbtTipoB1.TabStop = true;
            this.rbtTipoB1.Text = "B+";
            this.rbtTipoB1.UseVisualStyleBackColor = true;
            this.rbtTipoB1.CheckedChanged += new System.EventHandler(this.DeterminarTipoSangre);
            // 
            // rbtTipoA2
            // 
            this.rbtTipoA2.AutoSize = true;
            this.rbtTipoA2.Location = new System.Drawing.Point(64, 43);
            this.rbtTipoA2.Name = "rbtTipoA2";
            this.rbtTipoA2.Size = new System.Drawing.Size(35, 17);
            this.rbtTipoA2.TabIndex = 3;
            this.rbtTipoA2.TabStop = true;
            this.rbtTipoA2.Text = "A-";
            this.rbtTipoA2.UseVisualStyleBackColor = true;
            this.rbtTipoA2.CheckedChanged += new System.EventHandler(this.DeterminarTipoSangre);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(18, 69);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(90, 13);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Costo Análisis S/.";
            // 
            // rbtTipoA1
            // 
            this.rbtTipoA1.AutoSize = true;
            this.rbtTipoA1.Checked = true;
            this.rbtTipoA1.Location = new System.Drawing.Point(19, 43);
            this.rbtTipoA1.Name = "rbtTipoA1";
            this.rbtTipoA1.Size = new System.Drawing.Size(38, 17);
            this.rbtTipoA1.TabIndex = 2;
            this.rbtTipoA1.TabStop = true;
            this.rbtTipoA1.Text = "A+";
            this.rbtTipoA1.UseVisualStyleBackColor = true;
            this.rbtTipoA1.CheckedChanged += new System.EventHandler(this.DeterminarTipoSangre);
            // 
            // gpbEspecialidad
            // 
            this.gpbEspecialidad.Controls.Add(this.nudCostoConsulta);
            this.gpbEspecialidad.Controls.Add(this.rbtPediatria);
            this.gpbEspecialidad.Controls.Add(this.rbtMedicina);
            this.gpbEspecialidad.Controls.Add(this.rbtGinecologia);
            this.gpbEspecialidad.Controls.Add(this.rbtOftalmologia);
            this.gpbEspecialidad.Controls.Add(this.rbtOdontologia);
            this.gpbEspecialidad.Controls.Add(this.Label4);
            this.gpbEspecialidad.Enabled = false;
            this.gpbEspecialidad.Location = new System.Drawing.Point(24, 127);
            this.gpbEspecialidad.Name = "gpbEspecialidad";
            this.gpbEspecialidad.Size = new System.Drawing.Size(377, 95);
            this.gpbEspecialidad.TabIndex = 1;
            this.gpbEspecialidad.TabStop = false;
            this.gpbEspecialidad.Text = "Especialidad";
            // 
            // nudCostoConsulta
            // 
            this.nudCostoConsulta.DecimalPlaces = 2;
            this.nudCostoConsulta.Enabled = false;
            this.nudCostoConsulta.ForeColor = System.Drawing.Color.Black;
            this.nudCostoConsulta.Location = new System.Drawing.Point(125, 65);
            this.nudCostoConsulta.Name = "nudCostoConsulta";
            this.nudCostoConsulta.Size = new System.Drawing.Size(103, 20);
            this.nudCostoConsulta.TabIndex = 6;
            this.nudCostoConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCostoConsulta.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // rbtPediatria
            // 
            this.rbtPediatria.AutoSize = true;
            this.rbtPediatria.Location = new System.Drawing.Point(249, 19);
            this.rbtPediatria.Name = "rbtPediatria";
            this.rbtPediatria.Size = new System.Drawing.Size(68, 17);
            this.rbtPediatria.TabIndex = 2;
            this.rbtPediatria.TabStop = true;
            this.rbtPediatria.Text = "Pediatría";
            this.rbtPediatria.UseVisualStyleBackColor = true;
            this.rbtPediatria.CheckedChanged += new System.EventHandler(this.CalcularCostoConsulta);
            // 
            // rbtMedicina
            // 
            this.rbtMedicina.AutoSize = true;
            this.rbtMedicina.Location = new System.Drawing.Point(125, 42);
            this.rbtMedicina.Name = "rbtMedicina";
            this.rbtMedicina.Size = new System.Drawing.Size(108, 17);
            this.rbtMedicina.TabIndex = 4;
            this.rbtMedicina.TabStop = true;
            this.rbtMedicina.Text = "Medicina General";
            this.rbtMedicina.UseVisualStyleBackColor = true;
            this.rbtMedicina.CheckedChanged += new System.EventHandler(this.CalcularCostoConsulta);
            // 
            // rbtGinecologia
            // 
            this.rbtGinecologia.AutoSize = true;
            this.rbtGinecologia.Location = new System.Drawing.Point(19, 42);
            this.rbtGinecologia.Name = "rbtGinecologia";
            this.rbtGinecologia.Size = new System.Drawing.Size(83, 17);
            this.rbtGinecologia.TabIndex = 3;
            this.rbtGinecologia.TabStop = true;
            this.rbtGinecologia.Text = "Ginecología";
            this.rbtGinecologia.UseVisualStyleBackColor = true;
            this.rbtGinecologia.CheckedChanged += new System.EventHandler(this.CalcularCostoConsulta);
            // 
            // rbtOftalmologia
            // 
            this.rbtOftalmologia.AutoSize = true;
            this.rbtOftalmologia.Location = new System.Drawing.Point(125, 19);
            this.rbtOftalmologia.Name = "rbtOftalmologia";
            this.rbtOftalmologia.Size = new System.Drawing.Size(85, 17);
            this.rbtOftalmologia.TabIndex = 1;
            this.rbtOftalmologia.TabStop = true;
            this.rbtOftalmologia.Text = "Oftalmología";
            this.rbtOftalmologia.UseVisualStyleBackColor = true;
            this.rbtOftalmologia.CheckedChanged += new System.EventHandler(this.CalcularCostoConsulta);
            // 
            // rbtOdontologia
            // 
            this.rbtOdontologia.AutoSize = true;
            this.rbtOdontologia.Checked = true;
            this.rbtOdontologia.Location = new System.Drawing.Point(19, 19);
            this.rbtOdontologia.Name = "rbtOdontologia";
            this.rbtOdontologia.Size = new System.Drawing.Size(84, 17);
            this.rbtOdontologia.TabIndex = 0;
            this.rbtOdontologia.TabStop = true;
            this.rbtOdontologia.Text = "Odontología";
            this.rbtOdontologia.UseVisualStyleBackColor = true;
            this.rbtOdontologia.CheckedChanged += new System.EventHandler(this.CalcularCostoConsulta);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(18, 71);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(96, 13);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Costo Consulta S/.";
            // 
            // txtPaciente
            // 
            this.txtPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(93, 97);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(308, 20);
            this.txtPaciente.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(21, 100);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 13);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Paciente";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(249, 386);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(88, 13);
            this.Label8.TabIndex = 16;
            this.Label8.Text = "Neto a Pagar S/.";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(135, 386);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(77, 13);
            this.Label7.TabIndex = 17;
            this.Label7.Text = "Descuento S/.";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(22, 386);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(71, 13);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Sub Total S/.";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(301, 63);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 12;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(209, 68);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 13);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Nro. de Consulta";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(-5, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(437, 39);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Registro de Consultas Médicas";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSubTotal
            // 
            this.nudSubTotal.DecimalPlaces = 2;
            this.nudSubTotal.Enabled = false;
            this.nudSubTotal.ForeColor = System.Drawing.Color.Black;
            this.nudSubTotal.Location = new System.Drawing.Point(25, 404);
            this.nudSubTotal.Name = "nudSubTotal";
            this.nudSubTotal.Size = new System.Drawing.Size(103, 20);
            this.nudSubTotal.TabIndex = 5;
            this.nudSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudDescuento
            // 
            this.nudDescuento.DecimalPlaces = 2;
            this.nudDescuento.Enabled = false;
            this.nudDescuento.ForeColor = System.Drawing.Color.Black;
            this.nudDescuento.Location = new System.Drawing.Point(138, 404);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(103, 20);
            this.nudDescuento.TabIndex = 6;
            this.nudDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudNetoPagar
            // 
            this.nudNetoPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nudNetoPagar.DecimalPlaces = 2;
            this.nudNetoPagar.Enabled = false;
            this.nudNetoPagar.ForeColor = System.Drawing.Color.White;
            this.nudNetoPagar.Location = new System.Drawing.Point(251, 404);
            this.nudNetoPagar.Name = "nudNetoPagar";
            this.nudNetoPagar.Size = new System.Drawing.Size(103, 20);
            this.nudNetoPagar.TabIndex = 7;
            this.nudNetoPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(29, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tipo Sangre";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipo.Location = new System.Drawing.Point(24, 459);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(86, 31);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 516);
            this.Controls.Add(this.nudNetoPagar);
            this.Controls.Add(this.nudDescuento);
            this.Controls.Add(this.nudSubTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gpbCondicion);
            this.Controls.Add(this.gpbAnalisis);
            this.Controls.Add(this.gpbEspecialidad);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica \"Internacional\"";
            this.gpbCondicion.ResumeLayout(false);
            this.gpbCondicion.PerformLayout();
            this.gpbAnalisis.ResumeLayout(false);
            this.gpbAnalisis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoAnalisis)).EndInit();
            this.gpbEspecialidad.ResumeLayout(false);
            this.gpbEspecialidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetoPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.GroupBox gpbCondicion;
        internal System.Windows.Forms.RadioButton rbtCondicionE;
        internal System.Windows.Forms.RadioButton rbtCondicionD;
        internal System.Windows.Forms.RadioButton rbtCondicionC;
        internal System.Windows.Forms.RadioButton rbtCondicionB;
        internal System.Windows.Forms.RadioButton rbtCondicionA;
        internal System.Windows.Forms.GroupBox gpbAnalisis;
        private System.Windows.Forms.NumericUpDown nudCostoAnalisis;
        internal System.Windows.Forms.CheckBox chkOrina;
        internal System.Windows.Forms.CheckBox chkSangre;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox gpbEspecialidad;
        private System.Windows.Forms.NumericUpDown nudCostoConsulta;
        internal System.Windows.Forms.RadioButton rbtPediatria;
        internal System.Windows.Forms.RadioButton rbtMedicina;
        internal System.Windows.Forms.RadioButton rbtGinecologia;
        internal System.Windows.Forms.RadioButton rbtOftalmologia;
        internal System.Windows.Forms.RadioButton rbtOdontologia;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtPaciente;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtNumero;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.NumericUpDown nudSubTotal;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.NumericUpDown nudNetoPagar;
        internal System.Windows.Forms.RadioButton rbtTipoAB2;
        internal System.Windows.Forms.RadioButton rbtTipoAB1;
        internal System.Windows.Forms.RadioButton rbtTipoB2;
        internal System.Windows.Forms.RadioButton rbtTipoO2;
        internal System.Windows.Forms.RadioButton rbtTipoO1;
        internal System.Windows.Forms.RadioButton rbtTipoB1;
        internal System.Windows.Forms.RadioButton rbtTipoA2;
        internal System.Windows.Forms.RadioButton rbtTipoA1;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label lblTipo;
    }
}

