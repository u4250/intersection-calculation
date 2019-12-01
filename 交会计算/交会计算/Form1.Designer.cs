namespace main7
{
    partial class Form1_封面
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_前方 = new System.Windows.Forms.Button();
            this.button_后方 = new System.Windows.Forms.Button();
            this.button_结束程序 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_前方
            // 
            this.button1_前方.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1_前方.Location = new System.Drawing.Point(125, 54);
            this.button1_前方.Name = "button1_前方";
            this.button1_前方.Size = new System.Drawing.Size(166, 56);
            this.button1_前方.TabIndex = 0;
            this.button1_前方.Text = "前方交会";
            this.button1_前方.UseVisualStyleBackColor = true;
            this.button1_前方.Click += new System.EventHandler(this.button1_前方_Click);
            // 
            // button_后方
            // 
            this.button_后方.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_后方.Location = new System.Drawing.Point(125, 116);
            this.button_后方.Name = "button_后方";
            this.button_后方.Size = new System.Drawing.Size(166, 56);
            this.button_后方.TabIndex = 1;
            this.button_后方.Text = "后方交会";
            this.button_后方.UseVisualStyleBackColor = true;
            this.button_后方.Click += new System.EventHandler(this.button_后方_Click);
            // 
            // button_结束程序
            // 
            this.button_结束程序.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_结束程序.Location = new System.Drawing.Point(125, 178);
            this.button_结束程序.Name = "button_结束程序";
            this.button_结束程序.Size = new System.Drawing.Size(166, 56);
            this.button_结束程序.TabIndex = 2;
            this.button_结束程序.Text = "退出";
            this.button_结束程序.UseVisualStyleBackColor = true;
            this.button_结束程序.Click += new System.EventHandler(this.button_结束程序_Click);
            // 
            // Form1_封面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 281);
            this.Controls.Add(this.button_结束程序);
            this.Controls.Add(this.button_后方);
            this.Controls.Add(this.button1_前方);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1_封面";
            this.Text = "交会计算";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_前方;
        private System.Windows.Forms.Button button_后方;
        private System.Windows.Forms.Button button_结束程序;
    }
}

