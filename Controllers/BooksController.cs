using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace csLibrary.Controllers
{


  [ApiController]
  [Route("api/[controller]")]

  public class BooksController : ControllerBase
  {


    [HttpGet]
    public ActionResult<Book> Get()
    {
      try
      {
        return Ok(services);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    [HttpGet("{bookId}")]
    public ActionResult<Book> Get(string bookId)
    {
      try
      {
        Book found = services(b => b.id == bookId);
        if (found == null)
        {
          throw new Exception("invalid id");
        }
        return Ok(found);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Book> Create([FromBody] Book newBook);
{
  try
  {
      
  }
  catch (System.Exception)
  {
      
      throw;
  }
}





  }
}