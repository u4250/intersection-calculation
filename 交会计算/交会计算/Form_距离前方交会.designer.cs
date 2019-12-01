namespace main7
{
    partial class Form_距离前方交会
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_距离前方交会));
            this.button_Caculate = new System.Windows.Forms.Button();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_角度提示 = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.Yb = new System.Windows.Forms.TextBox();
            this.Ya = new System.Windows.Forms.TextBox();
            this.label_Y2 = new System.Windows.Forms.Label();
            this.label_Y1 = new System.Windows.Forms.Label();
            this.label_X2 = new System.Windows.Forms.Label();
            this.Xb = new System.Windows.Forms.TextBox();
            this.Xa = new System.Windows.Forms.TextBox();
            this.label_坐标提示 = new System.Windows.Forms.Label();
            this.label_X1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.button_清空 = new System.Windows.Forms.Button();
            this.button_批量处理 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Caculate
            // 
            this.button_Caculate.Location = new System.Drawing.Point(289, 372);
            this.button_Caculate.Name = "button_Caculate";
            this.button_Caculate.Size = new System.Drawing.Size(160, 41);
            this.button_Caculate.TabIndex = 60;
            this.button_Caculate.Text = "确定";
            this.button_Caculate.UseVisualStyleBackColor = true;
            this.button_Caculate.Click += new System.EventHandler(this.Button_Caculate_Click);
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(18, 308);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(23, 15);
            this.label_X.TabIndex = 59;
            this.label_X.Text = "X:";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(243, 308);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(23, 15);
            this.label_Y.TabIndex = 58;
            this.label_Y.Text = "Y:";
            this.label_Y.Click += new System.EventHandler(this.label_Y_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "待求坐标：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(12, 223);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(23, 15);
            this.label_b.TabIndex = 50;
            this.label_b.Text = "b:";
            // 
            // label_角度提示
            // 
            this.label_角度提示.AutoSize = true;
            this.label_角度提示.Location = new System.Drawing.Point(12, 145);
            this.label_角度提示.Name = "label_角度提示";
            this.label_角度提示.Size = new System.Drawing.Size(82, 15);
            this.label_角度提示.TabIndex = 44;
            this.label_角度提示.Text = "已知边长：";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(13, 180);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(30, 15);
            this.label_a.TabIndex = 42;
            this.label_a.Text = "a：";
            // 
            // Yb
            // 
            this.Yb.Location = new System.Drawing.Point(289, 105);
            this.Yb.Name = "Yb";
            this.Yb.Size = new System.Drawing.Size(158, 25);
            this.Yb.TabIndex = 41;
            // 
            // Ya
            // 
            this.Ya.Location = new System.Drawing.Point(289, 51);
            this.Ya.Name = "Ya";
            this.Ya.Size = new System.Drawing.Size(158, 25);
            this.Ya.TabIndex = 40;
            // 
            // label_Y2
            // 
            this.label_Y2.AutoSize = true;
            this.label_Y2.Location = new System.Drawing.Point(243, 108);
            this.label_Y2.Name = "label_Y2";
            this.label_Y2.Size = new System.Drawing.Size(31, 15);
            this.label_Y2.TabIndex = 39;
            this.label_Y2.Text = "Yb:";
            // 
            // label_Y1
            // 
            this.label_Y1.AutoSize = true;
            this.label_Y1.Location = new System.Drawing.Point(243, 54);
            this.label_Y1.Name = "label_Y1";
            this.label_Y1.Size = new System.Drawing.Size(31, 15);
            this.label_Y1.TabIndex = 38;
            this.label_Y1.Text = "Ya:";
            // 
            // label_X2
            // 
            this.label_X2.AutoSize = true;
            this.label_X2.Location = new System.Drawing.Point(12, 108);
            this.label_X2.Name = "label_X2";
            this.label_X2.Size = new System.Drawing.Size(31, 15);
            this.label_X2.TabIndex = 37;
            this.label_X2.Text = "Xb:";
            // 
            // Xb
            // 
            this.Xb.Location = new System.Drawing.Point(49, 105);
            this.Xb.Name = "Xb";
            this.Xb.Size = new System.Drawing.Size(158, 25);
            this.Xb.TabIndex = 36;
            // 
            // Xa
            // 
            this.Xa.Location = new System.Drawing.Point(49, 51);
            this.Xa.Name = "Xa";
            this.Xa.Size = new System.Drawing.Size(158, 25);
            this.Xa.TabIndex = 35;
            // 
            // label_坐标提示
            // 
            this.label_坐标提示.AutoSize = true;
            this.label_坐标提示.Location = new System.Drawing.Point(12, 25);
            this.label_坐标提示.Name = "label_坐标提示";
            this.label_坐标提示.Size = new System.Drawing.Size(82, 15);
            this.label_坐标提示.TabIndex = 34;
            this.label_坐标提示.Text = "已知坐标：";
            // 
            // label_X1
            // 
            this.label_X1.AutoSize = true;
            this.label_X1.Location = new System.Drawing.Point(12, 54);
            this.label_X1.Name = "label_X1";
            this.label_X1.Size = new System.Drawing.Size(31, 15);
            this.label_X1.TabIndex = 33;
            this.label_X1.Text = "Xa:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(41, 220);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(157, 25);
            this.textBox_b.TabIndex = 62;
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(41, 177);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(157, 25);
            this.textBox_a.TabIndex = 61;
            // 
            // button_清空
            // 
            this.button_清空.ForeColor = System.Drawing.Color.Red;
            this.button_清空.Location = new System.Drawing.Point(16, 372);
            this.button_清空.Name = "button_清空";
            this.button_清空.Size = new System.Drawing.Size(119, 41);
            this.button_清空.TabIndex = 63;
            this.button_清空.Text = "清空数据";
            this.button_清空.UseVisualStyleBackColor = true;
            this.button_清空.Click += new System.EventHandler(this.button_清空_Click);
            // 
            // button_批量处理
            // 
            this.button_批量处理.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_批量处理.Location = new System.Drawing.Point(148, 372);
            this.button_批量处理.Name = "button_批量处理";
            this.button_批量处理.Size = new System.Drawing.Size(126, 41);
            this.button_批量处理.TabIndex = 64;
            this.button_批量处理.Text = "批量处理";
            this.button_批量处理.UseVisualStyleBackColor = true;
            this.button_批量处理.Click += new System.EventHandler(this.button_批量处理_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 67;
            this.label3.Text = "如图：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(18, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 68;
            // 
            // Form_距离前方交会
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 438);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_批量处理);
            this.Controls.Add(this.button_清空);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.button_Caculate);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_角度提示);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.Yb);
            this.Controls.Add(this.Ya);
            this.Controls.Add(this.label_Y2);
            this.Controls.Add(this.label_Y1);
            this.Controls.Add(this.label_X2);
            this.Controls.Add(this.Xb);
            this.Controls.Add(this.Xa);
            this.Controls.Add(this.label_坐标提示);
            this.Controls.Add(this.label_X1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_距离前方交会";
            this.Text = "Form_距离前方交会";
            this.Load += new System.EventHandler(this.Form_距离前方交会_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Caculate;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_角度提示;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.TextBox Yb;
        private System.Windows.Forms.TextBox Ya;
        private System.Windows.Forms.Label label_Y2;
        private System.Windows.Forms.Label label_Y1;
        private System.Windows.Forms.Label label_X2;
        private System.Windows.Forms.TextBox Xb;
        private System.Windows.Forms.TextBox Xa;
        private System.Windows.Forms.Label label_坐标提示;
        private System.Windows.Forms.Label label_X1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Button button_清空;
        private System.Windows.Forms.Button button_批量处理;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}