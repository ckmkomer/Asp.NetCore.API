using BookCenter.Data;
using BookCenter.DTOs.AuthorDto;
using BookCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly BookCenterContext _bookCenter;

        public AuthorController(BookCenterContext bookCenter)
        {
            _bookCenter = bookCenter;
        }
    }
}

   