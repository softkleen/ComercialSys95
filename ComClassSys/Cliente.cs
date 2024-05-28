using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI;

namespace ComClassSys
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc  { get; set; }
        public DateTime DataCad { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public Cliente()
        {
            Id = 0;
        }
        public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime dataNasc, DateTime dataCad, bool ativo, List<Endereco> enderecos)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = dataNasc;
            DataCad = dataCad;
            Ativo = ativo;
            Enderecos = enderecos;
        }
        public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime dataNasc, DateTime dataCad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = dataNasc;
            DataCad = dataCad;
            Ativo = ativo;

        }
        public Cliente( string nome, string cpf, string telefone, string email, DateTime dataNasc)
        { 
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = dataNasc;
        }
        public Cliente(string nome, string cpf, string telefone, string email, DateTime dataNasc, bool ativo, List<Endereco> enderecos)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = dataNasc;
            Ativo = ativo;
            Enderecos = enderecos;
        }
        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome",Nome);
            cmd.Parameters.AddWithValue("spcpf",Cpf);
            cmd.Parameters.AddWithValue("sptelefone",Telefone);
            cmd.Parameters.AddWithValue("spemail",Email);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static Cliente ObterPorId(int id) 
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                cliente = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7),
                    Endereco.ObterListaPorCliente(dr.GetInt32(0))
                    ) ;
            }

            return cliente;
        }
        public static List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(
                    new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7),
                    Endereco.ObterListaPorCliente(dr.GetInt32(0))
                    )
                );
            }
            return clientes;
        }
        public bool Editar(int id) 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            // if (se) ternário
            //     [      condição      ] [?] então [:] senão
            return cmd.ExecuteNonQuery()>-1?true:false;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, DataCad);
        }
    }
}
