namespace CRUD_Assistant
{
    partial class Form2
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
            this.Contenedor_Principal = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FormAcademico = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FormAlumnos = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.FormGrupos = new System.Windows.Forms.Panel();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor_Principal)).BeginInit();
            this.Contenedor_Principal.Panel1.SuspendLayout();
            this.Contenedor_Principal.Panel2.SuspendLayout();
            this.Contenedor_Principal.SuspendLayout();
            this.FormAcademico.SuspendLayout();
            this.FormAlumnos.SuspendLayout();
            this.FormGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor_Principal
            // 
            this.Contenedor_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor_Principal.Location = new System.Drawing.Point(0, 0);
            this.Contenedor_Principal.Name = "Contenedor_Principal";
            this.Contenedor_Principal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Contenedor_Principal.Panel1
            // 
            this.Contenedor_Principal.Panel1.Controls.Add(this.comboBox1);
            this.Contenedor_Principal.Panel1.Controls.Add(this.label1);
            // 
            // Contenedor_Principal.Panel2
            // 
            this.Contenedor_Principal.Panel2.Controls.Add(this.FormGrupos);
            this.Contenedor_Principal.Panel2.Controls.Add(this.FormAcademico);
            this.Contenedor_Principal.Panel2.Controls.Add(this.FormAlumnos);
            this.Contenedor_Principal.Size = new System.Drawing.Size(800, 450);
            this.Contenedor_Principal.SplitterDistance = 69;
            this.Contenedor_Principal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona que quieres añadir: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Academico",
            "Grupo",
            "Estudiante"});
            this.comboBox1.Location = new System.Drawing.Point(245, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormAcademico
            // 
            this.FormAcademico.Controls.Add(this.dateTimePicker1);
            this.FormAcademico.Controls.Add(this.label5);
            this.FormAcademico.Controls.Add(this.comboBox3);
            this.FormAcademico.Controls.Add(this.label4);
            this.FormAcademico.Controls.Add(this.comboBox2);
            this.FormAcademico.Controls.Add(this.label3);
            this.FormAcademico.Controls.Add(this.textBox1);
            this.FormAcademico.Controls.Add(this.label2);
            this.FormAcademico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormAcademico.Location = new System.Drawing.Point(0, 0);
            this.FormAcademico.Name = "FormAcademico";
            this.FormAcademico.Size = new System.Drawing.Size(800, 377);
            this.FormAcademico.TabIndex = 0;
            this.FormAcademico.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Docente",
            "Administrativo",
            "Prefecto"});
            this.comboBox2.Location = new System.Drawing.Point(77, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox3.Location = new System.Drawing.Point(77, 99);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(233, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha Inicio:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // FormAlumnos
            // 
            this.FormAlumnos.Controls.Add(this.comboBox5);
            this.FormAlumnos.Controls.Add(this.comboBox4);
            this.FormAlumnos.Controls.Add(this.textBox4);
            this.FormAlumnos.Controls.Add(this.textBox3);
            this.FormAlumnos.Controls.Add(this.textBox2);
            this.FormAlumnos.Controls.Add(this.label10);
            this.FormAlumnos.Controls.Add(this.label9);
            this.FormAlumnos.Controls.Add(this.label8);
            this.FormAlumnos.Controls.Add(this.label7);
            this.FormAlumnos.Controls.Add(this.label6);
            this.FormAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormAlumnos.Location = new System.Drawing.Point(0, 0);
            this.FormAlumnos.Name = "FormAlumnos";
            this.FormAlumnos.Size = new System.Drawing.Size(800, 377);
            this.FormAlumnos.TabIndex = 9;
            this.FormAlumnos.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellidos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Grupo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Fecha Admision:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 178);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 20);
            this.textBox4.TabIndex = 8;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(77, 98);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(162, 21);
            this.comboBox4.TabIndex = 9;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Egresado"});
            this.comboBox5.Location = new System.Drawing.Point(77, 137);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(162, 21);
            this.comboBox5.TabIndex = 10;
            // 
            // FormGrupos
            // 
            this.FormGrupos.Controls.Add(this.textBox6);
            this.FormGrupos.Controls.Add(this.comboBox6);
            this.FormGrupos.Controls.Add(this.label12);
            this.FormGrupos.Controls.Add(this.label13);
            this.FormGrupos.Controls.Add(this.textBox5);
            this.FormGrupos.Controls.Add(this.label14);
            this.FormGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormGrupos.Location = new System.Drawing.Point(0, 0);
            this.FormGrupos.Name = "FormGrupos";
            this.FormGrupos.Size = new System.Drawing.Size(800, 377);
            this.FormGrupos.TabIndex = 11;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox6.Location = new System.Drawing.Point(89, 102);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(221, 21);
            this.comboBox6.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Delegado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Ciclo escolar:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(77, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(233, 20);
            this.textBox5.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Nombre:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(106, 58);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(204, 20);
            this.textBox6.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contenedor_Principal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Contenedor_Principal.Panel1.ResumeLayout(false);
            this.Contenedor_Principal.Panel1.PerformLayout();
            this.Contenedor_Principal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor_Principal)).EndInit();
            this.Contenedor_Principal.ResumeLayout(false);
            this.FormAcademico.ResumeLayout(false);
            this.FormAcademico.PerformLayout();
            this.FormAlumnos.ResumeLayout(false);
            this.FormAlumnos.PerformLayout();
            this.FormGrupos.ResumeLayout(false);
            this.FormGrupos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Contenedor_Principal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel FormAcademico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel FormAlumnos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Panel FormGrupos;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox6;
    }
}