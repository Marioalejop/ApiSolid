using ApiSolid.Interfaces;
using ApiSolid.Models;

namespace ApiSolid.Services
{
    public class ProductoService
    {
        private readonly IProductoRepository _repository;

        public ProductoService(IProductoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Producto> GetAll() =>
            _repository.GetAll();

        public Producto GetById(int id) =>
            _repository.GetById(id);

        public void Add(Producto producto) =>
            _repository.Add(producto);

        public void Update(Producto producto) =>
            _repository.Update(producto);

        public void Delete(int id) =>
            _repository.Delete(id);
    }
}