using System;
using Microsoft.AspNetCore.Mvc;
using Ticket_Backend.Data.Repository.IRepository;
using Ticket_Backend.models;

namespace Ticket_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("User")]
    public class UserController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public UserController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(string? role)
        {
            IEnumerable<User> objUserList = _unitOfWork.User.GetAll(u => u.Role == role);
            return Json(new { data = objUserList });
        }

        [HttpGet("GetOne")]
        public IActionResult GetOne(int? id)
        {
            var obj = _unitOfWork.User.GetFirstOrDefault(u => u.Id == id);

            return Json(new { obj });

        }


    }
}
