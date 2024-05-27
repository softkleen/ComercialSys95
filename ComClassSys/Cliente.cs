using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
        public static Cliente ObterPorId(int id) 
        {
            Cliente cliente = new();

            return cliente;
        }
        public static List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new();

            return clientes;
        }
        public bool Editar() { return true; }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
