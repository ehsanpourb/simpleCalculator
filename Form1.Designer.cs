namespace calculator
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
            this.lblNum01 = new System.Windows.Forms.Label();
            this.lblNum02 = new System.Windows.Forms.Label();
            this.txtNum01 = new System.Windows.Forms.NumericUpDown();
            this.txtNum02 = new System.Windows.Forms.NumericUpDown();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum02)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum01
            // 
            this.lblNum01.AutoSize = true;
            this.lblNum01.Location = new System.Drawing.Point(41, 48);
            this.lblNum01.Name = "lblNum01";
            this.lblNum01.Size = new System.Drawing.Size(54, 17);
            this.lblNum01.TabIndex = 0;
            this.lblNum01.Text = "شماره اول:";
            // 
            // lblNum02
            // 
            this.lblNum02.AutoSize = true;
            this.lblNum02.Location = new System.Drawing.Point(40, 85);
            this.lblNum02.Name = "lblNum02";
            this.lblNum02.Size = new System.Drawing.Size(55, 17);
            this.lblNum02.TabIndex = 3;
            this.lblNum02.Text = "شماره دوم:";
            // 
            // txtNum01
            // 
            this.txtNum01.Location = new System.Drawing.Point(101, 48);
            this.txtNum01.Name = "txtNum01";
            this.txtNum01.Size = new System.Drawing.Size(322, 24);
            this.txtNum01.TabIndex = 8;
            // 
            // txtNum02
            // 
            this.txtNum02.Location = new System.Drawing.Point(101, 77);
            this.txtNum02.Name = "txtNum02";
            this.txtNum02.Size = new System.Drawing.Size(322, 24);
            this.txtNum02.TabIndex = 9;
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSum.Location = new System.Drawing.Point(321, 107);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(65, 28);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMin.Location = new System.Drawing.Point(252, 107);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(63, 28);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMultiple.Location = new System.Drawing.Point(184, 108);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(62, 28);
            this.btnMultiple.TabIndex = 6;
            this.btnMultiple.Text = "*";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDiv.Location = new System.Drawing.Point(116, 108);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(62, 28);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 162);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.txtNum02);
            this.Controls.Add(this.txtNum01);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lblNum02);
            this.Controls.Add(this.lblNum01);
            this.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNum01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum01;
        private System.Windows.Forms.Label lblNum02;
        private System.Windows.Forms.NumericUpDown txtNum01;
        private System.Windows.Forms.NumericUpDown txtNum02;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnDiv;
    }
}

