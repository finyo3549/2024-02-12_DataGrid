namespace _2024_02_12_DataGrid
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
            panel1 = new Panel();
            dataGridView_Adatok = new DataGridView();
            label1 = new Label();
            textBox_Kontinens = new TextBox();
            textBox_Orszag = new TextBox();
            label2 = new Label();
            textBox_Fovaros = new TextBox();
            label3 = new Label();
            label4 = new Label();
            numericUpDown_Terulet = new NumericUpDown();
            label_Mertekegyseg = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Adatok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Terulet).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label_Mertekegyseg);
            panel1.Controls.Add(numericUpDown_Terulet);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_Fovaros);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox_Orszag);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_Kontinens);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 450);
            panel1.TabIndex = 0;
            // 
            // dataGridView_Adatok
            // 
            dataGridView_Adatok.AllowUserToAddRows = false;
            dataGridView_Adatok.AllowUserToDeleteRows = false;
            dataGridView_Adatok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Adatok.Dock = DockStyle.Fill;
            dataGridView_Adatok.Location = new Point(231, 0);
            dataGridView_Adatok.Name = "dataGridView_Adatok";
            dataGridView_Adatok.ReadOnly = true;
            dataGridView_Adatok.Size = new Size(569, 450);
            dataGridView_Adatok.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 22);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Kontinens";
            label1.Click += label1_Click;
            // 
            // textBox_Kontinens
            // 
            textBox_Kontinens.Location = new Point(22, 47);
            textBox_Kontinens.Name = "textBox_Kontinens";
            textBox_Kontinens.Size = new Size(184, 23);
            textBox_Kontinens.TabIndex = 1;
            // 
            // textBox_Orszag
            // 
            textBox_Orszag.Location = new Point(22, 114);
            textBox_Orszag.Name = "textBox_Orszag";
            textBox_Orszag.Size = new Size(184, 23);
            textBox_Orszag.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 89);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Ország";
            // 
            // textBox_Fovaros
            // 
            textBox_Fovaros.Location = new Point(23, 183);
            textBox_Fovaros.Name = "textBox_Fovaros";
            textBox_Fovaros.Size = new Size(184, 23);
            textBox_Fovaros.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 158);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Főváros";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 221);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Terület";
            // 
            // numericUpDown_Terulet
            // 
            numericUpDown_Terulet.DecimalPlaces = 2;
            numericUpDown_Terulet.Location = new Point(23, 251);
            numericUpDown_Terulet.Name = "numericUpDown_Terulet";
            numericUpDown_Terulet.Size = new Size(147, 23);
            numericUpDown_Terulet.TabIndex = 7;
            numericUpDown_Terulet.TextAlign = HorizontalAlignment.Right;
            // 
            // label_Mertekegyseg
            // 
            label_Mertekegyseg.AutoSize = true;
            label_Mertekegyseg.Location = new Point(176, 253);
            label_Mertekegyseg.Name = "label_Mertekegyseg";
            label_Mertekegyseg.Size = new Size(38, 15);
            label_Mertekegyseg.TabIndex = 8;
            label_Mertekegyseg.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_Adatok);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Adatok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Terulet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView_Adatok;
        private Label label1;
        private TextBox textBox_Fovaros;
        private Label label3;
        private TextBox textBox_Orszag;
        private Label label2;
        private TextBox textBox_Kontinens;
        private Label label_Mertekegyseg;
        private NumericUpDown numericUpDown_Terulet;
        private Label label4;
    }
}
