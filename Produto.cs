using System;
using System.Globalization;

namespace Sistema_Gestao
{
  public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public int Quantidade { get; set; }
    public decimal Preco { get; set; }
    public string Fornecedor { get; set; }
}
}