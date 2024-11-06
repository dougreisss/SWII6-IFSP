using TP03_Douglas_Lucas.Models;
using TP03_Douglas_Lucas.Models.SqlContext;
using TP03_Douglas_Lucas.Repository.Interface;

namespace TP03_Douglas_Lucas.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly SqlContext _sqlContext;
        public ProdutoRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public List<Produto> GetAll()
        {
            return _sqlContext.Produtos.ToList();
        }
        

    }
}
