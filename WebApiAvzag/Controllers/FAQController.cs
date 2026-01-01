using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAvzag.Models.FAQ;

namespace WebApiAvzag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQController : ControllerBase
    {
        Dictionary<string, CategoryJson> resp = new Dictionary<string, CategoryJson>() {
            { "1", new CategoryJson() {
                questions = new List<QuestionItem> {
                    new QuestionItem("sd", "ds") } } },
            { "2", new CategoryJson() {
                questions = new List<QuestionItem> {
                    new QuestionItem("sd", "ds") } } },
            { "3", new CategoryJson() {
                questions = new List<QuestionItem> {
                    new QuestionItem("sd", "ds") } } }
        };

        [HttpGet(Name = "FAQ")]
        public ActionResult Index()
        {
            return Ok(resp);
        }
    }
}
