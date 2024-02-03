// 1 - Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha. [ok]
// 2 - Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings. [ok]
// 3 - Desenvolver um método da classe Conta que exibe suas informações. [ok]
// 4 - Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar [ok]


using Desafios;

//Conta conta01 = new Conta();

//Console.WriteLine("Digite o nome do titular da conta");
//string titular = Console.ReadLine();

//conta01.Titular = titular;

//Console.WriteLine("Digite o saldo da conta");
//int saldo = int.Parse(Console.ReadLine());

//conta01.Saldo = saldo;

//conta01.Extrato();


Carro carro01 = new Carro();

carro01.Modelo = "SUV";
carro01.Fabricante = "FORD";
carro01.Ano = 1930;

carro01.Acelerar();
carro01.Frear();
carro01.Buzinar();
Console.WriteLine(carro01.DescricaoDetalhada);



// 1 - Reescrever a classe Conta, criada no ultimo desafio, utilizando properties. [ok]
// 2 - Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro. [ok]
// 3 - Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023. [ok]
// 4 - Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. [ok]
//          >>>Além disso, garantir que o preço e o estoque do produto sejam valores positivos [ok]
//          >>>e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas. [ok]


Produto produto = new Produto();
Console.WriteLine("=========PRODUTO=========");
produto.Nome = "Mouse";
produto.Marca = "Logitech";
produto.Preco = 800;
produto.Estoque = 5;
Console.WriteLine(produto.DetalhesDoProduto);


Lambda lambdaExpSoma = new Lambda();

Console.WriteLine("=========LAMBDA=========");
lambdaExpSoma.Somar(10, 20);
Console.WriteLine(lambdaExpSoma.Somar2(10, 20));


// 1 - Modelar uma classe Conta, que tenha como atributos uma classe Titular,
//      além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
// 2 - Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
// 3 - Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
// 4 - Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.
// 5 - Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.


Titular titular1 = new Titular();
titular1.Nome = "J0ttinha";
titular1.Endereco = "Rua das Ruas";
titular1.Documento = 526462334;

Conta conta02 = new Conta();
conta02.Extrato();