using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace 第九次课堂作业
{
    class GetHtml
    {
        public static string getHtml(string url) 
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                Stream resStresm = response.GetResponseStream();
                StreamReader sr = new StreamReader(resStresm);
                return sr.ReadToEnd();
            }
            catch (System.UriFormatException exception) 
            {
                return "该URL格式有错误" + "\r\n" + exception.Message.ToString();
            }
        }
        public static string getEmail(string message) 
        {
            string result = "";
            string findEmail = @"\w[-\w.+]*@([A-Za-z0-9][-A-Za-z0-9]+\.)+[A-Za-z]{2,14}";
            string findPhone = @" /^1[3-9]{1}[0-9]{9}$/";
            foreach (Match match in Regex.Matches(message, findEmail)) 
            {
                result += "\r\n" + match.Value;
            }
            foreach (Match match in Regex.Matches(message, findPhone))
            {
                result += "\r\n" + match.Value;
            }
            if (result == "") 
            {
                result += "未找到电话号码或邮箱";
            }
            return result;
        }

    }
}
