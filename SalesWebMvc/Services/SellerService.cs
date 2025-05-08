using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //Criação da depêndencia do SalesWebMvcContext
        //O readonly é uma boa prática para não poder alterar depois
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            //acessa o banco de dados na tabela Seller e traz todos as linhas em uma lista
            return _context.Seller.ToList();
        }
    }
}
