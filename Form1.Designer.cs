namespace Decode
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDe = new System.Windows.Forms.Button();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.textBoxEnString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDe
            // 
            this.buttonDe.Location = new System.Drawing.Point(12, 231);
            this.buttonDe.Name = "buttonDe";
            this.buttonDe.Size = new System.Drawing.Size(776, 50);
            this.buttonDe.TabIndex = 5;
            this.buttonDe.Text = "DeCode";
            this.buttonDe.UseVisualStyleBackColor = true;
            this.buttonDe.Click += new System.EventHandler(this.buttonDe_Click);
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(12, 299);
            this.textBoxString.Multiline = true;
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(776, 199);
            this.textBoxString.TabIndex = 4;
            // 
            // textBoxEnString
            // 
            this.textBoxEnString.Location = new System.Drawing.Point(12, 12);
            this.textBoxEnString.Multiline = true;
            this.textBoxEnString.Name = "textBoxEnString";
            this.textBoxEnString.Size = new System.Drawing.Size(776, 199);
            this.textBoxEnString.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.buttonDe);
            this.Controls.Add(this.textBoxString);
            this.Controls.Add(this.textBoxEnString);
            this.Name = "Form1";
            this.Text = "DeCode for RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDe;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.TextBox textBoxEnString;
    }
}

