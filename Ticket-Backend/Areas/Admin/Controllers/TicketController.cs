//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
////using Admin.Models;

//namespace Admin.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TicketController : ControllerBase
//    {
//        public TicketController()
//        {
//        }

//        [HttpGet("")]
//        public ActionResult<IEnumerable<TModel>> GetTModels()
//        {
//            return new List<TModel> { };
//        }

//        [HttpGet("{id}")]
//        public ActionResult<TModel> GetTModelById(int id)
//        {
//            return null;
//        }

//        [HttpPost("")]
//        public ActionResult<TModel> PostTModel(TModel model)
//        {
//            return null;
//        }

//        [HttpPut("{id}")]
//        public IActionResult PutTModel(int id, TModel model)
//        {
//            return NoContent();
//        }

//        [HttpDelete("{id}")]
//        public ActionResult<TModel> DeleteTModelById(int id)
//        {
//            return null;
//        }
//    }
//}