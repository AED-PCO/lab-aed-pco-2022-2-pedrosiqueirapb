public class Caixa{
    public int elem;
    public Caixa apont;
    
    public Caixa(int elem){
        this.elem = elem;
        this.apont = null;
    }
}

public class Pilha{
    public Caixa topo;
    public Pilha(){
        topo = null;
    }
    public void Inserir(int num){
        Caixa obj = new Caixa(num);
        obj.apont = topo;
        topo = obj;
        obj = null;
    }

    public int Remover(){
        if(topo == null)
            return 0;

        int n = topo.elem;
        Caixa aux = topo;
        topo = topo.apont;
        aux.apont = null;
        aux = null;
        return n;
    }
    public void chamaFuncao(){
        Imprimir(topo);
    }
    public void Imprimir(Caixa cx){
        if(cx != null){
            Imprimir(cx.apont);
            Console.Write(cx.elem + " <- ");
        }
    }
}