using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prediccion.Model
{
    public class WebDownloaderResult
    {
        public string HtmlContent { get; set; }
        public DownloadResultStatus Status { get; set; }
    }

    public enum DownloadResultStatus
    {
        UrlNotFound,
        InvalidUrl,
        Success
    }
}
