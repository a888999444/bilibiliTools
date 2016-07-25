using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilibiliForm
{
    public partial class MainForm : Skin_Mac
    {
        Thread th = null;
        UrlInfo info = new UrlInfo();
        private delegate void WorkState();
        private delegate void ShowState(string msg, DataTable dt, bool suc, bool cleartxt);

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string strMsg = string.Empty;
            if (!checkUrl(this.txtUrl.Text.Trim(), out strMsg))
            {
                MessageBox.Show(strMsg, "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            th = new Thread(new ThreadStart(ThreadRun));
            th.Start();
        }

        /// <summary>
        /// 检查输入的链接
        /// </summary>
        /// <param name="strUrl"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        private bool checkUrl(string strUrl, out string msg)
        {
            int d = strUrl.IndexOf("bilibili");
            int s = strUrl.IndexOf("vb");
            if (string.IsNullOrEmpty(strUrl))
            {
                msg = "本宝宝还没智能到凭空解析>_<|||";
                return false;
            }
            if (strUrl.IndexOf("bilibili") == -1 || strUrl.IndexOf("video") == -1 || strUrl.IndexOf("av") == -1)
            {
                msg = "本宝宝都不知主淫输入的是什么鬼>_<|||";
                return false;
            }
            msg = "";
            return true;
        }

        private void btnbqCopy_Click(object sender, EventArgs e)
        {
            string strbq = this.lblbq.Text.Trim();
            string strCount = this.lblbqCount.Text.Trim();
            if (!string.IsNullOrEmpty(strbq))
            {
                Clipboard.SetDataObject(strbq);
                if (!string.IsNullOrEmpty(strCount))
                    MessageBox.Show("下载地址已经复制到粘贴板，该视频B站自动分成了" + strCount + "个视频，请先粘贴到TXT再下载>3<", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("下载地址已经复制到粘贴板>3<", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("暂时还没标清的下载地址>_<|||", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btngqCopy_Click(object sender, EventArgs e)
        {
            string strgq = this.lblgq.Text.Trim();
            string strCount = this.lblgqCount.Text.Trim();
            if (!string.IsNullOrEmpty(strgq))
            {
                Clipboard.SetDataObject(strgq);
                if (!string.IsNullOrEmpty(strCount))
                    MessageBox.Show("下载地址已经复制到粘贴板，该视频B站自动分成了" + strCount + "个视频，请先粘贴到TXT再下载>3<", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("下载地址已经复制到粘贴板>3<", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("暂时还没高清的下载地址>_<|||", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btncqCopy_Click(object sender, EventArgs e)
        {
            string strcq = this.lblcq.Text.Trim();
            string strCount = this.lblcqCount.Text.Trim();
            if (!string.IsNullOrEmpty(strcq))
            {
                Clipboard.SetDataObject(strcq);
                if (!string.IsNullOrEmpty(strCount))
                    MessageBox.Show("下载地址已经复制到粘贴板，该视频B站自动分成了" + strCount + "个视频，请先粘贴到TXT再下载>3<", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("下载地址已经复制到粘贴板>3<", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("暂时还没超清的下载地址>_<|||", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnbqDown_Click(object sender, EventArgs e)
        {
            string strbq = this.lblbq.Text.Trim();
            string strCount = this.lblbqCount.Text.Trim();
            if (!string.IsNullOrEmpty(strbq))
            {
                if (!string.IsNullOrEmpty(strCount))
                {
                    Clipboard.SetDataObject(strbq);
                    MessageBox.Show("下载地址已经复制到粘贴板，该视频B站自动分成了" + strCount + "个视频，请先粘贴到TXT再下载>3<", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    System.Diagnostics.Process.Start(strbq);
            }
            else
            {
                MessageBox.Show("暂时还没标清的下载地址>_<|||", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btngqDown_Click(object sender, EventArgs e)
        {
            string strgq = this.lblgq.Text.Trim();
            string strCount = this.lblgqCount.Text.Trim();
            if (!string.IsNullOrEmpty(strgq))
            {
                if (!string.IsNullOrEmpty(strCount))
                {
                    Clipboard.SetDataObject(strgq);
                    MessageBox.Show("下载地址已经复制到粘贴板，该视频B站自动分成了" + strCount + "个视频，请先粘贴到TXT再下载>3<", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    System.Diagnostics.Process.Start(strgq);
            }
            else
            {
                MessageBox.Show("暂时还没高清的下载地址>_<|||", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btncqDown_Click(object sender, EventArgs e)
        {
            string strcq = this.lblcq.Text.Trim();
            string strCount = this.lblcqCount.Text.Trim();
            if (!string.IsNullOrEmpty(strcq))
            {
                if (!string.IsNullOrEmpty(strCount))
                {
                    Clipboard.SetDataObject(strcq);
                    MessageBox.Show("下载地址已经复制到粘贴板，该视频B站自动分成了" + strCount + "个视频，请先粘贴到TXT再下载>3<", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    System.Diagnostics.Process.Start(strcq);
            }
            else
            {
                MessageBox.Show("暂时还没超清的下载地址>_<|||", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ThreadRun()
        {
            WorkState ss = new WorkState(GetVideoUrl);
            ss.BeginInvoke(null, null);
        }

        private void GetVideoUrl()
        {
            string bqurl = string.Empty;
            string gqurl = string.Empty;
            string cqurl = string.Empty;
            string strUrl = string.Empty;
            StringBuilder sbUrl = new StringBuilder();
            DataTable dt = null;
            DataTable dtUrl = null;
            ShowTXT("----开始执行----\n", dt, false, true);
            try
            {
                strUrl = this.txtUrl.Text.Trim();
                ShowTXT("①正在获取视频信息.........\n", dt, false, false);
                #region 视频信息
                //视频信息
                dt = info.GetVideoInfo(strUrl);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("视频信息获取失败>3<", "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                
                #endregion
                Thread.Sleep(1000);
                ShowTXT("------->获取成功\n", dt, false, false);
                ShowTXT("②正在获取标清下载地址.........\n", dt, false, false);
                #region 下载地址
                //标清
                bqurl = info.GetUrl(strUrl, "", out dtUrl);
                if (dtUrl.Rows.Count > 0)
                {
                    sbUrl.Clear();
                    for(int i = 0; i < dtUrl.Rows.Count; i++)
                    {
                        sbUrl.AppendLine(dtUrl.Rows[i]["url"].ToString());
                    }
                    this.lblbqCount.Text = dtUrl.Rows.Count.ToString();
                    this.lblbq.Text = sbUrl.ToString();
                }
                else
                {
                    if (!string.IsNullOrEmpty(bqurl))
                    {
                        this.lblbqCount.Text = "";
                        this.lblbq.Text = bqurl;
                    }
                }
                
                Thread.Sleep(1000);
                ShowTXT("------->获取成功\n", dt, false, false);
                ShowTXT("③正在获取高清下载地址.........\n", dt, false, false);
                //高清
                gqurl = info.GetUrl(strUrl, "high", out dtUrl);
                if (dtUrl.Rows.Count > 0)
                {
                    sbUrl.Clear();
                    for (int i = 0; i < dtUrl.Rows.Count; i++)
                    {
                        sbUrl.AppendLine(dtUrl.Rows[i]["url"].ToString());
                    }
                    this.lblgqCount.Text = dtUrl.Rows.Count.ToString();
                    this.lblgq.Text = sbUrl.ToString();
                }
                else
                {
                    if (!string.IsNullOrEmpty(gqurl))
                    {
                        this.lblgqCount.Text = "";
                        this.lblgq.Text = gqurl;
                    }
                }
                Thread.Sleep(1000);
                ShowTXT("------->获取成功\n", dt, false, false);
                ShowTXT("④正在获取超清下载地址.........\n", dt, false, false);
                //超清
                cqurl = info.GetUrl(strUrl, "super", out dtUrl);
                if (dtUrl.Rows.Count > 0)
                {
                    sbUrl.Clear();
                    for (int i = 0; i < dtUrl.Rows.Count; i++)
                    {
                        sbUrl.AppendLine(dtUrl.Rows[i]["url"].ToString());
                    }
                    this.lblcqCount.Text = dtUrl.Rows.Count.ToString();
                    this.lblcq.Text = sbUrl.ToString();
                }
                else
                {
                    if (!string.IsNullOrEmpty(cqurl))
                    {
                        this.lblcqCount.Text = "";
                        this.lblcq.Text = cqurl;
                    }
                }
                Thread.Sleep(1000);
                ShowTXT("------->获取成功\n", dt, true, false);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "来自本宝宝的提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ShowTXT(string msg, DataTable dt, bool suc, bool cleartxt)
        {
            if (txtStatus.InvokeRequired)
            {
                ShowState sh = new ShowState(ShowTXT);
                this.BeginInvoke(sh, new object[] { msg, dt, suc, cleartxt });
            }
            else
            {
                if (cleartxt)
                {
                    this.txtStatus.Clear();
                    this.txtUrl.Enabled = false;
                    this.btnGo.Enabled = false;
                    this.lblbq.Text = "";
                    this.lblgq.Text = "";
                    this.lblcq.Text = "";
                }
                this.txtStatus.AppendText(msg);
                if (suc)
                {
                    this.lblTitle.Text = dt.Rows[0]["Title"].ToString();
                    this.lblUser.Text = dt.Rows[0]["UpUser"].ToString();
                    this.pbLogo.ImageLocation = @dt.Rows[0]["ImgUrl"].ToString();
                    this.lblTitle.Visible = true;
                    this.lblUser.Visible = true;
                    this.txtUrl.Enabled = true;
                    this.btnGo.Enabled = true;
                    Thread.Sleep(1000);
                    this.txtStatus.AppendText("【全部信息获取完成】");
                    th.Abort();
                }
            }
        }

        private void nIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                this.Activate();
            }
        }

        private void 显示主窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                this.Activate();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.nIcon.Visible = false;
            this.Dispose();
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }
    }
}
