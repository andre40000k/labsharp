namespace labCsharp2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxTriangle = new System.Windows.Forms.RichTextBox();
            this.txtTriangleThirdtside = new System.Windows.Forms.TextBox();
            this.txtTriangleSecondside = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTriangleFirstside = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RichTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.richTextBoxTriangle);
            this.panel1.Controls.Add(this.txtTriangleThirdtside);
            this.panel1.Controls.Add(this.txtTriangleSecondside);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTriangleFirstside);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 685);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(28, 560);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(373, 55);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 78);
            this.button1.TabIndex = 10;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxTriangle
            // 
            this.richTextBoxTriangle.Location = new System.Drawing.Point(28, 277);
            this.richTextBoxTriangle.Name = "richTextBoxTriangle";
            this.richTextBoxTriangle.Size = new System.Drawing.Size(373, 284);
            this.richTextBoxTriangle.TabIndex = 7;
            this.richTextBoxTriangle.Text = "";
            // 
            // txtTriangleThirdtside
            // 
            this.txtTriangleThirdtside.Location = new System.Drawing.Point(258, 128);
            this.txtTriangleThirdtside.Name = "txtTriangleThirdtside";
            this.txtTriangleThirdtside.Size = new System.Drawing.Size(100, 22);
            this.txtTriangleThirdtside.TabIndex = 6;
            // 
            // txtTriangleSecondside
            // 
            this.txtTriangleSecondside.Location = new System.Drawing.Point(258, 90);
            this.txtTriangleSecondside.Name = "txtTriangleSecondside";
            this.txtTriangleSecondside.Size = new System.Drawing.Size(100, 22);
            this.txtTriangleSecondside.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Сторона с:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Сторона b:";
            // 
            // txtTriangleFirstside
            // 
            this.txtTriangleFirstside.Location = new System.Drawing.Point(258, 51);
            this.txtTriangleFirstside.Name = "txtTriangleFirstside";
            this.txtTriangleFirstside.Size = new System.Drawing.Size(100, 22);
            this.txtTriangleFirstside.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сторона а:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RichTextBoxResult);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(413, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 671);
            this.panel2.TabIndex = 1;
            // 
            // RichTextBoxResult
            // 
            this.RichTextBoxResult.Location = new System.Drawing.Point(667, 106);
            this.RichTextBoxResult.Name = "RichTextBoxResult";
            this.RichTextBoxResult.Size = new System.Drawing.Size(194, 284);
            this.RichTextBoxResult.TabIndex = 12;
            this.RichTextBoxResult.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(698, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 78);
            this.button2.TabIndex = 12;
            this.button2.Text = "Старт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(14, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(647, 452);
            this.dataGridView1.TabIndex = 17;
            // 
            // A
            // 
            this.A.HeaderText = "Сторона А";
            this.A.Name = "A";
            // 
            // B
            // 
            this.B.HeaderText = "Сторона В";
            this.B.Name = "B";
            // 
            // C
            // 
            this.C.HeaderText = "Сторона С";
            this.C.Name = "C";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Площа";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Равностороний???";
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTriangleFirstside;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTriangleThirdtside;
        private System.Windows.Forms.TextBox txtTriangleSecondside;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxTriangle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox RichTextBoxResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}