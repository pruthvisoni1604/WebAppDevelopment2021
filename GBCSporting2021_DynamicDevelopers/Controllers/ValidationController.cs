//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Threading.Tasks;
//using GBCSporting2021_DynamicDevelopers.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace GBCSporting2021_DynamicDevelopers.Controllers
//{
//    public class ValidationController : Controller
//    {
//        private readonly Context _context;
//        public ValidationController() : this(new EF_UserRepository()) { }

//        public ValidationController(Context context)
//        {
//            context = _context;
//        }

//        public JsonResult IsEmailID_Available(string Username)
//        {

//            if (!_context.UserExists(Username))
//                return Json(true, JsonRequestBehavior.AllowGet);

//            string suggestedUID = String.Format(CultureInfo.InvariantCulture,
//                "{0} is not available.", Username);

//            for (int i = 1; i < 100; i++)
//            {
//                string altCandidate = Username + i.ToString();
//                if (!_context.UserExists(altCandidate))
//                {
//                    suggestedUID = String.Format(CultureInfo.InvariantCulture,
//                   "{0} is not available. Try {1}.", Username, altCandidate);
//                    break;
//                }
//            }
//            return Json(suggestedUID, JsonRequestBehavior.AllowGet);
//        }

//        private JsonResult Json(bool v, object allowGet)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}