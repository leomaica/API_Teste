using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Entities
{
    public class Produtos:Base
    {
        public int CodProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public bool SituacaoProduto { get; set;}        
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int CodFornecedor { get; set; }
        public string DescricaoFornecedor { get; set;}
        public string CNPJFornecedor { get; set;}

     
    }
}
