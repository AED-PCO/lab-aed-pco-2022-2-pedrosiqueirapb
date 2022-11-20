public class Caixa{
    public int elem; // número que está contido no objeto
    public Caixa apont; // referência para o próximo objeto
    
    // construtor que inicia o objeto com estes atributos
    public Caixa(int elem){
        this.elem = elem;
        this.apont = null;
    }
}

public class Pilha{
    public Caixa topo; // atributo que aponta para o topo da pilha
    public Pilha(){
        topo = null; // inicialmente a pilha não tem objetos, logo ele aponta para nulo
    }
    public void Inserir(int num){
        Caixa obj = new Caixa(num); // cria um novo objeto
        obj.apont = topo;
        topo = obj; // topo aponta para objeto, uma vez que, ele é inserido no topo da pilha
        obj = null; // ao ser inserido, não há mais objetos após ele. Logo, aponta para nulo
    }

    public int Remover(){
        if(topo == null){
            return 0; // se o topo apontar para nulo não há objetos. Logo, retorna 0
        }

        int n = topo.elem; // variável que guarda o elemento contido no objeto que está no topo
        Caixa aux = topo; // a variável auxiliar recebe o objeto que está no topo
        topo = topo.apont; // o topo agora aponta para o objeto posterior ao que será excluído 
        aux.apont = null; // o objeto a ser excluído aponta para nulo
        aux = null; // o objeto é apagado
        return n; // o elemento removido é retornado
    }
    public void chamaFuncao(){ // a função chama Imprimir passando o topo como parâmetro
        Imprimir(topo);
    }
    public void Imprimir(Caixa cx){
        if(cx != null){ // condição que verifica se o topo não aponta para nulo
            Imprimir(cx.apont); // chamada recursiva passando como parâmetro o apontador enquanto ele for diferente de nulo
            Console.Write(cx.elem + " <- "); // impressão do elemento na tela
        }
    }
}