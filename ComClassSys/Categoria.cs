using System.Data;
namespace ComClassSys
{
    public class Categoria
    {
        // propriedades da classe
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }


        // métodos construtores
        public Categoria()
        {
            Id = 0;

        }
        public Categoria(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;

        }
        public Categoria(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;

        }

        // métodos da classes - Funcionalidades de usuário: RF04-Inserir Usuário
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spSigla", Sigla);
            cmd.ExecuteNonQuery();// executar do Mysql (sinal do raiozinho)


        }
        public bool Editar(int id)
        {
            bool resultado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update"; // nome da procedure de alteração de Categoria
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);

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
        public static Categoria ObterPorId(int id)
        {
            Categoria Categoria = new Categoria();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from categorias where id ={id}";
            var dr = cmd.ExecuteReader();// dr =  DataReader = retorno da consulta (caso haja)
            while (dr.Read())
            {
                // 1ª forma
                Categoria = new(dr.GetInt32(0)
                    , dr.GetString(1)
                    , dr.GetString(2)
                    );
            }
            return Categoria;
        }
        public static List<Categoria> ObterLista()
        {
            List<Categoria> lista = new List<Categoria>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from categorias";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Categoria(
                                      dr.GetInt32(0),
                                      dr.GetString(1),
                                      dr.GetString(2)
                                    
                                     ));
            }
            return lista;
        }
    }
}
