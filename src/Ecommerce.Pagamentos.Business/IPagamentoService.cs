using System.Threading.Tasks;
using Ecommerce.Core.DomainObjects.DTO;

namespace Ecommerce.Pagamentos.Business
{
    public interface IPagamentoService
    {
        Task<Transacao> RealizarPagamentoPedido(PagamentoPedido pagamentoPedido);
    }
}