using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interface;

namespace api_filmes_senai.Repositories
{
    /// <summary>
    /// Classe que vai implementar a interface IGeneroRepository
    /// Ou seja. vamos umplementar os métodos, toda a lógica dos métodos
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {

        /// <summary>
        /// Variável privada e somente leitura 
        /// que "guarda" os dados no contexto
        /// </summary>
        private readonly Filmes_Context _context;

        /// <summary>
        /// Construtor do repositorio
        /// Aqui, todas vez que o construtor for chamado,
        /// os dados do contexro estarão disponíveis
        /// </summary>
        /// <param name="contexto">Dados do contexto</param>
        public GeneroRepository(Filmes_Context contexto)
        {
            _context = contexto;
        }

        public void Atualizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Método para cadastrar um novo gênero
        /// </summary>
        /// <param name="novoGenero">objeto gênero a ser cadastrado</param>
        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                //Adiciona um novo gênero a tablea Generos(BD = banco de dados)
                _context.Genero.Add(novoGenero);

                //Após o cadastro, salva as alterações (BD)
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {
            try
            {
                List<Genero> listaGeneros = _context.Genero.ToList();

                return listaGeneros;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
