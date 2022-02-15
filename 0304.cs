
using System;

class main 
{
    public static void Main()
    {
        Data x = new Data(21, 01, 2004);
        Data y = new Data("22/02/2022");

        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}
class Data
{
    int dia;
    int mes;
    int ano;

    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }
    public Data(string data)
    {
        string[] valores = data.Split('/');
        this.dia = int.Parse(valores[0]);
        this.mes = int.Parse(valores[1]);
        this.ano = int.Parse(valores[2]);
    }
    public void SetData(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }
    public int GetDia(int dia)
    {
        return dia;
    }
    public int GetMes(int mes)
    {
        return mes;
    }
    public int GetAno(int ano)
    {
        return ano;
    }
    public override string ToString()
    {
        return $"Dia = {dia:00}\nMês = {mes:00}\nAno = {ano:0000}";
    }
    
}
