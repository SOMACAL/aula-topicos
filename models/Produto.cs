namespace WEB.models;

public class Produto;
{
    //Construtor 
    public Produto(){}

    public Produto(string nome , int descricao, double valor){
        Nome = nome;
        Descricao = descricao;
        Valor = valor;

    }
    //Atributos ou propriedades = Caractereristicas de um objeto
    public string? Nome { get; set; }
    public string? Descricao { get; set; }

    public double Valor { get; set; }


//     private string nome;
//     private string descricao;

//     public void setNome(string nome)
//     {
//         if(DateTime.now.day =="Segunda")
//         this.Nome = nome;
//     }
    
//         public string getNome()
//     {
//         return this.nome;
//     }
 }



