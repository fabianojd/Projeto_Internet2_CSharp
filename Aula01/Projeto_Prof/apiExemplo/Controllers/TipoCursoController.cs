using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class TipoCursoController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<TipoCurso>> Get() 
    {
        List<TipoCurso> list = new List<TipoCurso>();
        list.Add(new TipoCurso {Id = 1, Nome = "Superior", Descricao = "aaa"});
        return list;
    }

    [HttpPost]
    public ActionResult Post([FromBody]TipoCurso item)
    {
        return Ok("Sucesso");
    }
}