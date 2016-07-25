using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BilibiliForm
{
    class UrlInfo
    {
        /// <summary>
        /// 获取视频下载地址
        /// </summary>
        /// <param name="strUrl"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GetUrl(string strUrl, string type, out DataTable dtUrl)
        {
            dtUrl = new DataTable();
            dtUrl.Columns.Add("url");
            string strHref = string.Empty;
            string url = string.Format("http://www.flvcd.com/parse.php?kw={0}&flag=one&format={1}", strUrl, type);
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                htmlWeb.OverrideEncoding = Encoding.GetEncoding("gb2312");
                HtmlDocument htmlDoc = htmlWeb.Load(url);
                HtmlNode node = htmlDoc.DocumentNode.SelectSingleNode("//a[@class='link']");
                if (node == null)
                {
                    HtmlNodeCollection mainNodeList = htmlDoc.DocumentNode.SelectNodes("//a[@onclick='_alert();return false;']");
                    foreach(HtmlNode hn in mainNodeList)
                    {
                        DataRow dr = dtUrl.NewRow();
                        dr["url"] = hn.Attributes["href"].Value;
                        dtUrl.Rows.Add(dr);
                    }
                }
                else
                {
                    strHref = node.Attributes["href"].Value;
                }
                return strHref;
            }
            catch(Exception ex)
            {
                return "";
            }
        }

        /// <summary>
        /// 获取视频信息
        /// </summary>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public DataTable GetVideoInfo(string strUrl)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            dt.Columns.Add("UpUser");
            dt.Columns.Add("ImgUrl");
            HtmlNode node = null;
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(GetHtml(strUrl));
                DataRow dr = dt.NewRow();
                node = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='v-title']"); //视频标题
                dr["Title"] = node.InnerText;
                node = htmlDoc.DocumentNode.SelectSingleNode("//a[@class='name']"); //视频UP主
                dr["UpUser"] = node.InnerText;
                node = htmlDoc.DocumentNode.SelectSingleNode("//img[@class='cover_image']"); //视频封面
                dr["ImgUrl"] = node.Attributes["src"].Value;
                dt.Rows.Add(dr);
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        /// <summary>
        /// 解压HTML
        /// </summary>
        /// <param name="strurl"></param>
        /// <returns></returns>
        static string GetHtml(string strurl)
        {
            StringBuilder html = new StringBuilder(102400);
            WebRequest request = WebRequest.Create(strurl);
            request.Method = "get";
            WebResponse res = request.GetResponse();
            if (res.Headers.ToString().IndexOf("gzip") > -1)
            {
                WebClient wr = new WebClient();
                wr.Headers[HttpRequestHeader.AcceptEncoding] = "gzip, deflate";
                byte[] buffer = wr.DownloadData(strurl);
                GZipStream g = new GZipStream((Stream)(new MemoryStream(buffer)), CompressionMode.Decompress);
                byte[] d = new byte[20480];
                int l = g.Read(d, 0, 20480);
                while (l > 0)
                {
                    html.Append(Encoding.UTF8.GetString(d, 0, l));
                    l = g.Read(d, 0, 20480);
                }
            }
            else
            {
                StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.UTF8);
                html.Append(sr.ReadToEnd());
                sr.Close();
                res.Close();
            }
            return html.ToString();
        }
    }
}
