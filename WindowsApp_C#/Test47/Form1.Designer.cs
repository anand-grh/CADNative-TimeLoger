
namespace Test47
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lastCapture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastCaptureTime = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.nextCaptureTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kstrokCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mclickCount = new System.Windows.Forms.Label();
            this.UserKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ServerURL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lastCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Capture Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 591);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Capture and upload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lastCapture
            // 
            this.lastCapture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lastCapture.Location = new System.Drawing.Point(13, 319);
            this.lastCapture.Name = "lastCapture";
            this.lastCapture.Size = new System.Drawing.Size(296, 203);
            this.lastCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastCapture.TabIndex = 2;
            this.lastCapture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Capture";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Capture Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Currnent Time";
            // 
            // lastCaptureTime
            // 
            this.lastCaptureTime.AutoSize = true;
            this.lastCaptureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastCaptureTime.Location = new System.Drawing.Point(147, 128);
            this.lastCaptureTime.Name = "lastCaptureTime";
            this.lastCaptureTime.Size = new System.Drawing.Size(159, 18);
            this.lastCaptureTime.TabIndex = 6;
            this.lastCaptureTime.Text = "01/01/2021 00:00:00";
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime.Location = new System.Drawing.Point(147, 162);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(159, 18);
            this.CurrentTime.TabIndex = 7;
            this.CurrentTime.Text = "01/01/2021 00:00:00";
            // 
            // nextCaptureTime
            // 
            this.nextCaptureTime.AutoSize = true;
            this.nextCaptureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextCaptureTime.Location = new System.Drawing.Point(147, 195);
            this.nextCaptureTime.Name = "nextCaptureTime";
            this.nextCaptureTime.Size = new System.Drawing.Size(159, 18);
            this.nextCaptureTime.TabIndex = 9;
            this.nextCaptureTime.Text = "01/01/2021 00:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Next Capture Time";
            // 
            // kstrokCount
            // 
            this.kstrokCount.AutoSize = true;
            this.kstrokCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kstrokCount.Location = new System.Drawing.Point(147, 241);
            this.kstrokCount.Name = "kstrokCount";
            this.kstrokCount.Size = new System.Drawing.Size(17, 18);
            this.kstrokCount.TabIndex = 11;
            this.kstrokCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Key Stroke";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mouse Click";
            // 
            // mclickCount
            // 
            this.mclickCount.AutoSize = true;
            this.mclickCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mclickCount.Location = new System.Drawing.Point(147, 273);
            this.mclickCount.Name = "mclickCount";
            this.mclickCount.Size = new System.Drawing.Size(17, 18);
            this.mclickCount.TabIndex = 14;
            this.mclickCount.Text = "0";
            // 
            // UserKey
            // 
            this.UserKey.Location = new System.Drawing.Point(13, 86);
            this.UserKey.Name = "UserKey";
            this.UserKey.Size = new System.Drawing.Size(293, 20);
            this.UserKey.TabIndex = 15;
            this.UserKey.Text = "akshay47";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "User Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Server URL";
            // 
            // ServerURL
            // 
            this.ServerURL.Location = new System.Drawing.Point(13, 30);
            this.ServerURL.Name = "ServerURL";
            this.ServerURL.Size = new System.Drawing.Size(293, 20);
            this.ServerURL.TabIndex = 17;
            this.ServerURL.Text = "https://893a352e84d9fdcc176c42e3cf26a859.m.pipedream.net";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 661);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ServerURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserKey);
            this.Controls.Add(this.mclickCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kstrokCount);
            this.Controls.Add(this.nextCaptureTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.lastCaptureTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastCapture);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "CADNative TimeLoger47";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lastCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox lastCapture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lastCaptureTime;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label nextCaptureTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label kstrokCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mclickCount;
        private System.Windows.Forms.TextBox UserKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ServerURL;
    }
}

