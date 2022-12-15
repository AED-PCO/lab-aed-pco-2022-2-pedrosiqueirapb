class No{
    public int num;
    public No esquerda;
    public No direita;
    public No(int num){
        this.Node(num, null, null);
    }
    void Node(int num, No esquerda, No direita)
    {
        this.num = num;
        this.esquerda = esquerda;
        this.direita = direita;
            
    }
}

class ArvoreBinaria{
    No raiz, valores;
    public ArvoreBinaria(){
        raiz = null;
    }
        
    public void Insere(int x){
        raiz = InsereVal(x, raiz);
    }
    No InsereVal(int x, No i) {
        if(i == null){
            i = new No(x);
        }
        if(x < i.num){
            i.esquerda = InsereVal(x, i.esquerda);
        }
        if(x > i.num){
            i.direita = InsereVal(x, i.direita);
        }
        return i;
    }

    public bool Busca(int x){
        return BuscaNumero(x, raiz);
    }
    public bool BuscaNumero(int x, No i){
        bool valor = true;
        if(i == null){
            valor = false;
        }
        else if(x == i.num){
            valor = true;
        }
        else if(x < i.num){
            valor = BuscaNumero(x, i.esquerda);
        }
        else{
            valor = BuscaNumero(x, i.direita);  
        }
        return valor;
    }

    public void Remove(int x){
        raiz = RemoveVal(x, raiz);
    }

    No RemoveVal(int x, No i){
        if(i == null){
            Console.WriteLine("O valor não existe na estrutura.");
        }
        else if (x < i.num){
            i.esquerda = RemoveVal(x, i.esquerda);
        }
        else if (x > i.num){
            i.direita = RemoveVal(x, i.direita);
        }
        else if(i.direita == null){
            i = i.esquerda;
        }
        else if(i.esquerda == null){
            i = i.direita;
        }
        else{
            i. esquerda = MaiorEsq(i, i.esquerda);
        }
        return i;
    }

    No MaiorEsq(No i, No j){
        if(j.direita == null){
            i.num = j.num;
            j = j.esquerda;
        }
        else{
            j.direita = MaiorEsq(i, j.direita);
        }
        return j;
    }

    public void emOrdem(){
        exibirOrdem(raiz);
    }
    public void exibirOrdem(No i){
        if(i != null){
            exibirOrdem(i.esquerda);
            Console.Write(" {0}",i.num);
            exibirOrdem(i.direita);
        }
    }

    public void preOrdem(){
        exibirPreOrdem(raiz);
    }

    public void exibirPreOrdem(No i){
        if(i != null){
            Console.Write(" {0}",i.num);
            exibirOrdem(i.esquerda);
            exibirOrdem(i.direita);
        }
    }

    public void posOrdem(){
        exibirPosOrdem(raiz);
    }

    public void exibirPosOrdem(No i){
        if(i != null){
            exibirOrdem(i.esquerda);
            exibirOrdem(i.direita);
            Console.Write(" {0}",i.num);
        }
    }
}