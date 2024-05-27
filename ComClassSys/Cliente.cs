using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.Types;

namespace ComClassSys
{
    public class Cliente
    {
        // Propriedaes da Classe 
        public int Id { get; set; } 
        public string? Nome { get; set; }    
        public string? Cpf { get; set; } 
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Data_nasc {  get; set; }
        public string? Data_cad {  get; set; }
        public string? Ativo {  get; set; }

        public Cliente() {
            Id = 0;
        }

        public Cliente( string nome, string cpf, string telefone, string email, string data_nasc)
        {         
            Nome = nome;    
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
        
                   
        }
        public Cliente(int id,string nome, string cpf, string telefone, string email, string data_nasc, string data_cad, string ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_inserir_cliente";
            cmd.Parameters.AddWithValue("spnome",Nome);
            cmd.Parameters.AddWithValue("spcpf",Cpf);
            cmd.Parameters.AddWithValue("sptelefone",Telefone);
            cmd.Parameters.AddWithValue("spemail",Email);
            cmd.Parameters.AddWithValue("spdata_nasc",Data_nasc);
            cmd.ExecuteNonQuery();


        }
        public bool Editar(int id)
        {
            bool resultado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_nasc);
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
        public static List<Cliente> ObterLista(string nome = null)
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes";
           
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7)
                    ));
            }
            return lista;
        }


          
    }
}
