using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace BARS_Emulyator
{
    public class Util
    {
        public static string GetPropertyName<T>(Expression<Func<T>> propertyLambda)
        {
            var me = propertyLambda.Body as MemberExpression;

            if (me == null)
            {
                throw new ArgumentException("You must pass a lambda of the form: '() => Class.Property' or '() => object.Property'");
            }

            return me.Member.Name;
        }

        public static string GetSessionId(string responseString)
        {
            string sessionId = String.Empty;

            if (sessionId.IndexOf("ERROR") == -1)
            {
                int startIndex = -1;
                int lastIndex = -1;
                string findText = "sessionId\":\"";

                startIndex = responseString.IndexOf(findText) + findText.Length;
                lastIndex = responseString.IndexOf("\"},\"message_id\"");

                if (lastIndex > startIndex)
                    sessionId = responseString.Substring(startIndex, lastIndex - startIndex);
            }

            return sessionId;
        }

        public static string ReplaceSessionId(string source, string sessionId)
        {
            var reg = new Regex(":\".+\",\"method\"");
            
            source = reg.Replace(source, string.Format(":\"{0}\",\"method\"", sessionId));
            
            return source;
        }

        public static string CopyImageToProgramFolder(string fileName)
        {
            string copyPath = Directory.GetCurrentDirectory() + "\\Images\\";

            if (!Directory.Exists(copyPath))
            {
                Directory.CreateDirectory(copyPath);
            }

            string fileShortName = fileName.Split('\\').LastOrDefault();

            string resultPath = copyPath + fileShortName;

            File.Copy(fileName, resultPath, true);

            return resultPath;
        }


        public static string ConvertImageToBase64Strimg(string path)
        {
            string base64String = String.Empty;

            if (path.Trim() != String.Empty)
            {
                //if (!path.EndsWith(".pdf"))
                //{
                //    Image image = Image.FromFile(path);

                //    using (MemoryStream ms = new MemoryStream())
                //    {
                //        image.Save(ms, ImageFormat.Tiff);
                //        byte[] imageBytes = ms.ToArray();

                //        base64String = Convert.ToBase64String(imageBytes);


                //        Byte[] bitmapData = new Byte[base64String.Length];

                //        bitmapData = Convert.FromBase64String(base64String);

                //        using (MemoryStream streamBitmap = new MemoryStream(bitmapData))
                //        {
                //            Bitmap bitImage = new Bitmap((Bitmap)Image.FromStream(streamBitmap));
                //            bitImage.Save(@"C:\TIff\myTiff.tiff");
                //        }   
                //    }
                //}
                //else
                //{
                    byte[] pdfBytes = File.ReadAllBytes(path);
                    base64String = Convert.ToBase64String(pdfBytes);
                //}
            }
            return base64String;
        }

        public static string SendRequest(string postData, string barsUrl)
        {
            WebRequest request = WebRequest.Create(barsUrl);
            request.Method = "POST";
            request.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();

            dataStream.Write(byteArray, 0, byteArray.Length);

            dataStream.Close();

            WebResponse response = request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

    }
}
