namespace MiniProject
{
    partial class Member_Task
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 22);
            label1.Name = "label1";
            label1.Size = new Size(155, 35);
            label1.TabIndex = 0;
            label1.Text = "Members";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 163);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 227);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "PhoneNumber";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 295);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Adress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 106);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 4;
            label5.Text = "MemberId";
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Location = new Point(78, 419);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(262, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 288);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 27);
            textBox4.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Location = new Point(283, 419);
            button2.Name = "button2";
            button2.Size = new Size(129, 40);
            button2.TabIndex = 13;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SpringGreen;
            button3.Location = new Point(509, 419);
            button3.Name = "button3";
            button3.Size = new Size(129, 40);
            button3.TabIndex = 14;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Location = new Point(741, 419);
            button4.Name = "button4";
            button4.Size = new Size(129, 40);
            button4.TabIndex = 15;
            button4.Text = "List";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(569, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(578, 287);
            dataGridView1.TabIndex = 16;
            // 
            // Member_Task
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 538);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Member_Task";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}