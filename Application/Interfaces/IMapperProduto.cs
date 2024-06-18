using Application.Dtos;
using Domains.Entities;


namespace Application.Interfaces
{
    public interface IMapperProduto
    {
        Produtos MapperDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produtos> produtos);
        ProdutoDto MapperEntityToDto(Produtos produto);

    }
}
