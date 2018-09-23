namespace WinFormHelloword
{
    partial class Form1
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
            this.buttonsayhello = new System.Windows.Forms.Button();
            this.textBoxshowhello = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonsayhello
            // 
            this.buttonsayhello.Location = new System.Drawing.Point(12, 61);
            this.buttonsayhello.Name = "buttonsayhello";
            this.buttonsayhello.Size = new System.Drawing.Size(298, 34);
            this.buttonsayhello.TabIndex = 0;
            this.buttonsayhello.Text = "Click me";
            this.buttonsayhello.UseVisualStyleBackColor = true;
            this.buttonsayhello.Click += new System.EventHandler(this.buttonsayhello_Click);
            // 
            // textBoxshowhello
            // 
            this.textBoxshowhello.Location = new System.Drawing.Point(11, 12);
            this.textBoxshowhello.Name = "textBoxshowhello";
            this.textBoxshowhello.Size = new System.Drawing.Size(311, 21);
            this.textBoxshowhello.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 119);
            this.Controls.Add(this.textBoxshowhello);
            this.Controls.Add(this.buttonsayhello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonsayhello;
        private System.Windows.Forms.TextBox textBoxshowhello;
    }
}

