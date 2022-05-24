using System.Threading.Tasks;
using BibliotecaClient;
using Grpc.Net.Client;

using var channel = GrpcChannel.ForAddress("https://localhost:7242");

var client = new BibliotecaServiceGrpc.BibliotecaServiceGrpcClient(channel);

//exemplos de requests
//SelectAll  - await client.SelectAllAsync(new Empty());
//SelectById - await client.SelectByIDAsync(new LivroFilter() { LivroID = 1 });
//Insert     - await client.InsertAsync(new Livro() { LivroID = 3, Name = "As viagens de gulliver", Tipo= "Ficção"});
//Update     - await client.UpdateAsync(new Livro() { LivroID = 1, Name = "Diario De um Banana", Tipo = "Comédia" });
//Delete     - await client.DeleteAsync(new LivroFilter() { LivroID = 3});

var reply = await client.SelectAllAsync(new Empty());



Console.WriteLine(reply.ToString());
//Console.WriteLine((await client.SelectAllAsync(new Empty())).ToString());
Console.ReadLine();