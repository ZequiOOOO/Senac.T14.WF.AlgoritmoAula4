namespace WinFormsAlgoritmos
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Lucida Fax", 12F);
            groupBox1.Location = new Point(8, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 366);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de conta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 49);
            label1.Name = "label1";
            label1.Size = new Size(221, 27);
            label1.TabIndex = 0;
            label1.Text = "Numero da conta";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkRed;
            textBox1.Location = new Point(14, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(355, 36);
            textBox1.TabIndex = 4;
            textBox1.Text = "12345";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(419, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 36);
            textBox2.TabIndex = 6;
            textBox2.Text = "Ezequiel Ramos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 49);
            label2.Name = "label2";
            label2.Size = new Size(206, 27);
            label2.TabIndex = 5;
            label2.Text = "Titular da conta";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.SeaGreen;
            textBox3.Location = new Point(14, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(355, 36);
            textBox3.TabIndex = 8;
            textBox3.Text = "2000";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 137);
            label3.Name = "label3";
            label3.Size = new Size(189, 27);
            label3.TabIndex = 7;
            label3.Text = "Saldo da conta";
            label3.Click += label3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(402, 165);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(355, 36);
            textBox5.TabIndex = 11;
            textBox5.Text = "Corrente";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 137);
            label4.Name = "label4";
            label4.Size = new Size(179, 27);
            label4.TabIndex = 10;
            label4.Text = "Tipo da conta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox5;
        private Label label4;
    }
}
