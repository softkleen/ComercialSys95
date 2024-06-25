using ComClassSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ComClassSys
{
    public class ItemPedido
    {


        // Propriedades
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        // contrutores
        public ItemPedido() {
            
        }

        public ItemPedido(int id, int pedidoId, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            PedidoId = pedidoId;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public ItemPedido(int pedidoId, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            PedidoId = pedidoId;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        // métodos Manter Itens de pedido 
        // Inserir Item
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sppedido_id",PedidoId);
            cmd.Parameters.AddWithValue("spproduto_id",Produto.Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        // Consultar Item de pedido (Obter por id ped e id prod) 
        public static ItemPedido ObterItem(int idPedido, int idProduto=0)
        {
            ItemPedido itemPedido = new();

            return itemPedido;

        }
        public static List<ItemPedido> ObterListaPorPedido(int idPedido)
        {
            List<ItemPedido> itens = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from itempedido where pedido_id = {idPedido}";
            var dr = cmd.ExecuteReader();
            while(dr.Read()) 
            {
                itens.Add(new(dr.GetInt32(0)
                    , dr.GetInt32(1)
                    , Produto.BuscarPorId(dr.GetInt32(2))
                    , dr.GetDouble(3)
                    , dr.GetDouble(4)
                    , dr.GetDouble(5)));
            }
            return itens;

        }
        // Alterar Item
        public bool Alterar(int id)
        {

            return true;
        }
        // Excluir
        public static void Remover(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.ExecuteNonQuery();
        }
    }
}
