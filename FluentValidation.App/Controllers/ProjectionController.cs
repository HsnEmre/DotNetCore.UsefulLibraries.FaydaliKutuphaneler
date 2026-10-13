using AutoMapper;
using FluentValidation.App.DTO;
using FluentValidation.App.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.App.Controllers
{
    public class ProjectionController : Controller
    {

        private readonly IMapper _mapper;

        public ProjectionController(IMapper mapper)
        {
            _mapper = mapper;
        }



        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EvenDateDto evetnDateDto)
        {
            EventDate eventDate = _mapper.Map<EventDate>(evetnDateDto);


            return View();
        }
    }
}
