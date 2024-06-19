using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Produto
    {
        public int Id { get; set; }
        public string CodBarras { get; set; }
        public string? Descricao { get; set; }
        public decimal ValorUnit { get; set; }
        public string UnidadeVenda { get; set; }
        public Categoria Categoria { get; set; }
        public decimal EstoqueMinimo { get; set; }
        public decimal ClasseDesconto { get; set; }
        public string? Imagem { get; set; }
        public DateTime DataCad { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string codBarras, string descricao, decimal valorUnit, string unidadeVenda, Categoria categoria, decimal estoqueMinimo, decimal classeDesconto, DateTime dataCad)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            DataCad = dataCad;
        }

        public Produto(int id, string codBarras, string descricao, decimal valorUnit, string unidadeVenda, Categoria categoria, decimal estoqueMinimo, decimal classeDesconto)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;


        }

        public Produto(string codBarras, string descricao, decimal valorUnit, string unidadeVenda, Categoria categoria, decimal estoqueMinimo, decimal classeDesconto, string imagem)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;

        }

        public Produto(string codBarras, string descricao, decimal valorUnit, string unidadeVenda, Categoria categoria, decimal estoqueMinimo, decimal classeDesconto)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            cmd.ExecuteNonQuery();
        }

        public static Produto BuscarPorId(int id)
        {
            Produto produto = new Produto();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM produtos WHERE id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDecimal(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDecimal(6),
                    dr.GetDecimal(7)
                    );
            }
            return produto;
        }

        public bool Editar(int id)
        {
            bool resultado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update"; // nome da procedure de alteração de Produto
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);

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

        public static List<Produto> ObterLista(string nome = null)
        {
            List<Produto> produto = new List<Produto>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == null)
            {
                cmd.CommandText = "select * from produtos";
            }
            else
            {
                cmd.CommandText = $"select * from produtos where Descricao like '%{nome}%' order by nome";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.Add(new Produto(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDecimal(3), dr.GetString(4),

                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDecimal(6), dr.GetDecimal(7), dr.GetDateTime(9)));
            }
            return produto;
        }
    }
}
