using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Endereco
    {
        // propriedade da classe

        public int ID { get; set; }
        public int ClienteId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }  
        public string Cidade { get; set; }  
        public string Uf {  get; set; }
        public string TipoEndereco {  get; set; }
        public Endereco() { }

        public  Endereco(int clienteId, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipoEndereco )
        {
            
            ClienteId = clienteId;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }


        public Endereco(int id, int clienteId, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipoEndereco)
        {
            ID = id;
            ClienteId = clienteId;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id",ClienteId);
            cmd.Parameters.AddWithValue("spcep",Cep);
            cmd.Parameters.AddWithValue("splogradouro",Logradouro);
            cmd.Parameters.AddWithValue("spnumero",Numero);
            cmd.Parameters.AddWithValue("spcomplemento",Complemento);
            cmd.Parameters.AddWithValue("spbairro",Bairro);
            cmd.Parameters.AddWithValue("spcidade",Cidade);
            cmd.Parameters.AddWithValue("spuf",Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco",TipoEndereco);
            cmd.ExecuteNonQuery();
        }
        public bool Editar(int id)
        {
            bool resultado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";
            cmd.Parameters.AddWithValue("spid",ID);
            cmd.Parameters.AddWithValue("spcliente_id", ClienteId);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco);
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


        public void Excluir() 
            {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_delete";
            cmd.Parameters.AddWithValue("spid", ID);
            cmd.ExecuteNonQuery();
        }

        public static List<Endereco> ObterLista(int clienteId)
        {
            List<Endereco> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from enderecos where cliente_id = {clienteId}";

           
            return lista;
        }
        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new();

            return endereco;   
            }
            
        }





    }
}
