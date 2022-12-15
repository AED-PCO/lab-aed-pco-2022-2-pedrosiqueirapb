public class Objeto{
    public int num {get; set;}
    public Objeto(){}
}

public class Caixa{
    public Objeto obj;
    public Caixa prox;
    public Caixa ant;

    public Caixa(){
        this.obj = new Objeto();
        this.prox = null;
        this.ant = null;
    }
}

public class ListaCircular{
    public Caixa primeiro;
    public Caixa atual;

    public ListaCircular(){
        primeiro = new Caixa();
        primeiro.prox = primeiro;
        primeiro.ant = primeiro;
        atual = primeiro;
    }

    public bool ListaVazia(){
        return primeiro.prox == primeiro ? true : false;
    }

    public void Insere(int num, int pos = -1){
        int cont = 1;
        Caixa novo = new Caixa();
        novo.obj.num = num;

        if(ListaVazia()){
            primeiro.prox = novo;
            atual = novo;
            novo.prox = novo;
            novo.ant = novo;
        }
        else{
            if(pos == -1){
                Caixa aux = primeiro.prox;
                while(aux.prox != primeiro.prox){
                    aux = aux.prox;
                }
                atual = novo;
                atual.prox = primeiro.prox;
                novo.ant = aux;
                novo.prox = primeiro.prox;
                aux.prox = novo;
                primeiro.prox.ant = atual;
            }
            else{
                Caixa aux = primeiro.prox;
                while(cont < pos && aux != atual){
                    cont++;
                    aux = aux.prox;
                }
                    
                if(aux == atual && cont < pos){ 
                    atual = novo;
                    atual.prox = primeiro.prox;
                    novo.ant = aux;
                    novo.prox = primeiro.prox;
                    aux.prox = novo;
                    primeiro.prox.ant = atual;
                }
                else{
                    atual.prox = primeiro.prox;
                    novo.prox = aux;
                    aux.ant.prox = novo;
                    aux.ant = novo;
                    novo.ant = aux.ant;

                    if(primeiro.prox == aux){
                    primeiro.prox = novo;
                    primeiro.prox.ant = atual;
                    }
                }         
            }
        }
    }
    public void Remove(){
        if(ListaVazia())
            Console.WriteLine("\nA lista está vazia!");
        else{
            Caixa aux = primeiro.prox;
            Caixa auxRet;
            bool achou = false;
                
            Console.WriteLine("\nO elemento {0} foi retirado da lista!", atual.obj.num);
            atual.ant.prox = primeiro.prox;
            atual = atual.ant;
            primeiro.prox.ant = atual;   
        }
    }
    public void Imprime(){
        Caixa data = primeiro.prox;
        while(data != atual){
            Console.Write(data.obj.num + " ");
            data = data.prox;
        }
        Console.Write(atual.obj.num + " ");
    }
}