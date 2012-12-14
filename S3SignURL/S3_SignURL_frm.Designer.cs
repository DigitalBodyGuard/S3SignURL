namespace s3_SignURL
{
    partial class S3_SignURL_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S3_SignURL_frm));
            this.tb_signedURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_secretKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_expireDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_useExpireTime = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_bucket = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_file = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_accessKey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_SIGN_URL = new System.Windows.Forms.TabPage();
            this.tb_days_to_expire = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage_RIGHTS = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_SIGN_URL.SuspendLayout();
            this.tabPage_RIGHTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_signedURL
            // 
            this.tb_signedURL.Location = new System.Drawing.Point(5, 247);
            this.tb_signedURL.Multiline = true;
            this.tb_signedURL.Name = "tb_signedURL";
            this.tb_signedURL.Size = new System.Drawing.Size(344, 116);
            this.tb_signedURL.TabIndex = 0;
            this.tb_signedURL.Text = "https://bucket.s3.amazonaws.com/folder/folder/file.html?AWSAccessKeyId=AAIJBKUWCW" +
    "E5AIDP3GMV&Expires=2133721337&Signature=zpN5I/VVYZ0tWBKcxmIGbkTeJ0RN/X+aFu6WD2UN" +
    "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIGNED URL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_secretKey
            // 
            this.tb_secretKey.Location = new System.Drawing.Point(211, 98);
            this.tb_secretKey.Name = "tb_secretKey";
            this.tb_secretKey.Size = new System.Drawing.Size(274, 20);
            this.tb_secretKey.TabIndex = 2;
            this.tb_secretKey.TextChanged += new System.EventHandler(this.TXT_CHANGED);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secret Access Key:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtp_expireDate
            // 
            this.dtp_expireDate.Enabled = false;
            this.dtp_expireDate.Location = new System.Drawing.Point(114, 171);
            this.dtp_expireDate.Name = "dtp_expireDate";
            this.dtp_expireDate.Size = new System.Drawing.Size(205, 20);
            this.dtp_expireDate.TabIndex = 4;
            this.dtp_expireDate.ValueChanged += new System.EventHandler(this.DATE_changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secret Access Key:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_useExpireTime
            // 
            this.cb_useExpireTime.AutoSize = true;
            this.cb_useExpireTime.Location = new System.Drawing.Point(13, 174);
            this.cb_useExpireTime.Name = "cb_useExpireTime";
            this.cb_useExpireTime.Size = new System.Drawing.Size(103, 17);
            this.cb_useExpireTime.TabIndex = 6;
            this.cb_useExpireTime.Text = "Use Expire Time";
            this.cb_useExpireTime.UseVisualStyleBackColor = true;
            this.cb_useExpireTime.CheckedChanged += new System.EventHandler(this.cb_useExpireTime_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bucket Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_bucket
            // 
            this.tb_bucket.Location = new System.Drawing.Point(10, 34);
            this.tb_bucket.Name = "tb_bucket";
            this.tb_bucket.Size = new System.Drawing.Size(189, 20);
            this.tb_bucket.TabIndex = 7;
            this.tb_bucket.TextChanged += new System.EventHandler(this.TXT_CHANGED);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "File and path:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_file
            // 
            this.tb_file.Location = new System.Drawing.Point(215, 35);
            this.tb_file.Name = "tb_file";
            this.tb_file.Size = new System.Drawing.Size(302, 20);
            this.tb_file.TabIndex = 9;
            this.tb_file.TextChanged += new System.EventHandler(this.TXT_CHANGED);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "myBucketName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "folder/folder/file.html";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "zpN5I/VVYZ0tWBKcxmIGbkTeJ0RN/X+aFu6WD2UN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Access Key:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_accessKey
            // 
            this.tb_accessKey.Location = new System.Drawing.Point(5, 97);
            this.tb_accessKey.Name = "tb_accessKey";
            this.tb_accessKey.Size = new System.Drawing.Size(166, 20);
            this.tb_accessKey.TabIndex = 14;
            this.tb_accessKey.TextChanged += new System.EventHandler(this.TXT_CHANGED);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "AAIJBKUWCWE5AIDP3GMV";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::s3_SignURL.Properties.Resources.guy_00;
            this.pictureBox2.Location = new System.Drawing.Point(356, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 227);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_SIGN_URL);
            this.tabControl1.Controls.Add(this.tabPage_RIGHTS);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 397);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage_SIGN_URL
            // 
            this.tabPage_SIGN_URL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage_SIGN_URL.CausesValidation = false;
            this.tabPage_SIGN_URL.Controls.Add(this.tb_days_to_expire);
            this.tabPage_SIGN_URL.Controls.Add(this.label13);
            this.tabPage_SIGN_URL.Controls.Add(this.pictureBox2);
            this.tabPage_SIGN_URL.Controls.Add(this.label10);
            this.tabPage_SIGN_URL.Controls.Add(this.label7);
            this.tabPage_SIGN_URL.Controls.Add(this.label9);
            this.tabPage_SIGN_URL.Controls.Add(this.label6);
            this.tabPage_SIGN_URL.Controls.Add(this.tb_accessKey);
            this.tabPage_SIGN_URL.Controls.Add(this.tb_signedURL);
            this.tabPage_SIGN_URL.Controls.Add(this.label8);
            this.tabPage_SIGN_URL.Controls.Add(this.label1);
            this.tabPage_SIGN_URL.Controls.Add(this.label5);
            this.tabPage_SIGN_URL.Controls.Add(this.tb_secretKey);
            this.tabPage_SIGN_URL.Controls.Add(this.tb_file);
            this.tabPage_SIGN_URL.Controls.Add(this.label2);
            this.tabPage_SIGN_URL.Controls.Add(this.label4);
            this.tabPage_SIGN_URL.Controls.Add(this.dtp_expireDate);
            this.tabPage_SIGN_URL.Controls.Add(this.tb_bucket);
            this.tabPage_SIGN_URL.Controls.Add(this.label3);
            this.tabPage_SIGN_URL.Controls.Add(this.cb_useExpireTime);
            this.tabPage_SIGN_URL.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SIGN_URL.Name = "tabPage_SIGN_URL";
            this.tabPage_SIGN_URL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SIGN_URL.Size = new System.Drawing.Size(524, 371);
            this.tabPage_SIGN_URL.TabIndex = 0;
            this.tabPage_SIGN_URL.Text = "Sign URL";
            // 
            // tb_days_to_expire
            // 
            this.tb_days_to_expire.Enabled = false;
            this.tb_days_to_expire.Location = new System.Drawing.Point(44, 197);
            this.tb_days_to_expire.Name = "tb_days_to_expire";
            this.tb_days_to_expire.Size = new System.Drawing.Size(63, 20);
            this.tb_days_to_expire.TabIndex = 19;
            this.tb_days_to_expire.TextChanged += new System.EventHandler(this.tb_days_to_expire_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Days:";
            // 
            // tabPage_RIGHTS
            // 
            this.tabPage_RIGHTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage_RIGHTS.Controls.Add(this.label12);
            this.tabPage_RIGHTS.Controls.Add(this.textBox2);
            this.tabPage_RIGHTS.Controls.Add(this.label11);
            this.tabPage_RIGHTS.Controls.Add(this.textBox1);
            this.tabPage_RIGHTS.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RIGHTS.Name = "tabPage_RIGHTS";
            this.tabPage_RIGHTS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RIGHTS.Size = new System.Drawing.Size(524, 371);
            this.tabPage_RIGHTS.TabIndex = 1;
            this.tabPage_RIGHTS.Text = "DEMO - S3 - Rights";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(394, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Basic User Rights: REPLACE BUCKETNAME && NAMEOFUSER && 123456789012";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 198);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 141);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Basic User Rights: REPLACE BUCKETNAME";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 141);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "{\r\n   \"Statement\":   \r\n    {\r\n      \"Action\": \"s3:*\",\r\n      \"Effect\": \"Allow\",\r\n" +
    "      \"Resource\": \"arn:aws:s3:::BUCKETNAME/*\"\r\n    }\r\n}\r\n";
            // 
            // S3_SignURL_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(532, 397);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "S3_SignURL_frm";
            this.Text = "S3 SignURL - v1.0";
            this.Load += new System.EventHandler(this.S3_SignURL_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_SIGN_URL.ResumeLayout(false);
            this.tabPage_SIGN_URL.PerformLayout();
            this.tabPage_RIGHTS.ResumeLayout(false);
            this.tabPage_RIGHTS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_signedURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_secretKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_expireDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_useExpireTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_bucket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_accessKey;
        private System.Windows.Forms.Label label10;
      
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_RIGHTS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage_SIGN_URL;
        private System.Windows.Forms.TextBox tb_days_to_expire;
        private System.Windows.Forms.Label label13;
    }
}

