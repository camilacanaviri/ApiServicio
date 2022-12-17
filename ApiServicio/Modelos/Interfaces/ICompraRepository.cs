using ApiServicio.Modelos.Dato;

namespace ApiServicio.Modelos.Interfaces
{
    public interface ICompraRepository
    {
        Task<Compra> CreateCompraAsync(Compra compra);
        Task<bool> DeleteCompraAsync(Compra compra);
        Compra GetCompraById(decimal IdCompra);
        IEnumerable<Compra> GetCompras();
        Task<bool> UpdateCompraAsync(Compra compra);
    }
}
