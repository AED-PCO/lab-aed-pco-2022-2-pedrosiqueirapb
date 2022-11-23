public class Caixa{
	public int elem;
	public Caixa apont;

    public Caixa(){
        elem = 0;
        apont = null;
    }

	public Caixa(int elem){
      this.elem = elem;
      this.apont = null;
	}
}

public class Lista{
	public Caixa prm, ult;

    public Lista(){
        prm = new Caixa();
        ult = prm;
    }

    public int Tamanho(){
        int tam = 0;

        Caixa i = prm;
        while(i != null){
            tam++;
            i = i.apont;
        }
        return tam;
    }

    // Métodos para remover um valor

    public int BuscaValor(int num){
        int count=0;
        Caixa i=prm.apont;
        while(i != null){
            if(num == i.elem)
                return count;
            count++;
            i=i.apont;
        }
        return -1;
    }

    public int Remover(int num){
        int val = BuscaValor(num);
        if(val==-1){
            Console.WriteLine("\nO elemento não existe na lista.");
            return 0;
        }
        else{
            Caixa aux = prm;
            for(int i=0; i<val; i++)
                aux = aux.apont;
            Caixa aux_2 = aux.apont; 
            int el = aux_2.elem;
            aux.apont = aux_2.apont;
            aux_2.apont = null;
            aux = null;
            aux_2 = null;
            return el;
        }  
    }

    // Métodos para inserir um valor

    public void InserirPos(int num, int pos){
        pos--;
        int len = Tamanho();
        if(pos<0 || pos>len)
            Console.WriteLine("\nNão é possível inserir nessa posição!");
        else{
            Caixa aux = prm;
            for(int i=0; i<pos; i++)
                aux = aux.apont;
            Caixa aux_2 = new Caixa(num);
            aux_2.apont = aux.apont;
            aux.apont = aux_2;
            aux = null;
            aux_2 = null;
        }
    }

    public void AdicionaValor(int num){
        ult.apont = new Caixa(num);
        ult = ult.apont;
    }

    public bool ListaVazia(){
        if(prm == ult)
            return true;
        else
            return false;
    }

    public void Imprimir(){
        Caixa count = prm.apont;
        while(count != null){
            Console.Write(count.elem + " ");
            count=count.apont;
        }
    }
}