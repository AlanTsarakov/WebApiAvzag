using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAvzag.Models;

namespace WebApiAvzag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        [HttpGet(Name = "section")]
        public ActionResult GetSectionDetails([FromQuery] int sectionId = 1)
        {
            var sectionData = new SectionData
            {
                Section = new Section
                {
                    Name = "Раздел 1",
                    TotalChaptersInUnit = 7,
                    TotalUnitsInSection = 1,
                    Units = GenerateUnits(sectionId)
                }
            };

            return Ok(sectionData);
        }

        private List<Unit> GenerateUnits(int section)
        {
            return new List<Unit>
            {
                new Unit
                {
                    Name = "Юнит 1",
                    Description = "Безовые предложения",
                    Chapters = new List<string>
                    {
                        "Базовые предложения",
                        "Практика приветсвий",
                        "Практика приветсвий",
                        "Практика приветсвий",
                        "Практика приветсвий",
                        "Практика приветсвий",
                        "Практика приветсвий"
                    }
                }
            };
        }
    }
}
