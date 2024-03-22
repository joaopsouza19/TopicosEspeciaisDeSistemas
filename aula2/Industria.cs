public class Industria {

    public string Nome { get; set; } 
    public string Localizacao { get; set; }
    public int AnoFundacao { get; set; }

    public List<LinhaProducao> LinhasProducoes = new List<LinhaProducao>();  

    public string ExibirInformacoesIndustria(){
        string dados = $"Nome: {Nome}, Localização: {Localizacao}, Ano de Fundação: {AnoFundacao}\n";
        dados += "\nLinhas de Produção: \n";
    
        foreach (var linhaProducao in LinhasProducoes)
        {
        dados += linhaProducao.exibirInformacoesLinha() + "\n";
        foreach (var maquina in linhaProducao.GetMaquinas())
            {
                dados += maquina.exibirInformacoesMaquina() + "\n";
                foreach (var produto in maquina.GetProdutos())
                {
                    dados += produto.exibirInformacoesProdutos() + "\n";;
                }
            }    
        }
        return dados;
    }

    public void adicionarLinhaProducao(LinhaProducao linhaProducao){
        this.LinhasProducoes.Add(linhaProducao);
    }
    public List<LinhaProducao> GetLinhaProducoes(){
        return this.LinhasProducoes;
    }
}