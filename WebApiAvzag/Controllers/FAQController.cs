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
            { "Общие вопросы", new CategoryJson() {
                questions = new List<QuestionItem> {
                    new QuestionItem("Что такое «Авзаг»?", "«Авзаг» — это бесплатное приложение для изучения осетинского языка с нуля. Мы используем игровые методики, короткие уроки и практические задания, чтобы сделать обучение эффективным и интересным."),
                    new QuestionItem("Почему стоит учить осетинский язык?", "Осетинский язык — это уникальное наследие, ключ к богатой культуре, эпосу «Нарты» и многовековой истории осетинского народа. Его изучение помогает сохранить и передать традиции будущим поколениям.")
                } } },
            { "Особенности осетинского языка", new CategoryJson() {
                questions = new List<QuestionItem> {
                    new QuestionItem("Сложно ли выучить осетинский?", "Как любой новый язык, он требует практики. Наше приложение разбивает сложные темы (например, падежи или глагольные формы) на простые шаги. Алфавит на кириллице знаком, что является плюсом для русскоговорящих."),
                    new QuestionItem("Какой диалект я буду учить?", "В основном курсе представлен иронский диалект (литературная норма). В разделе «Культура» вы сможете познакомиться и с особенностями дигорского диалекта."),
                    new QuestionItem("Поможет ли приложение с произношением?","Конечно! В каждом уроке есть аудиозаписи от носителей языка. Вы можете записывать свой голос и сравнивать с эталоном.\r\n\r\n")
                } } }
        };

        [HttpGet(Name = "FAQ")]
        public ActionResult Index()
        {
            return Ok(resp);
        }
    }
}
