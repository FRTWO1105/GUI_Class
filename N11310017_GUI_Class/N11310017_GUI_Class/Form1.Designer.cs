﻿namespace N11310017_GUI_Class
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(123, 150);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(334, 270);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "按鈕";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnButton);
            this.Name = "Form1";
            this.Text = "GUI 主程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
    }
}

