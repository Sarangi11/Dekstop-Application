namespace MiniProject
{
    partial class Items
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
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 31);
            label1.Name = "label1";
            label1.Size = new Size(237, 33);
            label1.TabIndex = 0;
            label1.Text = "Items Register";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(188, 240);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 244);
            label3.Name = "label3";
            label3.Size = new Size(46, 23);
            label3.TabIndex = 37;
            label3.Text = "Date";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(188, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 36;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 103);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 34;
            label5.Text = "ItemID";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 165);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 33;
            label2.Text = "Item Category";
            // 
            // button3
            // 
            button3.BackColor = Color.SpringGreen;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(309, 345);
            button3.Name = "button3";
            button3.Size = new Size(129, 40);
            button3.TabIndex = 41;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(165, 345);
            button2.Name = "button2";
            button2.Size = new Size(129, 40);
            button2.TabIndex = 40;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 345);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 39;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(471, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(578, 316);
            dataGridView1.TabIndex = 43;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Location = new Point(673, 412);
            button4.Name = "button4";
            button4.Size = new Size(129, 40);
            button4.TabIndex = 42;
            button4.Text = "List";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 516);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Items";
            Text = "Items";
            Load += Items_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label5;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button4;
    }
}