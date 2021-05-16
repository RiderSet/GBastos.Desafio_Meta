using System.Linq;

namespace GBastos.Desafio_Meta.ApplicationCore.Interfaces.Genericos
{
    public interface IGenerica<T> where T : class
    {
        void Adicionar(T item);
        void Remover(T item);
        void Editar(T item);

        T ObtemPorId(object id);
        IQueryable<T> ObterTodos();
    }
}
