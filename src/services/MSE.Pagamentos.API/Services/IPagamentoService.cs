using System;
using System.Threading.Tasks;
using MSE.Core.Messages.Integration;
using MSE.Pagamentos.API.Models;

namespace MSE.Pagamentos.API.Services
{
    public interface IPagamentoService
    {
        Task<ResponseMessage> AutorizarPagamento(Pagamento pagamento);
        Task<ResponseMessage> CapturarPagamento(Guid pedidoId);
        Task<ResponseMessage> CancelarPagamento(Guid pedidoId);
    }
}