namespace hajos_bizbasz
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            valaszGomb1 = new ValaszGomb();
            valaszGomb2 = new ValaszGomb();
            valaszGomb3 = new ValaszGomb();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(490, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 41);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(471, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 79);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // valaszGomb1
            // 
            valaszGomb1.BackColor = Color.LightGray;
            valaszGomb1.BorderStyle = BorderStyle.None;
            valaszGomb1.Location = new Point(61, 83);
            valaszGomb1.Multiline = true;
            valaszGomb1.Name = "valaszGomb1";
            valaszGomb1.ReadOnly = true;
            valaszGomb1.Size = new Size(268, 61);
            valaszGomb1.TabIndex = 7;
            // 
            // valaszGomb2
            // 
            valaszGomb2.BackColor = Color.LightGray;
            valaszGomb2.BorderStyle = BorderStyle.None;
            valaszGomb2.Location = new Point(61, 163);
            valaszGomb2.Multiline = true;
            valaszGomb2.Name = "valaszGomb2";
            valaszGomb2.ReadOnly = true;
            valaszGomb2.Size = new Size(268, 52);
            valaszGomb2.TabIndex = 8;
            // 
            // valaszGomb3
            // 
            valaszGomb3.BackColor = Color.LightGray;
            valaszGomb3.BorderStyle = BorderStyle.None;
            valaszGomb3.Location = new Point(61, 232);
            valaszGomb3.Multiline = true;
            valaszGomb3.Name = "valaszGomb3";
            valaszGomb3.ReadOnly = true;
            valaszGomb3.Size = new Size(268, 56);
            valaszGomb3.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(13, 388);
            button1.Name = "button1";
            button1.Size = new Size(128, 39);
            button1.TabIndex = 10;
            button1.Text = "Következő";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(valaszGomb3);
            Controls.Add(valaszGomb2);
            Controls.Add(valaszGomb1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ValaszGomb valaszGomb1;
        private ValaszGomb valaszGomb2;
        private ValaszGomb valaszGomb3;
        private Button button1;
    }
}