namespace CalculoDeRafagasCPU
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_DatosProcesos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_Procesos = new System.Windows.Forms.GroupBox();
            this.txt_CPU5 = new System.Windows.Forms.TextBox();
            this.txt_CPU4 = new System.Windows.Forms.TextBox();
            this.txt_CPU3 = new System.Windows.Forms.TextBox();
            this.txt_CPU2 = new System.Windows.Forms.TextBox();
            this.txt_CPU1 = new System.Windows.Forms.TextBox();
            this.btn_IngresoProcesos = new System.Windows.Forms.Button();
            this.dgv_Tabla = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdb_AlgoritmoFCFS = new System.Windows.Forms.RadioButton();
            this.rdb_AlgoritmoSJF = new System.Windows.Forms.RadioButton();
            this.rdb_AlgoritmoPrioridad = new System.Windows.Forms.RadioButton();
            this.rdb_AlgoritmoRR = new System.Windows.Forms.RadioButton();
            this.gpb_algoritmos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Quantum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TME = new System.Windows.Forms.Label();
            this.lbl_TMR = new System.Windows.Forms.Label();
            this.dgv_TablaRecorrido = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpb_Prioridad = new System.Windows.Forms.GroupBox();
            this.txt_Prioridad5 = new System.Windows.Forms.TextBox();
            this.txt_Prioridad4 = new System.Windows.Forms.TextBox();
            this.txt_Prioridad3 = new System.Windows.Forms.TextBox();
            this.txt_Prioridad2 = new System.Windows.Forms.TextBox();
            this.txt_Prioridad1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DatosProcesos)).BeginInit();
            this.gpb_Procesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tabla)).BeginInit();
            this.gpb_algoritmos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaRecorrido)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.gpb_Prioridad.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DatosProcesos
            // 
            this.dgv_DatosProcesos.AllowUserToAddRows = false;
            this.dgv_DatosProcesos.AllowUserToDeleteRows = false;
            this.dgv_DatosProcesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DatosProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DatosProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_DatosProcesos.Location = new System.Drawing.Point(377, 84);
            this.dgv_DatosProcesos.Name = "dgv_DatosProcesos";
            this.dgv_DatosProcesos.ReadOnly = true;
            this.dgv_DatosProcesos.RowHeadersVisible = false;
            this.dgv_DatosProcesos.Size = new System.Drawing.Size(309, 165);
            this.dgv_DatosProcesos.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Procesos";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CPU";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prioridad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // gpb_Procesos
            // 
            this.gpb_Procesos.Controls.Add(this.txt_CPU5);
            this.gpb_Procesos.Controls.Add(this.txt_CPU4);
            this.gpb_Procesos.Controls.Add(this.txt_CPU3);
            this.gpb_Procesos.Controls.Add(this.txt_CPU2);
            this.gpb_Procesos.Controls.Add(this.txt_CPU1);
            this.gpb_Procesos.Font = new System.Drawing.Font("Consolas", 9F);
            this.gpb_Procesos.Location = new System.Drawing.Point(14, 50);
            this.gpb_Procesos.Name = "gpb_Procesos";
            this.gpb_Procesos.Size = new System.Drawing.Size(85, 162);
            this.gpb_Procesos.TabIndex = 5;
            this.gpb_Procesos.TabStop = false;
            this.gpb_Procesos.Text = "Procesos";
            // 
            // txt_CPU5
            // 
            this.txt_CPU5.Location = new System.Drawing.Point(6, 126);
            this.txt_CPU5.MaxLength = 3;
            this.txt_CPU5.Name = "txt_CPU5";
            this.txt_CPU5.ShortcutsEnabled = false;
            this.txt_CPU5.Size = new System.Drawing.Size(57, 22);
            this.txt_CPU5.TabIndex = 4;
            this.txt_CPU5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarDatos);
            // 
            // txt_CPU4
            // 
            this.txt_CPU4.Location = new System.Drawing.Point(6, 100);
            this.txt_CPU4.MaxLength = 3;
            this.txt_CPU4.Name = "txt_CPU4";
            this.txt_CPU4.ShortcutsEnabled = false;
            this.txt_CPU4.Size = new System.Drawing.Size(57, 22);
            this.txt_CPU4.TabIndex = 3;
            this.txt_CPU4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarDatos);
            // 
            // txt_CPU3
            // 
            this.txt_CPU3.Location = new System.Drawing.Point(6, 71);
            this.txt_CPU3.MaxLength = 3;
            this.txt_CPU3.Name = "txt_CPU3";
            this.txt_CPU3.ShortcutsEnabled = false;
            this.txt_CPU3.Size = new System.Drawing.Size(57, 22);
            this.txt_CPU3.TabIndex = 2;
            this.txt_CPU3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarDatos);
            // 
            // txt_CPU2
            // 
            this.txt_CPU2.Location = new System.Drawing.Point(6, 45);
            this.txt_CPU2.MaxLength = 3;
            this.txt_CPU2.Name = "txt_CPU2";
            this.txt_CPU2.ShortcutsEnabled = false;
            this.txt_CPU2.Size = new System.Drawing.Size(57, 22);
            this.txt_CPU2.TabIndex = 1;
            this.txt_CPU2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarDatos);
            // 
            // txt_CPU1
            // 
            this.txt_CPU1.Location = new System.Drawing.Point(6, 19);
            this.txt_CPU1.MaxLength = 3;
            this.txt_CPU1.Name = "txt_CPU1";
            this.txt_CPU1.ShortcutsEnabled = false;
            this.txt_CPU1.Size = new System.Drawing.Size(57, 22);
            this.txt_CPU1.TabIndex = 0;
            this.txt_CPU1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarDatos);
            // 
            // btn_IngresoProcesos
            // 
            this.btn_IngresoProcesos.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IngresoProcesos.Location = new System.Drawing.Point(111, 245);
            this.btn_IngresoProcesos.Name = "btn_IngresoProcesos";
            this.btn_IngresoProcesos.Size = new System.Drawing.Size(87, 23);
            this.btn_IngresoProcesos.TabIndex = 6;
            this.btn_IngresoProcesos.Text = "&Calcular";
            this.btn_IngresoProcesos.UseVisualStyleBackColor = true;
            this.btn_IngresoProcesos.Click += new System.EventHandler(this.btn_IngresoProcesos_Click);
            // 
            // dgv_Tabla
            // 
            this.dgv_Tabla.AllowUserToAddRows = false;
            this.dgv_Tabla.AllowUserToDeleteRows = false;
            this.dgv_Tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_Tabla.Location = new System.Drawing.Point(738, 84);
            this.dgv_Tabla.Name = "dgv_Tabla";
            this.dgv_Tabla.ReadOnly = true;
            this.dgv_Tabla.RowHeadersVisible = false;
            this.dgv_Tabla.Size = new System.Drawing.Size(307, 163);
            this.dgv_Tabla.TabIndex = 12;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Trabajo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tiempo de espera";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tiempo de retorno";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // rdb_AlgoritmoFCFS
            // 
            this.rdb_AlgoritmoFCFS.AutoSize = true;
            this.rdb_AlgoritmoFCFS.Checked = true;
            this.rdb_AlgoritmoFCFS.Location = new System.Drawing.Point(18, 28);
            this.rdb_AlgoritmoFCFS.Name = "rdb_AlgoritmoFCFS";
            this.rdb_AlgoritmoFCFS.Size = new System.Drawing.Size(53, 18);
            this.rdb_AlgoritmoFCFS.TabIndex = 14;
            this.rdb_AlgoritmoFCFS.TabStop = true;
            this.rdb_AlgoritmoFCFS.Text = "FCFS";
            this.rdb_AlgoritmoFCFS.UseVisualStyleBackColor = true;
            this.rdb_AlgoritmoFCFS.CheckedChanged += new System.EventHandler(this.rdb_AlgoritmoFCFS_CheckedChanged);
            // 
            // rdb_AlgoritmoSJF
            // 
            this.rdb_AlgoritmoSJF.AutoSize = true;
            this.rdb_AlgoritmoSJF.Location = new System.Drawing.Point(18, 51);
            this.rdb_AlgoritmoSJF.Name = "rdb_AlgoritmoSJF";
            this.rdb_AlgoritmoSJF.Size = new System.Drawing.Size(46, 18);
            this.rdb_AlgoritmoSJF.TabIndex = 15;
            this.rdb_AlgoritmoSJF.Text = "SJF";
            this.rdb_AlgoritmoSJF.UseVisualStyleBackColor = true;
            this.rdb_AlgoritmoSJF.CheckedChanged += new System.EventHandler(this.rdb_AlgoritmoSJF_CheckedChanged);
            // 
            // rdb_AlgoritmoPrioridad
            // 
            this.rdb_AlgoritmoPrioridad.AutoSize = true;
            this.rdb_AlgoritmoPrioridad.Location = new System.Drawing.Point(18, 74);
            this.rdb_AlgoritmoPrioridad.Name = "rdb_AlgoritmoPrioridad";
            this.rdb_AlgoritmoPrioridad.Size = new System.Drawing.Size(88, 18);
            this.rdb_AlgoritmoPrioridad.TabIndex = 16;
            this.rdb_AlgoritmoPrioridad.Text = "PRIORIDAD";
            this.rdb_AlgoritmoPrioridad.UseVisualStyleBackColor = true;
            this.rdb_AlgoritmoPrioridad.CheckedChanged += new System.EventHandler(this.rdb_AlgoritmoPrioridad_CheckedChanged);
            // 
            // rdb_AlgoritmoRR
            // 
            this.rdb_AlgoritmoRR.AutoSize = true;
            this.rdb_AlgoritmoRR.Location = new System.Drawing.Point(18, 97);
            this.rdb_AlgoritmoRR.Name = "rdb_AlgoritmoRR";
            this.rdb_AlgoritmoRR.Size = new System.Drawing.Size(39, 18);
            this.rdb_AlgoritmoRR.TabIndex = 17;
            this.rdb_AlgoritmoRR.Text = "RR";
            this.rdb_AlgoritmoRR.UseVisualStyleBackColor = true;
            this.rdb_AlgoritmoRR.CheckedChanged += new System.EventHandler(this.rdb_AlgoritmoRR_CheckedChanged);
            // 
            // gpb_algoritmos
            // 
            this.gpb_algoritmos.Controls.Add(this.label1);
            this.gpb_algoritmos.Controls.Add(this.txt_Quantum);
            this.gpb_algoritmos.Controls.Add(this.rdb_AlgoritmoFCFS);
            this.gpb_algoritmos.Controls.Add(this.rdb_AlgoritmoRR);
            this.gpb_algoritmos.Controls.Add(this.rdb_AlgoritmoSJF);
            this.gpb_algoritmos.Controls.Add(this.rdb_AlgoritmoPrioridad);
            this.gpb_algoritmos.Font = new System.Drawing.Font("Consolas", 9F);
            this.gpb_algoritmos.Location = new System.Drawing.Point(193, 50);
            this.gpb_algoritmos.Name = "gpb_algoritmos";
            this.gpb_algoritmos.Size = new System.Drawing.Size(120, 162);
            this.gpb_algoritmos.TabIndex = 18;
            this.gpb_algoritmos.TabStop = false;
            this.gpb_algoritmos.Text = "Tipo De Algoritmos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quantum";
            // 
            // txt_Quantum
            // 
            this.txt_Quantum.Location = new System.Drawing.Point(65, 130);
            this.txt_Quantum.MaxLength = 2;
            this.txt_Quantum.Name = "txt_Quantum";
            this.txt_Quantum.ShortcutsEnabled = false;
            this.txt_Quantum.Size = new System.Drawing.Size(49, 22);
            this.txt_Quantum.TabIndex = 18;
            this.txt_Quantum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarDatos);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_TME);
            this.groupBox1.Controls.Add(this.lbl_TMR);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 131);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TME/TMR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "TMR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "TME:";
            // 
            // lbl_TME
            // 
            this.lbl_TME.AutoSize = true;
            this.lbl_TME.Location = new System.Drawing.Point(75, 40);
            this.lbl_TME.Name = "lbl_TME";
            this.lbl_TME.Size = new System.Drawing.Size(47, 12);
            this.lbl_TME.TabIndex = 19;
            this.lbl_TME.Text = "label2";
            // 
            // lbl_TMR
            // 
            this.lbl_TMR.AutoSize = true;
            this.lbl_TMR.Location = new System.Drawing.Point(75, 90);
            this.lbl_TMR.Name = "lbl_TMR";
            this.lbl_TMR.Size = new System.Drawing.Size(47, 12);
            this.lbl_TMR.TabIndex = 20;
            this.lbl_TMR.Text = "label3";
            // 
            // dgv_TablaRecorrido
            // 
            this.dgv_TablaRecorrido.AllowUserToAddRows = false;
            this.dgv_TablaRecorrido.AllowUserToDeleteRows = false;
            this.dgv_TablaRecorrido.AllowUserToResizeColumns = false;
            this.dgv_TablaRecorrido.AllowUserToResizeRows = false;
            this.dgv_TablaRecorrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TablaRecorrido.Location = new System.Drawing.Point(410, 351);
            this.dgv_TablaRecorrido.Name = "dgv_TablaRecorrido";
            this.dgv_TablaRecorrido.ReadOnly = true;
            this.dgv_TablaRecorrido.RowHeadersVisible = false;
            this.dgv_TablaRecorrido.Size = new System.Drawing.Size(616, 63);
            this.dgv_TablaRecorrido.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 39);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Calculo De Rafagas de CPU";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(1079, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.gpb_Prioridad);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.gpb_Procesos);
            this.panel2.Controls.Add(this.gpb_algoritmos);
            this.panel2.Controls.Add(this.btn_IngresoProcesos);
            this.panel2.Location = new System.Drawing.Point(-2, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 466);
            this.panel2.TabIndex = 27;
            // 
            // gpb_Prioridad
            // 
            this.gpb_Prioridad.Controls.Add(this.txt_Prioridad5);
            this.gpb_Prioridad.Controls.Add(this.txt_Prioridad4);
            this.gpb_Prioridad.Controls.Add(this.txt_Prioridad3);
            this.gpb_Prioridad.Controls.Add(this.txt_Prioridad2);
            this.gpb_Prioridad.Controls.Add(this.txt_Prioridad1);
            this.gpb_Prioridad.Font = new System.Drawing.Font("Consolas", 9F);
            this.gpb_Prioridad.Location = new System.Drawing.Point(102, 50);
            this.gpb_Prioridad.Name = "gpb_Prioridad";
            this.gpb_Prioridad.Size = new System.Drawing.Size(85, 162);
            this.gpb_Prioridad.TabIndex = 6;
            this.gpb_Prioridad.TabStop = false;
            this.gpb_Prioridad.Text = "Prioridad";
            // 
            // txt_Prioridad5
            // 
            this.txt_Prioridad5.Location = new System.Drawing.Point(6, 126);
            this.txt_Prioridad5.MaxLength = 2;
            this.txt_Prioridad5.Name = "txt_Prioridad5";
            this.txt_Prioridad5.ShortcutsEnabled = false;
            this.txt_Prioridad5.Size = new System.Drawing.Size(57, 22);
            this.txt_Prioridad5.TabIndex = 4;
            this.txt_Prioridad5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarDatoPrioridad);
            // 
            // txt_Prioridad4
            // 
            this.txt_Prioridad4.Location = new System.Drawing.Point(6, 100);
            this.txt_Prioridad4.MaxLength = 2;
            this.txt_Prioridad4.Name = "txt_Prioridad4";
            this.txt_Prioridad4.ShortcutsEnabled = false;
            this.txt_Prioridad4.Size = new System.Drawing.Size(57, 22);
            this.txt_Prioridad4.TabIndex = 3;
            this.txt_Prioridad4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarDatoPrioridad);
            // 
            // txt_Prioridad3
            // 
            this.txt_Prioridad3.Location = new System.Drawing.Point(6, 71);
            this.txt_Prioridad3.MaxLength = 2;
            this.txt_Prioridad3.Name = "txt_Prioridad3";
            this.txt_Prioridad3.ShortcutsEnabled = false;
            this.txt_Prioridad3.Size = new System.Drawing.Size(57, 22);
            this.txt_Prioridad3.TabIndex = 2;
            this.txt_Prioridad3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarDatoPrioridad);
            // 
            // txt_Prioridad2
            // 
            this.txt_Prioridad2.Location = new System.Drawing.Point(6, 45);
            this.txt_Prioridad2.MaxLength = 2;
            this.txt_Prioridad2.Name = "txt_Prioridad2";
            this.txt_Prioridad2.ShortcutsEnabled = false;
            this.txt_Prioridad2.Size = new System.Drawing.Size(57, 22);
            this.txt_Prioridad2.TabIndex = 1;
            this.txt_Prioridad2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarDatoPrioridad);
            // 
            // txt_Prioridad1
            // 
            this.txt_Prioridad1.Location = new System.Drawing.Point(6, 19);
            this.txt_Prioridad1.MaxLength = 2;
            this.txt_Prioridad1.Name = "txt_Prioridad1";
            this.txt_Prioridad1.ShortcutsEnabled = false;
            this.txt_Prioridad1.Size = new System.Drawing.Size(57, 22);
            this.txt_Prioridad1.TabIndex = 0;
            this.txt_Prioridad1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarDatoPrioridad);
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(338, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 459);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tablas De Procesos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1113, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_TablaRecorrido);
            this.Controls.Add(this.dgv_Tabla);
            this.Controls.Add(this.dgv_DatosProcesos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DatosProcesos)).EndInit();
            this.gpb_Procesos.ResumeLayout(false);
            this.gpb_Procesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tabla)).EndInit();
            this.gpb_algoritmos.ResumeLayout(false);
            this.gpb_algoritmos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaRecorrido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gpb_Prioridad.ResumeLayout(false);
            this.gpb_Prioridad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DatosProcesos;
        private System.Windows.Forms.GroupBox gpb_Procesos;
        private System.Windows.Forms.TextBox txt_CPU3;
        private System.Windows.Forms.TextBox txt_CPU2;
        private System.Windows.Forms.TextBox txt_CPU1;
        private System.Windows.Forms.DataGridView dgv_Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.RadioButton rdb_AlgoritmoFCFS;
        private System.Windows.Forms.RadioButton rdb_AlgoritmoSJF;
        private System.Windows.Forms.RadioButton rdb_AlgoritmoPrioridad;
        private System.Windows.Forms.RadioButton rdb_AlgoritmoRR;
        private System.Windows.Forms.GroupBox gpb_algoritmos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TME;
        private System.Windows.Forms.Label lbl_TMR;
        private System.Windows.Forms.DataGridView dgv_TablaRecorrido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Quantum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_CPU5;
        private System.Windows.Forms.TextBox txt_CPU4;
        private System.Windows.Forms.Button btn_IngresoProcesos;
        private System.Windows.Forms.GroupBox gpb_Prioridad;
        private System.Windows.Forms.TextBox txt_Prioridad5;
        private System.Windows.Forms.TextBox txt_Prioridad4;
        private System.Windows.Forms.TextBox txt_Prioridad3;
        private System.Windows.Forms.TextBox txt_Prioridad2;
        private System.Windows.Forms.TextBox txt_Prioridad1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

