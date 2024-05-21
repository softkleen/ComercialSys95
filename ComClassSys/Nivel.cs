using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Nivel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        // construtores
        public Nivel() { }
        public Nivel(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Nivel(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        // métodos da classe
        public void Inserir() 
        { 
        
        }
        public static List<Nivel> ObterLista() 
        {
            List<Nivel> niveis = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                niveis.Add(new(dr.GetInt32(0),dr.GetString(1), dr.GetString(2)));
            }
            return niveis;
        }
        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from niveis where id  = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);
                nivel.Sigla = dr.GetString(2);
            }
            return nivel;
        }

    }
}
