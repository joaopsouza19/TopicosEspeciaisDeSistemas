public class Produto {
    
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public decimal Preco { get; set; }

    public string exibirInformacoesProdutos(){
        string infoProdutos = $"Nome: {Nome}, Código: {Codigo}, Preço: {Preco}";
        return infoProdutos;
    }

    public void AtualizarPreco(decimal novoPreco){
        Preco = novoPreco;
    }
}