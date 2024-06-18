using Application.Dtos;
using Application.Interfaces;
using Domains.Entities;

namespace Infra.CrossCutting.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        IEnumerable<ProdutoDto> _produtoDto = new List<ProdutoDto>();

        public Produtos MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produtos()
            {
                 Id = produtoDto.Id,
                 CodProduto = produtoDto.CodProduto,
                 DescricaoProduto = produtoDto.DescricaoProduto,
                 SituacaoProduto = produtoDto.SituacaoProduto,
                 DataFabricacao = produtoDto.DataFabricacao,
                 DataValidade  = produtoDto.DataValidade,
                 CodFornecedor = produtoDto.CodFornecedor,
                 DescricaoFornecedor = produtoDto.DescricaoFornecedor,
                CNPJFornecedor = produtoDto.CNPJFornecedor
            };

            return produto;
        }


        public ProdutoDto MapperEntityToDto(Produtos produto)
        {
            var ProdutoDto = new ProdutoDto()
            {
                Id = produto.Id,
                CodProduto = produto.CodProduto,
                DescricaoProduto = produto.DescricaoProduto,
                SituacaoProduto = produto.SituacaoProduto,
                DataFabricacao = produto.DataFabricacao,
                DataValidade = produto.DataValidade,
                CodFornecedor = produto.CodFornecedor,
                DescricaoFornecedor = produto.DescricaoFornecedor,
                CNPJFornecedor = produto.CNPJFornecedor

            };

            return ProdutoDto;
            
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produtos> produtos)
        {
            var dto = produtos.Select(c => new ProdutoDto
            {
                Id = c.Id,
                CodProduto = c.CodProduto,
                DescricaoProduto = c.DescricaoProduto,
                SituacaoProduto = c.SituacaoProduto,
                DataFabricacao = c.DataFabricacao,
                DataValidade = c.DataValidade,
                CodFornecedor = c.CodFornecedor,
                DescricaoFornecedor = c.DescricaoFornecedor,
                CNPJFornecedor = c.CNPJFornecedor
            });
            
            return dto;

        }
    }
}
