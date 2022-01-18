using Alura.ListaLeitura.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.WebAPI.Api.Modelos
{
    public class LivroPaginacao
    {
        public int Pagina { get; set; }
        public int Tamanho { get; set; }
    }

    public class LivroPaginado
    {
        public int Total { get; set; }

        public int TamanhoPagina { get; set; }
        public int NumeroPagina { get; set; }
        public int TotalPaginas { get; set; }
        public IList<LivroApi> Resultado { get; set; }
        public string Anterior { get; set; }
        public string ProximaPagina { get; set; }
    }
}
