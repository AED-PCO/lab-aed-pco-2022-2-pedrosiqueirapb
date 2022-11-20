void Inserir(Pilha pilha){
    Console.WriteLine("\nDeseja inserir algum valor?");
    Console.WriteLine("s) Sim\t n) Não");
    char res = char.Parse(Console.ReadLine());
    switch(res){
        case 's':
        Console.Write("O número: ");
        int n = int.Parse(Console.ReadLine());
        pilha.Inserir(n);
        InserirMais(pilha);
        break;
        case 'n':
        Console.WriteLine("\nFim do programa!");
        break;
        default:
        do{
            Console.WriteLine("\nEscolha uma opção válida!");
            InserirMais(pilha);
        } while(res != 's' && res != 'n');
        break;
    }
}

void Remover(Pilha pilha){
    Console.WriteLine("\nDeseja remover algum valor?");
    Console.WriteLine("s) Sim\t n) Não");
    char res = char.Parse(Console.ReadLine());
    switch(res){
        case 's':
        int ret = pilha.Remover();
        if(ret != 0 && ret != 1){
            Console.WriteLine("Número removido: {0}", ret);
            RemoverMais(pilha);
        }
        else if(ret == 1){
            Console.WriteLine("Número removido: {0}", ret);
            Console.WriteLine("\nFim do programa!");
        }
        else
            Console.WriteLine("A pilha já está vazia.");
        break;
        case 'n':
        Console.WriteLine("\nFim do programa!");
        break;
        default:
        do{
            Console.WriteLine("\nEscolha uma opção válida!");
            RemoverMais(pilha);
        } while(res != 's' && res != 'n');
        break;
    }
}

void InserirMais(Pilha pilha){
    Console.WriteLine("\nDeseja inserir mais valores?");
    Console.WriteLine("s) Sim\tn) Não");
    char res = char.Parse(Console.ReadLine());
    switch(res){
        case 's': 
        Console.Write("O número: ");
        int n = int.Parse(Console.ReadLine());
        pilha.Inserir(n);
        InserirMais(pilha);
        break;
        case 'n':
        Remover(pilha);
        break;
        default:
        do{
            Console.WriteLine("\nEscolha uma opção válida!");
            InserirMais(pilha);
        } while(res != 's' && res != 'n');
        break;
    }
}

void RemoverMais(Pilha pilha){
    Console.WriteLine("\nDeseja remover mais valores?");
    Console.WriteLine("s) Sim\tn) Não");
    char res = char.Parse(Console.ReadLine());
    switch(res){
        case 's':
        int ret = pilha.Remover();
        if(ret != 0 && ret != 1){
            Console.WriteLine("Número removido: {0}", ret);
            RemoverMais(pilha);
        }
        else if(ret == 1){
            Console.WriteLine("Número removido: {0}", ret);
            Console.WriteLine("\nFim do programa!");
        }
        else
            Console.WriteLine("A pilha já está vazia.");
        break;
        case 'n':
        Inserir(pilha);
        break;
        default:
        do{
            Console.WriteLine("\nEscolha uma opção válida!");
            RemoverMais(pilha);
        } while(res != 's' && res != 'n');
        break;
    }
}

Pilha pl = new Pilha();

Console.WriteLine("Você deseja inserir ou remover da pilha?");
Console.WriteLine("a) Inserir\tb) Remover");
char res = char.Parse(Console.ReadLine());

switch(res){
    case 'a':
    Console.Write("O número: ");
    int n = int.Parse(Console.ReadLine());
    pl.Inserir(n);
    InserirMais(pl);
    break;
    case 'b':
    Console.WriteLine("A pilha já está vazia.");
    break;
    default:
    Console.WriteLine("\nEscolha uma opção válida!");
    break;
}

Console.WriteLine("\n----- Pilha -----");
Console.Write("null <- ");
pl.chamaFuncao();
Console.Write("Topo");