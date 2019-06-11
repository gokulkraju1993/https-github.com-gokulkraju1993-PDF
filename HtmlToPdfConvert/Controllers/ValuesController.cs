using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IronPdf;

namespace HtmlToPdfConvert.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpPost]
        public ActionResult<string> CreatePdf([FromForm] string HTMLString)
        {
            DateTime currentDate = DateTime.Now;
            //var Renderer = new IronPdf.HtmlToPdf();
            //var PDF = Renderer.RenderHtmlAsPdf(HTMLString);
            var OutputPath = currentDate.Ticks.ToString() + "HtmlToPDF.pdf";
            //PDF.SaveAs(@"C:\Users\gokul.raju\Desktop\Test\" + OutputPath);
            //return (@"C:\Users\gokul.raju\Desktop\Test\" + OutputPath);


            HtmlToPdf HtmlToPdf = new IronPdf.HtmlToPdf();
            HtmlToPdf.RenderHtmlAsPdf(HTMLString).SaveAs(@"C:\Users\gokul.raju\Desktop\Test\" + OutputPath);
            return (@"C:\Users\gokul.raju\Desktop\Test\" + OutputPath);
        }
    }
}
