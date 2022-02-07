using projeto_eco.DAO;
using projeto_eco.Models;

namespace projeto_eco_new.DAO
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext; // Injeção de Dependencias
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Usuarios.Add(contato);
            _bancoContext.SaveChanges();

            return contato;
            
            //POST no Banco de DADOS
        }
    }
}
