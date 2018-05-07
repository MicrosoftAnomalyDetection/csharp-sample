namespace AnomalyDetection
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
            this.label1 = new System.Windows.Forms.Label();
            this.subscriptionKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.requestData = new System.Windows.Forms.RichTextBox();
            this.responseData = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.period = new System.Windows.Forms.TextBox();
            this.dataFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subscription Key:";
            // 
            // subscriptionKey
            // 
            this.subscriptionKey.Location = new System.Drawing.Point(408, 4);
            this.subscriptionKey.Name = "subscriptionKey";
            this.subscriptionKey.Size = new System.Drawing.Size(304, 20);
            this.subscriptionKey.TabIndex = 1;
            this.subscriptionKey.Text = "{your_subscription_key}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Request preview (Json):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Send request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endpoint URL:";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(84, 4);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(221, 20);
            this.urlBox.TabIndex = 6;
            this.urlBox.Text = "https://api.labs.cognitive.microsoft.com/anomalyfinder/v1.0/anomalydetection ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Response (Json):";
            // 
            // requestData
            // 
            this.requestData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.requestData.Location = new System.Drawing.Point(0, 75);
            this.requestData.Name = "requestData";
            this.requestData.ReadOnly = true;
            this.requestData.Size = new System.Drawing.Size(723, 226);
            this.requestData.TabIndex = 9;
            this.requestData.Text = "";
            // 
            // responseData
            // 
            this.responseData.Location = new System.Drawing.Point(0, 338);
            this.responseData.Name = "responseData";
            this.responseData.Size = new System.Drawing.Size(723, 323);
            this.responseData.TabIndex = 10;
            this.responseData.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Period:";
            // 
            // period
            // 
            this.period.Location = new System.Drawing.Point(408, 30);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(144, 20);
            this.period.TabIndex = 12;
            this.period.TextChanged += new System.EventHandler(this.period_TextChanged);
            // 
            // dataFile
            // 
            this.dataFile.Location = new System.Drawing.Point(84, 30);
            this.dataFile.Name = "dataFile";
            this.dataFile.Size = new System.Drawing.Size(221, 20);
            this.dataFile.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data Filename:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(724, 663);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataFile);
            this.Controls.Add(this.period);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.responseData);
            this.Controls.Add(this.requestData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subscriptionKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subscriptionKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox requestData;
        private System.Windows.Forms.RichTextBox responseData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox period;
        private System.Windows.Forms.TextBox dataFile;
        private System.Windows.Forms.Label label6;
    }
}

