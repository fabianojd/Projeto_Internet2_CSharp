 using Microsoft.AspNetCore.Mvc;
 [Route("api/[controller]")]
 [ApiController]
 public class TipoCursoController : ControllerBase
 {
    [HttpGet]
    public ActionResult<IEnumerable<TipoCurso>> Get()
    {
        return new List<TipoCurso>();
    }

    [HttpPost]
    public ActionResult Post(TipoCurso item)
    {
        return Ok("Apenas validando os dados");
    }

 }