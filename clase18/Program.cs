public interface IBebida
{
    decimal Volumen {get; set;}
    bool Gasificada {get; set;}
    string Color {get; set;}
    decimal Calorias {get; set;}
    bool Alcoholica {get; set;}
}

public interface IBebidasAlcoholicas
{
    decimal Graduacion {get; set;}
}

public interface ICerveza : IBebidasAlcoholicas, IBebida
{
    int IBU {get; set;} //IBU es el índice de amargura de la cerveza
}

public class Gaseosa : IBebida
{
    public decimal Volumen {get; set;}
    public bool Gasificada {get; set;}
    public string Color {get; set;}
    public decimal Calorias {get; set;}
    public bool Alcoholica {get; set;}

}

public class Cerveza : ICerveza
{
    public decimal Volumen {get; set;}
    public bool Gasificada {get; set;}
    public string Color {get; set;}
    public decimal Calorias {get; set;}
    public bool Alcoholica {get; set;}
    public int IBU {get; set;}   
    public decimal Graduacion {get; set;}
}