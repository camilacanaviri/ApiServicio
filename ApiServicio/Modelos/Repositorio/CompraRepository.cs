using ApiServicio.Modelos.Dato;
using ApiServicio.Modelos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiServicio.Modelos.Repositorio
{
    public class CompraRepository :ICompraRepository
    {
        protected readonly EmpresaVelmotorContext _context;
        public CompraRepository(EmpresaVelmotorContext context) => _context = context;

        public IEnumerable<Compra> GetCompras()
        {
            return _context.Compras.ToList();
        }

        public Compra GetCompraById(decimal idCompra)
        {
            return _context.Compras.Find(idCompra);

        }
        public async Task<Compra> CreateCompraAsync(Compra compra)
        {
            await _context.Set<Compra>().AddAsync(compra);
            await _context.SaveChangesAsync();
            return compra;
        }

        public async Task<bool> UpdateCompraAsync(Compra compra)
        {
            _context.Entry(compra).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCompraAsync(Compra compra)
        {

            if (compra is null)
            {
                return false;
            }
            _context.Set<Compra>().Remove(compra);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
