namespace RDR2
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sourceXnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sourceYnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bfsbtn = new System.Windows.Forms.Button();
            this.destYnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.destXnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourceXnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceYnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destYnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destXnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(300, 300);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // sourceXnumericUpDown
            // 
            this.sourceXnumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sourceXnumericUpDown.Location = new System.Drawing.Point(36, 22);
            this.sourceXnumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sourceXnumericUpDown.Name = "sourceXnumericUpDown";
            this.sourceXnumericUpDown.Size = new System.Drawing.Size(61, 29);
            this.sourceXnumericUpDown.TabIndex = 1;
            // 
            // sourceYnumericUpDown
            // 
            this.sourceYnumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sourceYnumericUpDown.Location = new System.Drawing.Point(36, 57);
            this.sourceYnumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sourceYnumericUpDown.Name = "sourceYnumericUpDown";
            this.sourceYnumericUpDown.Size = new System.Drawing.Size(61, 29);
            this.sourceYnumericUpDown.TabIndex = 1;
            // 
            // bfsbtn
            // 
            this.bfsbtn.Location = new System.Drawing.Point(335, 224);
            this.bfsbtn.Name = "bfsbtn";
            this.bfsbtn.Size = new System.Drawing.Size(89, 40);
            this.bfsbtn.TabIndex = 2;
            this.bfsbtn.Text = "Run BFS";
            this.bfsbtn.UseVisualStyleBackColor = true;
            this.bfsbtn.Click += new System.EventHandler(this.bfsbtn_Click);
            // 
            // destYnumericUpDown
            // 
            this.destYnumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destYnumericUpDown.Location = new System.Drawing.Point(36, 57);
            this.destYnumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.destYnumericUpDown.Name = "destYnumericUpDown";
            this.destYnumericUpDown.Size = new System.Drawing.Size(61, 29);
            this.destYnumericUpDown.TabIndex = 1;
            // 
            // destXnumericUpDown
            // 
            this.destXnumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destXnumericUpDown.Location = new System.Drawing.Point(36, 22);
            this.destXnumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.destXnumericUpDown.Name = "destXnumericUpDown";
            this.destXnumericUpDown.Size = new System.Drawing.Size(61, 29);
            this.destXnumericUpDown.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run BFS Weighted";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sourceXnumericUpDown);
            this.groupBox1.Controls.Add(this.sourceYnumericUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(327, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.destXnumericUpDown);
            this.groupBox2.Controls.Add(this.destYnumericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(327, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bfsbtn);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RDR2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceXnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceYnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destYnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destXnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.NumericUpDown sourceXnumericUpDown;
        private System.Windows.Forms.NumericUpDown sourceYnumericUpDown;
        private System.Windows.Forms.Button bfsbtn;
        private System.Windows.Forms.NumericUpDown destYnumericUpDown;
        private System.Windows.Forms.NumericUpDown destXnumericUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

