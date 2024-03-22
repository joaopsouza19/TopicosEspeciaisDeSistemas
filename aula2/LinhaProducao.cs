public class LinhaProducao {
    
    public string Numero { get; set; }
    public string Tipo { get; set; }
    public string Capacidade { get; set; }
    public List<Maquina> Maquinas = new List<Maquina>();

    public string exibirInformacoesLinha(){
        string infoLinhaProducao = $"\nNúmero: {Numero}, Tipo: {Tipo}, Capacidade: {Capacidade}";
        return infoLinhaProducao;
    }

    public void AdicionarMaquina(Maquina maquina){
        this.Maquinas.Add(maquina);
    }

     public List<Maquina> GetMaquinas(){
        return this.Maquinas;
    }
}