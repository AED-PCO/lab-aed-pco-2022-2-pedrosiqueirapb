public class Caixa{
    public int elem;
    public Caixa apont;
    
    public Caixa(){
        this.elem = 0;
        this.apont = null;
    }

    public Caixa(int elem){
        this.elem = elem;
        this.apont = null;
    }
}

public class Fila{
    public Caixa prm;
    public Caixa ult;

    public Fila(){
        prm = new Caixa();
        ult = prm;
    }
 
    public void Inserir(int num){
        ult.apont = new Caixa(num);
        ult = ult.apont; 
    }

    public int Remover(){
        if(prm == ult)
            return 0;
        
        Caixa aux = prm;
        prm = prm.apont;
        int val = prm.elem;
        aux.apont = null;
        aux = null;
        return val;
    }

    public void Imprimir(){
        Caixa i = prm.apont;
        while(i != null){
            Console.Write(i.elem + " ");
            i = i.apont;
        }
    }
}