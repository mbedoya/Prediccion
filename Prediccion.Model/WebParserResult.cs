using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prediccion.Model
{
    public class WebParserResult
    {
        public string HtmlContent { get; set; }
        public WebParserResultStatus Status { get; set; }
    }
    public enum WebParserResultStatus
    {
        ElementNotFound,
        Success
    }
}
