using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatBotApi.Controllers
{
    public class QuestionsController : Controller
    {
        //
        // GET: /Questions/

        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAllQuestionDetails()
        {
            ChatbotContext cb = new ChatbotContext();
            var chatbotResult = (from a in cb.ChatBot
                                 select new
                                 {
                                     a.ContactId,
                                     a.Desc,
                                     a.IsHeader,
                                     a.LevelId,
                                     a.ParentId,
                                     a.QID
                                 }).ToList();

            return Json(new { QuestionMaster = chatbotResult }, JsonRequestBehavior.AllowGet);
        }



        [HttpGet]
        public ActionResult GetAllContactDetails()
        {
            ChatbotContext cb = new ChatbotContext();
            var chatbotResult = (from a in cb.ContactInfromation
                                 select new
                                 {
                                     a.id,
                                     a.name,
                                     a.phoneNumber,
                                     a.website,
                                     a.email,
                                     a.Address,

                                 }).ToList();

            return Json(new { ContactInfromation = chatbotResult }, JsonRequestBehavior.AllowGet);
        }

    }
}
