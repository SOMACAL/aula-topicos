var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//Lista
List<Produto> produtos = new List<Produto>();
produtos.Nome = "Bolacha";
produtos.add(new Produto ("Celular", "IOS"));
produtos.add(new Produto ("Celular", "ANDROID"));
produtos.add(new Produto ("Televisão", "LG"));
produtos.add(new Produto ("Placa de video", "NVIDIA"));


//GET http://localhost:5024
app.MapGet("/", () => "API de produtos!");
// funcionalidades da aplicação = Endpoints
app.MapGet("/produto/listar", () => 
"Listagem de produtos!");

//EXERCICIO--Cadastrar produtos dentro da lista
//Não da para enviar por que o navegador não permite
 app.MapPost("/produto/cadastrar", () => 
 "Cadastro de produtos!");
app.Run();

record Produto(string nome, string descricao);