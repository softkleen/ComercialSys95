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
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        // contrutores
        public ItemPedido() {
            Pedido = new();
        }

        public ItemPedido(int id, Pedido pedido, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            Pedido = pedido;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public ItemPedido(Pedido pedido, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Pedido = pedido;
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
            cmd.Parameters.AddWithValue("sppedido_id",Pedido.Id);
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

            return itens;

        }
        // Alterar Item
        public bool Alterar(int id)
        {

            return true;
        }
        // Excluir
        public void Remover(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.ExecuteNonQuery();
        }
    }
}
