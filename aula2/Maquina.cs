public class Maquina {

    public string Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public List<Produto> Produtos = new List<Produto>();

    public string exibirInformacoesMaquina(){
        string infoMaquina = $"Id: {Id}, Marca: {Marca}, Modelo: {Modelo}";
        return infoMaquina;
    }
    
    public void IniciarProducao(Produto produto){
        this.Produtos.Add(produto);
    }

    public List<Produto> GetProdutos(){
        return this.Produtos;
    }
}