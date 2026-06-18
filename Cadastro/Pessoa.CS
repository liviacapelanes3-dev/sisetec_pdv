//package no java e namespace no C#
namespace Cadastro;

public abstract class Pessoa
{
    public decimal CPF{get;set;}
    
    public string Nome{get;set;}

    public string Telefone{get;set;}

public class Cliente:Pessoa
     {
       private double LimiteCredito {get;set;}

       private string? Avaliacao {get;set;}
     }
     public Pessoa (decimal cpf,string nome,string Telefone)
     {   
        id=ID;
        cpf=CPF;
        nome=Nome;
        telefone=Telefone;
     }
}