public class Caixa{
    public int n;
    public Caixa ant, prox;

    // construtor que cria uma caixa vazia, que aponta para o primeiro objeto da lista
    public Caixa(){
        this.n = 0;
        this.prox = null;
        this.ant = null;
    }
    public Caixa(int n){
        this.n = n;
        this.prox = null;
        this.ant = null;
    }
}

public class ListaDupla{
    public Caixa primeiro, ultimo; // apontam para a primeira e última posições
    public ListaDupla(){
        primeiro = new Caixa(); // "primeiro" aponta para a caixa vazia antes do começo da lista
        ultimo = primeiro; // com a lista vazia "primeiro" e "último" apontam para esta caixa vazia;
    }
    
    // Métodos para inserir

    public void InsereInicio(int n){
        Caixa aux = new Caixa(n); // criação da nova caixa
        aux.ant = primeiro; // a referência de "aux" ao anterior aponta para a caixa antes do começo da lista (primeiro)
        aux.prox = primeiro.prox; // a referência de "aux" ao próximo aponta para a caixa da primeira posição da lista
        primeiro.prox = aux; // a referência à primeira caixa da lista agora aponta para a nova caixa;
        if(primeiro == ultimo) // se a lista estiver vazia
            ultimo = aux; // a referência para o último aponta para esta nova caixa
        else
            aux.prox.ant = aux; // a caixa seguinte a "aux" terá sua referência anterior apontando para "aux"
        aux = null;
    }

    public void InsereFim(int n){
        Caixa aux = new Caixa(n); // criação da nova caixa
        ultimo.prox = aux; // a referência ao próximo da última caixa agora apontará para "aux"
        aux.ant = ultimo; // a referência ao anterior de "aux" agora apontará para o último elemento
        ultimo = aux; // o apontador para o último da lista agora aponta para a nova caixa
    }

    public int Tamanho(){
        int tam = 0; // contador
        Caixa i = primeiro.prox; // "i" percorrerá a lista, começando da primeira caixa
        while(i != null){ // enquanto houver caixas
            tam++; // incrementa o tamanho
            i = i.prox; // "i" passa para a próxima caixa
        }
        return tam; // retorno do tamanho da lista
    }

    public void InserePos(int n, int pos){
        int tam = Tamanho(); // a variável "tam" recebe o retorno do método "Tamanho"
        if(pos < 0 || pos > tam) // se a posição digitada pelo usuário for menor que 0 ou maior que o tamanho, ela não existe
            Console.WriteLine("\nEssa posição não existe!");
        else if(pos == 0) // se a posição digitada for 0, chama o método que insere na primeira posição
            InsereInicio(n);
        else if(pos == tam) // se a posição digitada for o tamanho da lista, chama o método que insere na última posição
            InsereFim(n);
        else{
            Caixa i = primeiro;
            for(int j=0; j<pos; j++) // laço que percorre até a posição que se deseja inserir
                i = i.prox; // incremento de "i" para a próxima caixa
            
            Caixa aux = new Caixa(n); // criação da nova caixa
            aux.ant = i; // a referência ao anterior, aponta para a caixa que está na posição que se deseja inserir
            aux.prox = i.prox; // a referência ao próximo aponta para a caixa seguinte àquela que está na posição que se deseja inserir
            aux.ant.prox = aux; // a referência ao próximo da caixa anterior àquela que foi inserida, aponta para "aux"
            aux.prox.ant = aux; // a referência ao anterior da caixa posterior àquela que foi inserida, aponta para "aux" 
            aux = null;
            i = null;
        }
    }

    // Métodos para remover

    public int RemoveInicio(){
        if(primeiro == ultimo) // se a lista estiver vazia
            Console.WriteLine("\nA lista já está vazia.");
        Caixa aux = primeiro; // "aux" aponta para a primeira caixa, que define o começo da lista
        primeiro = primeiro.prox; // o apontador para a primeira caixa agora referencia a caixa que contém o primeiro elemento
        int num = primeiro.n; // "num" recebe o número contido na primeira caixa
        aux.prox = null; // a referência ao próximo da caixa que será removida aponta para nulo
        primeiro.ant = null; // a referência ao anterior da caixa que será removida aponta para nulo
        aux = null; // "aux" é destruída
        return num; // retorno do número removido
    }

    public int RemoveFim(){
        if(primeiro == ultimo) // se a lista estiver vazia
            Console.WriteLine("\nA lista já está vazia.");
        int num = ultimo.n; // "num" recebe o número contido na última caixa
        ultimo = ultimo.ant; // "ultimo" aponta para a caixa anterior à que será removida
        ultimo.prox.ant = null; // a referência à caixa anterior da caixa que será removida aponta para nulo
        ultimo.prox = null; // a caixa que agora está na última posição aponta para nulo
        return num; // retorno do número removido
    }

    public int RemovePos(int pos){
        int tam = Tamanho(), num=-1;
        if(primeiro == ultimo) // se a lista estiver vazia
            Console.WriteLine("\nA lista já está vazia.");
        else if(pos < 0 || pos >= tam) // se a posição não existir
            Console.WriteLine("\nPosição inválida!");
        else if(pos == 0) // se o usuário deseja remover o elemento da primeira posição
            num = RemoveInicio();
        else if(pos == tam-1) // se o usuário deseja remover o elemento da última posição
            num = RemoveFim();
        else{
            Caixa j = primeiro.prox; // "j" referencia o primeiro elemento
            for(int i=0; i<pos; i++, j=j.prox){ // laço para chegar até a caixa a ser removida
                j.ant.prox = j.prox; // a referência ao próximo da caixa anterior à que será removida... aponta para a próxima caixa da que será removida
                j.prox.ant = j.ant; // a referência ao anterior da caixa posterior à que será removida... aponta para a caixa anterior da que será removida
                num = j.n; // a variável "num" recebe o valor que será removido
                j.prox = null; // a referência ao próximo da caixa a ser removida aponta para nulo
                j.ant = null; // a referência ao anterior da caixa a ser removida aponta para nulo
                j = null;
                return num; // retorno do valor removido
            }
        }
        return num;
    }

    public void Imprimir(){
        Caixa count = primeiro.prox;
        while(count != null){
            Console.Write(count.n + " ");
            count=count.prox;
        }
    }
}