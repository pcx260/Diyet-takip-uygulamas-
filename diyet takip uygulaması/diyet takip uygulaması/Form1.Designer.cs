namespace diyet_takip_uygulaması
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
            alinankalori = new Label();
            hedefkalori = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox = new ComboBox();
            gram = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button4 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // alinankalori
            // 
            alinankalori.AutoSize = true;
            alinankalori.Location = new Point(704, 36);
            alinankalori.Name = "alinankalori";
            alinankalori.Size = new Size(86, 20);
            alinankalori.TabIndex = 1;
            alinankalori.Text = "alinankalori";
            // 
            // hedefkalori
            // 
            hedefkalori.AutoSize = true;
            hedefkalori.Location = new Point(704, 9);
            hedefkalori.Name = "hedefkalori";
            hedefkalori.Size = new Size(84, 20);
            hedefkalori.TabIndex = 0;
            hedefkalori.Text = "hedefkalori";
            // 
            // button1
            // 
            button1.Location = new Point(52, 69);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "uygula";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 4;
            label1.Text = "kalori hedefinizi belirleyin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 192);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 6;
            label2.Text = "yediğiniz yemeği ekleyin";
            // 
            // button2
            // 
            button2.Location = new Point(41, 302);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "uygula";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 9);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 9;
            label3.Text = "kalori ekleyin";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(210, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 27);
            textBox3.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(254, 69);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "uygula";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(648, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 12;
            label4.Text = "Hedef";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(648, 39);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 13;
            label5.Text = "Alınan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 332);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 15;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Pirinç 1g 1cal", "Et 1g 2cal", "Ekmek 1g 3cal", "Tavuk 1g 2cal" });
            comboBox.Location = new Point(12, 215);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(151, 28);
            comboBox.TabIndex = 16;
            // 
            // gram
            // 
            gram.Location = new Point(12, 269);
            gram.Name = "gram";
            gram.Size = new Size(151, 27);
            gram.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 246);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 18;
            label7.Text = "gramajı girin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(271, 123);
            label8.Name = "label8";
            label8.Size = new Size(215, 20);
            label8.TabIndex = 19;
            label8.Text = "Günlük kalori ihtiyacınızı aştınız";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(357, 192);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 21;
            label9.Text = "Yedikleriniz";
            // 
            // button4
            // 
            button4.Location = new Point(347, 425);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 22;
            button4.Text = "Kaldır";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "tavuk", "et", "pirinc", "ekmek" });
            listBox1.Location = new Point(219, 215);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(412, 204);
            listBox1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(gram);
            Controls.Add(comboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(alinankalori);
            Controls.Add(hedefkalori);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label alinankalori;
        private Label hedefkalori;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private TextBox textBox3;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox;
        private TextBox gram;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button4;
        private ListBox listBox1;
    }
}
