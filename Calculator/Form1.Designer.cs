namespace Calculator
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
            tb = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSuma = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnResta = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplicacion = new Button();
            btnBorrar = new Button();
            btn0 = new Button();
            btmCalcular = new Button();
            btnDivision = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnHistorial = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tb
            // 
            tb.Font = new Font("Segoe UI", 29F);
            tb.Location = new Point(12, 12);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.Size = new Size(213, 55);
            tb.TabIndex = 0;
            tb.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.51773F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.48227F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.Controls.Add(btn1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn2, 1, 0);
            tableLayoutPanel1.Controls.Add(btn3, 2, 0);
            tableLayoutPanel1.Controls.Add(btnSuma, 3, 0);
            tableLayoutPanel1.Controls.Add(btn4, 0, 1);
            tableLayoutPanel1.Controls.Add(btn5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn6, 2, 1);
            tableLayoutPanel1.Controls.Add(btnResta, 3, 1);
            tableLayoutPanel1.Controls.Add(btn7, 0, 2);
            tableLayoutPanel1.Controls.Add(btn8, 1, 2);
            tableLayoutPanel1.Controls.Add(btn9, 2, 2);
            tableLayoutPanel1.Controls.Add(btnMultiplicacion, 3, 2);
            tableLayoutPanel1.Controls.Add(btnBorrar, 0, 3);
            tableLayoutPanel1.Controls.Add(btn0, 1, 3);
            tableLayoutPanel1.Controls.Add(btmCalcular, 2, 3);
            tableLayoutPanel1.Controls.Add(btnDivision, 3, 3);
            tableLayoutPanel1.Location = new Point(12, 73);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.62385F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.37615F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(287, 222);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(61, 47);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(70, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(68, 47);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(144, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(69, 47);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.FromArgb(183, 181, 151);
            btnSuma.Dock = DockStyle.Fill;
            btnSuma.Location = new Point(219, 3);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(65, 47);
            btnSuma.TabIndex = 5;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(3, 56);
            btn4.Name = "btn4";
            btn4.Size = new Size(61, 50);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(70, 56);
            btn5.Name = "btn5";
            btn5.Size = new Size(68, 50);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(144, 56);
            btn6.Name = "btn6";
            btn6.Size = new Size(69, 50);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.FromArgb(183, 181, 151);
            btnResta.Dock = DockStyle.Fill;
            btnResta.Location = new Point(219, 56);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(65, 50);
            btnResta.TabIndex = 9;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(3, 112);
            btn7.Name = "btn7";
            btn7.Size = new Size(61, 51);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(70, 112);
            btn8.Name = "btn8";
            btn8.Size = new Size(68, 51);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(144, 112);
            btn9.Name = "btn9";
            btn9.Size = new Size(69, 51);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.BackColor = Color.FromArgb(183, 181, 151);
            btnMultiplicacion.Dock = DockStyle.Fill;
            btnMultiplicacion.Location = new Point(219, 112);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(65, 51);
            btnMultiplicacion.TabIndex = 13;
            btnMultiplicacion.Text = "*";
            btnMultiplicacion.UseVisualStyleBackColor = false;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(183, 181, 151);
            btnBorrar.Dock = DockStyle.Fill;
            btnBorrar.Location = new Point(3, 169);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(61, 50);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += button13_Click;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Location = new Point(70, 169);
            btn0.Name = "btn0";
            btn0.Size = new Size(68, 50);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btmCalcular
            // 
            btmCalcular.BackColor = Color.FromArgb(183, 181, 151);
            btmCalcular.Dock = DockStyle.Fill;
            btmCalcular.Location = new Point(144, 169);
            btmCalcular.Name = "btmCalcular";
            btmCalcular.Size = new Size(69, 50);
            btmCalcular.TabIndex = 16;
            btmCalcular.Text = "=";
            btmCalcular.UseVisualStyleBackColor = false;
            btmCalcular.Click += btmCalcular_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.FromArgb(183, 181, 151);
            btnDivision.Dock = DockStyle.Fill;
            btnDivision.Location = new Point(219, 169);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(65, 50);
            btnDivision.TabIndex = 17;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(3, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(275, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Dock = DockStyle.Fill;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(3, 42);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(275, 23);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dateTimePicker1, 0, 0);
            tableLayoutPanel2.Controls.Add(dateTimePicker2, 0, 1);
            tableLayoutPanel2.Location = new Point(15, 301);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.Size = new Size(281, 76);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(218, 211, 190);
            btnHistorial.Location = new Point(231, 12);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(68, 55);
            btnHistorial.TabIndex = 5;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(107, 138, 122);
            ClientSize = new Size(307, 389);
            Controls.Add(btnHistorial);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tb);
            Name = "Form1";
            Text = "Calculadora";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnSuma;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnResta;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplicacion;
        private Button btnBorrar;
        private Button btn0;
        private Button btmCalcular;
        private Button btnDivision;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnHistorial;
    }
}
