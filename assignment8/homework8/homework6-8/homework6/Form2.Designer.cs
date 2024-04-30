namespace homework6
{
    partial class Form2
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
            this.admit_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.goodName_text = new System.Windows.Forms.TextBox();
            this.time_text = new System.Windows.Forms.TextBox();
            this.idtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.price_text = new System.Windows.Forms.TextBox();
            this.customtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.goodId_text = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // admit_button
            // 
            this.admit_button.Location = new System.Drawing.Point(651, 284);
            this.admit_button.Name = "admit_button";
            this.admit_button.Size = new System.Drawing.Size(88, 39);
            this.admit_button.TabIndex = 0;
            this.admit_button.Text = "确认";
            this.admit_button.UseVisualStyleBackColor = true;
            this.admit_button.Click += new System.EventHandler(this.admit_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.goodName_text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.time_text, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.idtext, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.price_text, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.customtext, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.goodId_text, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(56, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 185);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // goodName_text
            // 
            this.goodName_text.Location = new System.Drawing.Point(103, 63);
            this.goodName_text.Name = "goodName_text";
            this.goodName_text.Size = new System.Drawing.Size(347, 28);
            this.goodName_text.TabIndex = 4;
            // 
            // time_text
            // 
            this.time_text.Location = new System.Drawing.Point(103, 123);
            this.time_text.Name = "time_text";
            this.time_text.Size = new System.Drawing.Size(347, 28);
            this.time_text.TabIndex = 4;
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(103, 3);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(347, 28);
            this.idtext.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号";
            // 
            // price_text
            // 
            this.price_text.Location = new System.Drawing.Point(103, 153);
            this.price_text.Name = "price_text";
            this.price_text.Size = new System.Drawing.Size(347, 28);
            this.price_text.TabIndex = 7;
            // 
            // customtext
            // 
            this.customtext.Location = new System.Drawing.Point(103, 33);
            this.customtext.Name = "customtext";
            this.customtext.Size = new System.Drawing.Size(347, 28);
            this.customtext.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "顾客";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "金额";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "时间";
            // 
            // goodId_text
            // 
            this.goodId_text.Location = new System.Drawing.Point(103, 93);
            this.goodId_text.Name = "goodId_text";
            this.goodId_text.Size = new System.Drawing.Size(347, 28);
            this.goodId_text.TabIndex = 4;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(534, 67);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(80, 31);
            this.delete.TabIndex = 3;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(434, 272);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 31);
            this.reset.TabIndex = 4;
            this.reset.Text = "清空";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 357);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.admit_button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button admit_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox time_text;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.TextBox price_text;
        private System.Windows.Forms.TextBox customtext;
        private System.Windows.Forms.TextBox goodName_text;
        private System.Windows.Forms.TextBox goodId_text;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button reset;
    }
}