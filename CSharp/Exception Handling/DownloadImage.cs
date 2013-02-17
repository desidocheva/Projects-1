using System;
using System.Net;
using System.IO;
using System.Text;
class DownloadImage
{
    static void Main()
    {
        WebClient webClient = new WebClient();
        try
        {
            string path = Directory.GetCurrentDirectory();
            StringBuilder saveFilePath = new StringBuilder();
            saveFilePath.AppendFormat(@"{0}\CSharp.jpg", path);

            webClient.DownloadFile(@"http://www.ivsblog.eu/wp-content/uploads/2013/01/CSharpHW-150x150.jpg", saveFilePath.ToString());
        }
        catch (WebException)
        {
            Console.WriteLine("filename is a null reference or there is a problem occured with the downloading.");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("Access Denied.\nThe caller does not have the required permission.");
        }
        finally
        {
            webClient.Dispose();
        }
        
    }
}
