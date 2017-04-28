using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prediccion.Model
{
    public class WebParser
    {
        public static WebParserResult GetElementById(string id)
        {
            WebParserResult result = new WebParserResult();
            result.HtmlContent = null;
            result.Status = WebParserResultStatus.Success;

            return result;
        }
    }
}
