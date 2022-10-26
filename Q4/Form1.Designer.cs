namespace Q4
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblPeo = new System.Windows.Forms.Label();
            this.lblPeopleCash = new System.Windows.Forms.Label();
            this.lblCarCash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(252, 75);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(88, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "計算價錢";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(135, 100);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(100, 22);
            this.txtPeople.TabIndex = 1;
            // 
            // txtCar
            // 
            this.txtCar.Location = new System.Drawing.Point(135, 51);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(100, 22);
            this.txtCar.TabIndex = 2;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(71, 51);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(56, 12);
            this.lblCar.TabIndex = 3;
            this.lblCar.Text = "汽車數量:";
            // 
            // lblPeo
            // 
            this.lblPeo.AutoSize = true;
            this.lblPeo.Location = new System.Drawing.Point(71, 103);
            this.lblPeo.Name = "lblPeo";
            this.lblPeo.Size = new System.Drawing.Size(56, 12);
            this.lblPeo.TabIndex = 4;
            this.lblPeo.Text = "人頭數量:";
            // 
            // lblPeopleCash
            // 
            this.lblPeopleCash.AutoSize = true;
            this.lblPeopleCash.Location = new System.Drawing.Point(351, 110);
            this.lblPeopleCash.Name = "lblPeopleCash";
            this.lblPeopleCash.Size = new System.Drawing.Size(33, 12);
            this.lblPeopleCash.TabIndex = 5;
            this.lblPeopleCash.Text = "label1";
            // 
            // lblCarCash
            // 
            this.lblCarCash.AutoSize = true;
            this.lblCarCash.Location = new System.Drawing.Point(351, 54);
            this.lblCarCash.Name = "lblCarCash";
            this.lblCarCash.Size = new System.Drawing.Size(33, 12);
            this.lblCarCash.TabIndex = 5;
            this.lblCarCash.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 169);
            this.Controls.Add(this.lblCarCash);
            this.Controls.Add(this.lblPeopleCash);
            this.Controls.Add(this.lblPeo);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.txtPeople);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblPeo;
        private System.Windows.Forms.Label lblPeopleCash;
        private System.Windows.Forms.Label lblCarCash;
    }
}

