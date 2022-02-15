using System;
class MainClass 
{
    public static void Main() 
    {
        DateTime valor1 = new DateTime(2022, 01, 12);
        DateTime valor2 = new DateTime(2022, 02, 12);
        DateTime valor3 = new DateTime(2022, 01, 30);

        Boleto x = new Boleto("0101",valor1, valor2, valor3, 140.20M);

        x.Pagar(100.20M);

        Pagamento y = x.Situacao();

        Console.WriteLine(y);
        Console.WriteLine(x);
    }
}
enum Pagamento{
    EmAberto, PagoParcial, Pago
}
class Boleto 
{
    string codBarras;
    DateTime dateEmissao;
    DateTime dataVencimento;
    DateTime dataPagto;
    decimal valorBoleto;
    decimal valorPago;
    Pagamento situacaoPagamento;

    public Boleto(string cod, DateTime dateEmissao, DateTime dataVencimento, DateTime dataPagto, decimal valorBoleto)
    {
        this.codBarras = cod;
        this.dateEmissao = dateEmissao;
        this.dataVencimento = dataVencimento;
        this.dataPagto = dataPagto;
        this.valorBoleto = valorBoleto;
    }

    public void Pagar(decimal valorPago)
    {
        if (valorPago <= this.valorBoleto)
        {
            this.valorPago = valorPago;
        }
        else
        {
            Console.WriteLine("Valor Invalido");
        }    
    }
    public Pagamento Situacao()
    {
        if(valorPago == 0)
        {
            this.situacaoPagamento = Pagamento.EmAberto;
            return Pagamento.EmAberto;
        }
        else
        {
            if (valorPago < valorBoleto)
            {
                this.situacaoPagamento = Pagamento.PagoParcial;
                return Pagamento.PagoParcial;
            }
            else
            {
                this.situacaoPagamento = Pagamento.Pago;
                return Pagamento.Pago;
            }
        }
    }
    public override string ToString()
    {
        return $"{codBarras} {dateEmissao} {dataVencimento} {dataPagto} {valorBoleto} {valorPago} {situacaoPagamento}";
    }
}