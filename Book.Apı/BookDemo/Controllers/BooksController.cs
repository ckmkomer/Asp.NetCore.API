using BookDemo.Data;
using BookDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAlBooks()
        {
            var books = BookContext.Books.ToList();
            return Ok(books);
        }
        [HttpGet("{id:int}")]// controllerin her iki HttpGet action metodun farklı oldğunu anlması için parametre olarak id=int olarak yazıyoruz.
        public IActionResult GetId([FromRoute(Name = "id")] int id)//FromRoute ile Id'nin nerden geleceğini söylemiş olduk.
        {
            var book = BookContext
                .Books
                .Where(x => x.Id == id)
                .SingleOrDefault();// ling sorgusu ile parametreden gelen ıd'i ye eşit olanları getir dedik ve singleordefault() ifadesi ilde tek bir kaydı istedik.

            if (book is null)
            {
                /*return NotFound(); *///404

                return BadRequest("Hatalı ID girişi yaptınız");

            }
            else
            {
                return Ok(book);
            }


        }

        [HttpPost]

        public IActionResult Create([FromBody] Book book)//FromBody book ifadesinin requiatin bodysinde geleceğini belirtiyoruz.
        {
            try
            {
                if (book is null)
                {
                    return BadRequest();//400

                }
                else
                {
                    BookContext.Books.Add(book);
                    return StatusCode(201, book);
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);//hatanın ayrıntısını verir.
            }
        }

        [HttpPut("{id=int}")]// bu lısma int id yazammaıza gerel yok ancak güvenli kod yazmak istiyorsak yazabiliriz.
        public IActionResult Update([FromRoute(Name ="id")] int id,
           [FromBody] Book book) 
        {
            var entity = BookContext.
                Books.Find(x => x.Id == id); //parametreden değere göre bul.

            //if (entity is null)
            
            //    return NotFound();//404

            ////chek id
            //if (id! == book.Id)

            //    return BadRequest();//400
            
                BookContext.Books.Remove(entity);
                book.Id = entity.Id;
                BookContext.Books.Add(book);
                return Ok(book);
            
        }

        [HttpDelete]
        public IActionResult DeleteAll()
        {
            BookContext.Books.Clear();
            return NoContent();//204
        }

        [HttpDelete("{id=int}")]
        public IActionResult DeleteId([FromRoute(Name ="id")]int id)
        {
         var enntity=   BookContext.Books.Find(x=>x.Id == id);
            if (enntity is null)
                return NotFound(new

                {

                    StatusCode=404,
                    message=$"Book with id:{id} could not found."
                });
            BookContext.Books.Remove(enntity);
            return NoContent();
        }
    }
}
