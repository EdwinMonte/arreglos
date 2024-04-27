namespace arreglos
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnCargarVector = new Button();
            groupBox2 = new GroupBox();
            btnNuevo = new Button();
            btnSalir = new Button();
            label2 = new Label();
            cboNotas = new ComboBox();
            txtPromedio = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCargarVector);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese datos";
            // 
            // btnCargarVector
            // 
            btnCargarVector.Location = new Point(227, 77);
            btnCargarVector.Name = "btnCargarVector";
            btnCargarVector.Size = new Size(261, 55);
            btnCargarVector.TabIndex = 0;
            btnCargarVector.Text = "cargar vector";
            btnCargarVector.UseVisualStyleBackColor = true;
            btnCargarVector.Click += btnCargarVector_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Controls.Add(btnSalir);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cboNotas);
            groupBox2.Controls.Add(txtPromedio);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 212);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultado";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(227, 159);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(370, 159);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 31);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "notas:";
            // 
            // cboNotas
            // 
            cboNotas.FormattingEnabled = true;
            cboNotas.Location = new Point(265, 26);
            cboNotas.Name = "cboNotas";
            cboNotas.Size = new Size(151, 28);
            cboNotas.TabIndex = 2;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(175, 115);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(380, 27);
            txtPromedio.TabIndex = 1;
            txtPromedio.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 122);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "promedio:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCargarVector;
        private GroupBox groupBox2;
        private ComboBox cboNotas;
        private TextBox txtPromedio;
        private Label label1;
        private Button btnNuevo;
        private Button btnSalir;
        private Label label2;
    }
}
