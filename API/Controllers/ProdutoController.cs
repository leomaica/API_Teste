using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
 

    public class ProdutoController : ControllerBase
    {
        private readonly IAppicationServiceProduto _appicationServiceProduto;
        public ProdutoController(IAppicationServiceProduto appicationServiceProduto)
        {
            this._appicationServiceProduto = appicationServiceProduto;          
                
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<string>>  GetAll()
        {
            return Ok(_appicationServiceProduto.GetAll());
        }

        [HttpGet]
        public ActionResult<string> Get(int id)
        {
            return Ok(_appicationServiceProduto.GetById(id));
        }

        [HttpPost]       
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                if (produtoDto.DataFabricacao >= produtoDto.DataValidade)
                    return BadRequest("Data de Fabricação não pode ser maior ou igual a Data de Validade.");

               _appicationServiceProduto.Add(produtoDto);
                return Ok("Produto Cadastrado com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
           
        }


        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                if (produtoDto.DataFabricacao >= produtoDto.DataValidade)
                    return BadRequest("Data de Fabricação não pode ser maior ou igual a Data de Validade.");

                _appicationServiceProduto.Update(produtoDto);
                return Ok("Produto Atualizado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        [HttpDelete]
        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _appicationServiceProduto.Remove(produtoDto);
                return Ok("Produto Excluído com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
