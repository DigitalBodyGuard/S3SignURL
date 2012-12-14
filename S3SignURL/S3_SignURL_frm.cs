using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace s3_SignURL
{
    public partial class S3_SignURL_frm : Form
    {
        bool locked = false;
        public S3_SignURL_frm()
        {
            InitializeComponent();
        }
        private void S3_SignURL_frm_Load(object sender, EventArgs e)
        {
            int daysDefault = 10;
            locked = true;
            dtp_expireDate.Value = System.DateTime.Now + System.TimeSpan.FromDays(daysDefault);
            tb_days_to_expire.Text = daysDefault.ToString();
            locked = false;
        }
        void SignURL()
        {
            string bucket = tb_bucket.Text;
            string file = tb_file.Text;
            string secretKey = tb_secretKey.Text;
            string accessKey = tb_accessKey.Text;

            // add one day to put it at the end of the day
            DateTime expireDate = dtp_expireDate.Value + System.TimeSpan.FromDays(1);
            string outPut = string.Empty;
            if (!cb_useExpireTime.Checked)
                expireDate = DateTime.MinValue;

            try
            {
                outPut = s3_polocySigning.Encode.BuildURL(accessKey, secretKey, expireDate, bucket, file);
            }
            catch
            {
                outPut = "Failed to sign URL";
            }
            tb_signedURL.Text = outPut;
        }

        private void TXT_CHANGED(object sender, EventArgs e)
        {
            SignURL();
        }

        private void DATE_changed(object sender, EventArgs e)
        {
            if (!locked)
            {
                locked = true;
                try
                {
                    tb_days_to_expire.Text = ((dtp_expireDate.Value - System.DateTime.Now).Days + 1).ToString();
                    SignURL();
                }
                catch
                {
                }
                finally
                {
                    locked = false;
                }
            }
        }

        private void cb_useExpireTime_CheckedChanged(object sender, EventArgs e)
        {
            dtp_expireDate.Enabled = cb_useExpireTime.Checked;
            tb_days_to_expire.Enabled = cb_useExpireTime.Checked;
            SignURL();
        }

        private void ContextMenuItem_Click(object sender, EventArgs e)
        {
            if (tb_signedURL.SelectedText.Length > 0)
                System.Windows.Clipboard.SetText(tb_signedURL.SelectedText);
            else
                System.Windows.Clipboard.SetText(tb_signedURL.Text);
        }

        private void tb_days_to_expire_TextChanged(object sender, EventArgs e)
        {
            if (!locked)
            {
                locked = true;
                try
                {
                    int days = System.Convert.ToInt16(tb_days_to_expire.Text);
                    tb_days_to_expire.Text = days.ToString();

                    dtp_expireDate.Value = System.DateTime.Now + System.TimeSpan.FromDays(days);
                    SignURL();
                }
                catch
                {
                }
                finally
                {
                    locked = false;
                }
            }
        }
    }
}