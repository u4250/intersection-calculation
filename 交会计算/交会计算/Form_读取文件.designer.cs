namespace main7
{
    partial class Form_读取文件
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_显示内容 = new System.Windows.Forms.TextBox();
            this.label_提示 = new System.Windows.Forms.Label();
            this.button_文件浏览 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_计算结果 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_导出数据 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_显示内容
            // 
            this.textBox_显示内容.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_显示内容.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_显示内容.Location = new System.Drawing.Point(12, 84);
            this.textBox_显示内容.Multiline = true;
            this.textBox_显示内容.Name = "textBox_显示内容";
            this.textBox_显示内容.Size = new System.Drawing.Size(313, 383);
            this.textBox_显示内容.TabIndex = 1;
            this.textBox_显示内容.TextChanged += new System.EventHandler(this.TextBox_显示内容_TextChanged);
            // 
            // label_提示
            // 
            this.label_提示.AutoSize = true;
            this.label_提示.Location = new System.Drawing.Point(22, 20);
            this.label_提示.Name = "label_提示";
            this.label_提示.Size = new System.Drawing.Size(82, 15);
            this.label_提示.TabIndex = 2;
            this.label_提示.Text = "文件路径：";
            // 
            // button_文件浏览
            // 
            this.button_文件浏览.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_文件浏览.Location = new System.Drawing.Point(602, 15);
            this.button_文件浏览.Name = "button_文件浏览";
            this.button_文件浏览.Size = new System.Drawing.Size(75, 25);
            this.button_文件浏览.TabIndex = 4;
            this.button_文件浏览.Text = "浏览";
            this.button_文件浏览.UseVisualStyleBackColor = true;
            this.button_文件浏览.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(499, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox_计算结果
            // 
            this.textBox_计算结果.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_计算结果.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_计算结果.Location = new System.Drawing.Point(334, 84);
            this.textBox_计算结果.Multiline = true;
            this.textBox_计算结果.Name = "textBox_计算结果";
            this.textBox_计算结果.Size = new System.Drawing.Size(358, 331);
            this.textBox_计算结果.TabIndex = 6;
            this.textBox_计算结果.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(331, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "计算结果：";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(384, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_导出数据
            // 
            this.button_导出数据.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_导出数据.Location = new System.Drawing.Point(506, 421);
            this.button_导出数据.Name = "button_导出数据";
            this.button_导出数据.Size = new System.Drawing.Size(100, 46);
            this.button_导出数据.TabIndex = 9;
            this.button_导出数据.Text = "导出";
            this.button_导出数据.UseVisualStyleBackColor = true;
            this.button_导出数据.Click += new System.EventHandler(this.button_导出数据_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "每次最多导入100条数据！";
            // 
            // Form_读取文件
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_导出数据);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_计算结果);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_显示内容);
            this.Controls.Add(this.button_文件浏览);
            this.Controls.Add(this.label_提示);
            this.Name = "Form_读取文件";
            this.Text = "Form_读取文件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_显示内容;
        private System.Windows.Forms.Label label_提示;
        private System.Windows.Forms.Button button_文件浏览;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_计算结果;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_导出数据;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
    }
}