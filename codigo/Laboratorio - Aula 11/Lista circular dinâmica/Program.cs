ListaCircular lista = new ListaCircular();

char r;
int num;

void mensagem(){
    Console.WriteLine("Você deseja inserir ou remover da lista?");
    Console.WriteLine("a) Inserir\tb) Remover");
    r = char.Parse(Console.ReadLine());

    switch(r){
        case 'a':
        Console.Write("O número: ");
        num = int.Parse(Console.ReadLine());
        lista.Insere(num);
        InserirMais();
        break;
        case 'b':
        Console.WriteLine("\nA lista já está vazia!");
        break;
        default:
        Console.WriteLine("\nEscolha uma opção válida!");
        mensagem();
        break;
    }
}

void InserirMais(){
    char r;
    int num, pos;

    Console.WriteLine("\nDeseja inserir mais valores?");
    Console.WriteLine("s) Sim\tn) Não");
    r = char.Parse(Console.ReadLine());
    switch(r){
        case 's':
        Console.Write("O número: ");
        num = int.Parse(Console.ReadLine());
        Console.Write("Na posição: ");
        pos = int.Parse(Console.ReadLine());
        lista.Insere(num, pos);
        InserirMais();
        break;
        case 'n':
        Remover();
        break;
        default:
        Console.WriteLine("\nEscolha uma opção válida!");
        InserirMais();
        break;
    } 
}

void Remover(){
    char r;
    int pos;

    Console.WriteLine("\nDeseja remover algum valor?");
    Console.WriteLine("s) Sim\tn) Não");
    r = char.Parse(Console.ReadLine());
    switch(r){
        case 's':
        Console.Write("Na posição: ");
        pos = int.Parse(Console.ReadLine());
        lista.Remove();
        Remover();
        break;
        case 'n':
        Console.WriteLine("\nFim do programa!");
        break;
        default:
        Console.WriteLine("\nEscolha uma opção válida");
        Remover();
        break;
    }
}

mensagem();

Console.WriteLine("\n----- Lista -----");
lista.Imprime();