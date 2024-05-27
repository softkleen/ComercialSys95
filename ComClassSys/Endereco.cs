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
    

        public int Id { get; set; }
        public int CLienteId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string TipoEndereco { get; set; }
        public Endereco()
        {
        }

        public Endereco(int id, int cLienteId, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipoEndereco)
        {
            Id = id;
            CLienteId = cLienteId;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }
        public Endereco( int cLienteId, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipoEndereco)
        {
            CLienteId = cLienteId;
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
        
        }
        public bool Editar() { return true; }
        public static Endereco ObterPorId() 
        {
            Endereco endereco = new();

            return endereco;
        }
        public static List<Endereco> ObterListaPorCliente(int clienteId)
        {
            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from enderecos where cliente_id = {clienteId}";

            return enderecos;
        }
    }
}
