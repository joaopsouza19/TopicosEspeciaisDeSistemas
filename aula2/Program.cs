// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Industria Joao = new Industria();
Joao.Nome = "Loyal Armory";
Joao.Localizacao = "Curitiba";
Joao.AnoFundacao = 2024;

//===================================================================
//Criação de uma linha de producao e adicionando na industria 
LinhaProducao Linha1 = new LinhaProducao();
Linha1.Numero = "1";
Linha1.Tipo = "Camiseta Manga Curta";
Linha1.Capacidade = "10";
//Adicionar a 1 linha de producao na industria
Joao.adicionarLinhaProducao(Linha1);

LinhaProducao Linha2 = new LinhaProducao();
Linha2.Numero = "2";
Linha2.Tipo = "Camiseta Manga Longa";
Linha2.Capacidade = "30";
//Adicionar a 2 linha de producao na industria
Joao.adicionarLinhaProducao(Linha2);

//===================================================================
//Crir as máquinas
Maquina maquina1 = new Maquina();
maquina1.Id = "1";
maquina1.Marca = "Pelegrin";
maquina1.Modelo = "Maquina de estampa";
//Adicionar a primeira máquina na linha de producao

Linha1.AdicionarMaquina(maquina1);

Maquina maquina2 = new Maquina();
maquina2.Id = "2";
maquina2.Marca = "Singer";
maquina2.Modelo = "Maquina de costura";
//Adicionar a segunda máquina na linha de producao
Linha1.AdicionarMaquina(maquina2);

Maquina maquina3 = new Maquina();
maquina3.Id = "3";
maquina3.Marca = "Zig Zag Westman";
maquina3.Modelo = "Maquina de costura reta";
//Adicionar a terceira máquina na linha de producao
Linha2.AdicionarMaquina(maquina3);

Maquina maquina4 = new Maquina();
maquina4.Id = "4";
maquina4.Marca = "Philco";
maquina4.Modelo = "Maquina de Estampa";
//Adicionar a quarta máquina na linha de producao
Linha2.AdicionarMaquina(maquina4);

//===================================================================
//Criação dos produtos
Produto produto1 = new Produto();
produto1.Nome = "Camiseta Tommy Hilfiger";
produto1.Codigo = "5";
produto1.Preco = 250;
//Adicionar o primeiro produto na maquina 1
maquina1.IniciarProducao(produto1);

Produto produto2 = new Produto();
produto2.Nome = "Camiseta Lacoste";
produto2.Codigo = "10";
produto2.Preco = 150;
//Adicionar o segundo produto na maquina 2
maquina2.IniciarProducao(produto2);

Produto produto3 = new Produto();
produto3.Nome = "Camiseta Sufgang";
produto3.Codigo = "15";
produto3.Preco = 275;
//Adicionar o terceiro produto na maquina 3
maquina3.IniciarProducao(produto3);

Produto produto4 = new Produto();
produto4.Nome = "Camiseta Adidas";
produto4.Codigo = "20";
produto4.Preco = 100;
//Adicionar o quarto produto na maquina 4
maquina4.IniciarProducao(produto4);

//===================================================================
//Exibir as informações da industria
Console.WriteLine(Joao.ExibirInformacoesIndustria());