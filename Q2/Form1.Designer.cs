namespace Q2
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
            this.txtDay = new System.Windows.Forms.TextBox();
            this.btnDay = new System.Windows.Forms.Button();
            this.lblDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(100, 37);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 22);
            this.txtDay.TabIndex = 0;
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(125, 86);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(75, 23);
            this.btnDay.TabIndex = 1;
            this.btnDay.Text = "查詢";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(38, 40);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(56, 12);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "輸入日期:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 149);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.txtDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Label lblDay;
    }
}

