using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace ayush.Services
{
    public class SmsService: ISmsService
    {
        public void SendSMS(string body, string phoneNumber)
        {
            try
            {
                string message_to_customer = HttpUtility.UrlEncode("Your ID is Locked Successfully with First Purchasing Pin");
                StringBuilder sbPostData = new StringBuilder();
                sbPostData.AppendFormat("authkey={0}", "230514AFYTve0O3T5b69db12");
                sbPostData.AppendFormat("&mobiles={0}", phoneNumber);
                sbPostData.AppendFormat("&message={0}", body);
                sbPostData.AppendFormat("&sender={0}", "BLense");
                sbPostData.AppendFormat("&route={0}", "4");
                string sendSMSUri = "https://control.msg91.com/api/sendhttp.php";
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(sendSMSUri);
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] data = encoding.GetBytes(sbPostData.ToString());
                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/x-www-form-urlencoded";
                httpWReq.ContentLength = data.Length;
                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseString = reader.ReadToEnd();
                reader.Close();
                response.Close();
            }
            catch
            {

            }
        }
	}
    public interface ISmsService
    {
        void SendSMS(string body, string phoneNumber);
    }
}
