using System.Data;
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
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            // spnome varchar(60), spemail varchar(60), spsenha varchar(32), spnivel char(1)
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel);
            cmd.ExecuteNonQuery();// executar do Mysql (sinal do raiozinho)


        }
        public bool Editar(int id) 
        {
            return true;
        }
        public static Usuario ObterPorId(int id) 
        {
            Usuario usuario = new Usuario();
            return usuario;
        }
        public static List<Usuario> ObterLista() 
        {
            List<Usuario> lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios" ;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                                      dr.GetInt32(0),
                                      dr.GetString(1),
                                      dr.GetString(2),
                                      dr.GetString(3),
                                      dr.GetString(4),
                                      dr.GetBoolean(5) 
                                     ));
            }
            return lista;
        }
    }
}
