using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Prediccion.Model
{
    public class WebDownloader
    {
        public static WebDownloaderResult GetContent(string url)
        {
            WebDownloaderResult result = new WebDownloaderResult();

            WebClient client = new WebClient();
            result.HtmlContent = client.DownloadString(url);
             
            return result;
        }
    }
}
