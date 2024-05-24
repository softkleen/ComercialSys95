using Org.BouncyCastle.Crypto.Operators;
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
        public Nivel? Nivel { get; set; }
        public bool Ativo { get; set; }

        // métodos construtores
        public Usuario() 
        {
            Id = 0;
        
        }
        public Usuario(string nome, string email, string senha, Nivel nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }
        public Usuario(int id, string nome, string email, string? senha, Nivel nivel, bool ativo)
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
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            cmd.ExecuteNonQuery();// executar do Mysql (sinal do raiozinho)


        }
        public bool Editar(int id) 
        {
            bool resultado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera"; // nome da procedure de alteração de usuario
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id );
            try
            {
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }

            return resultado;
        }
        public static Usuario ObterPorId(int id) 
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id ={id}";
            var dr = cmd.ExecuteReader() ;// dr =  DataReader = retorno da consulta (caso haja)
            while (dr.Read())
            {
                // 1ª forma
                usuario = new(dr.GetInt32(0)
                    ,dr.GetString(1)
                    ,dr.GetString(2)
                    ,dr.GetString(3)
                    ,Nivel.ObterPorId(dr.GetInt32(4))
                    ,dr.GetBoolean(5)
                    );
                // 2ª forma
                //usuario.Id = dr.GetInt32(0);
                //usuario.Nome = dr.GetString(1);
                //usuario.Email = dr.GetString(2);
                //usuario.Senha = dr.GetString(3);
                //usuario.Nivel = dr.GetString(4);
                //usuario.Ativo = dr.GetBoolean(5);
            }
            return usuario;
        }
        public static List<Usuario> ObterLista(string nome=null) 
        {
            List<Usuario> lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == null)
            {
                cmd.CommandText = "select * from usuarios";
            }
            else 
            {
                cmd.CommandText = $"select * from usuarios where nome like '%{nome}%'";
            }
            
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                                      dr.GetInt32(0),
                                      dr.GetString(1),
                                      dr.GetString(2),
                                      dr.GetString(3),
                                      Nivel.ObterPorId(dr.GetInt32(4)),
                                      dr.GetBoolean(5) 
                                     ));
            }
            return lista;
        }
        public static Usuario EfetuarLogin(string email, string senha) 
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios " +
                $"where email = '{email}' and senha = md5('{senha}') and ativo = 1";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario.Id = dr.GetInt32(0);
                usuario.Nome = dr.GetString(1);
                usuario.Email = dr.GetString(2);
                usuario.Nivel = Nivel.ObterPorId(Convert.ToInt32(dr.GetInt32(4))); 
            }
            return usuario;
        }
       
    }
}
