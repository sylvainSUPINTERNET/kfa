using System.Threading.Tasks;
using AutoMapper;
using Dto;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        private readonly IMapper _mapper;
        
        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;

        }
        [HttpGet("create/mock")]
        public async Task<ActionResult> CreateMockBook()
        {
            Book bCreated = await _bookService.Create();
            return Ok(_mapper.Map<BookDto>(bCreated));

        }
    }
}