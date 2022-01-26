using System;
using Microsoft.AspNetCore.Mvc;
using Ticket_Backend.Data.Repository.IRepository;
using Ticket_Backend.models;

namespace Ticket_Backend.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Customer")]
	public class CustomerController : Controller
	{

        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public CustomerController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet("GetOne")]
        public IActionResult GetOne(string? tel)
        {
            var obj = _unitOfWork.Customer.GetFirstOrDefault(c => c.Tel == tel);
       
            return Json(new { obj });
        }

        [HttpPost("Register")]
        public IActionResult Register(Customer obj)
        {
            _unitOfWork.Customer.Add(obj);
            _unitOfWork.save();

            return Json(new {  });
        }
    }
}

