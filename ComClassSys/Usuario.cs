namespace ComClassSys
{
    public class Usuario
    {
        // propriedades da classe
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Nivel { get; set; }
        public bool Ativo { get; set; }

        // métodos construtores
        public Usuario() 
        { 
        
        }
        public Usuario(string nome, string email, string senha, string nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }
        public Usuario(int id, string nome, string email, string senha, string nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        // métodos da classes - Funcionalidades de usuário: RF04-Inserir Usuário
        public void Inserir() 
        {
            
        }
        public bool Editar(int id) 
        {
            return true;
        }
        public static Usuario ObterPorId(int id) 
        {
            // 
            Usuario usuario = new Usuario();
            return usuario;
        }
        public static List<Usuario> ObterLista() 
        {

            List<Usuario> lista = new List<Usuario>();
            return lista;
        }
    }
}
