Fila fl = new Fila();

void Inserir(Fila fila){
    Console.WriteLine("\nDeseja inserir algum valor?");
    Console.WriteLine("s) Sim\t n) Não");
    char res = char.Parse(Console.ReadLine());
    switch(res){
        case 's':
        Console.Write("O número: ");
        int n = int.Parse(Console.ReadLine());
        fila.Inserir(n);
        InserirMais(fila);
        break;
        case 'n':
        Console.WriteLine("\nFim do programa!");
        break;
        default:
        do{
            Console.WriteLine("\nEscolha uma opção válida!");
            InserirMais(fila);
        } while(res != 's' && res != 'n');
        break;
    }
}

void InserirMais(Fila fila){
    Console.WriteLine("\nDeseja inserir mais valores?");
    Console.WriteLine("s) Sim\tn) Não");
    char res = char.Parse(Console.ReadLine());
    switch(res){
        case 's': 
        Console.Write("O número: ");
        int n = int.Parse(Console.ReadLine());
        fila.Inserir(n);
        InserirMais(fila);
        break;
        case 'n':
        Remover(fila);
        break;
        default:
        do{
            Console.WriteLine("\nEscolha uma opção válida!");
            InserirMais(fila);
        } while(res != 's' && res != 'n');
        break;
    }
}

void Remover(Fila fila){
    Console.WriteLine("\nDeseja remover?");
    Console.WriteLine("s) Sim\t n) Não");
    char res = char.Parse(Console.ReadLine());
    switch(res){
        case 's':
        int ret = fila.Remover();
        Console.WriteLine("Valor removido: {0}", ret);
        if(fila.ult != fila.prm)
            Remover(fila);
        break;
        case 'n':
        Console.WriteLine("\nFim do programa!");
        break;
        default:
        do{
            Console.WriteLine("\nEscolha uma opção válida!");
            Console.WriteLine("\nDeseja remover?");
            Console.WriteLine("s) Sim\t n) Não");
            res = char.Parse(Console.ReadLine());
        } while(res != 's' && res != 'n');

        if(res == 's'){
            ret = fila.Remover();
            if(ret != 0){
                Console.WriteLine("Valor removido: {0}", ret);
                Remover(fila);
            }
        }
        else{
            Console.WriteLine("\nFim do programa!");
        }
        break;
    }
}

Console.WriteLine("Você deseja inserir ou remover da fila?");
Console.WriteLine("a) Inserir\tb) Remover");
char res = char.Parse(Console.ReadLine());

switch(res){
    case 'a':
    Console.Write("O número: ");
    int n = int.Parse(Console.ReadLine());
    fl.Inserir(n);
    InserirMais(fl);
    break;
    case 'b':
    Console.WriteLine("A fila já está vazia.");
    break;
    default:
    do{
        Console.WriteLine("\nEscolha uma opção válida!");
        Console.WriteLine("\nVocê deseja inserir ou remover da fila?");
        Console.WriteLine("a) Inserir\tb) Remover");
        res = char.Parse(Console.ReadLine());
    } while(res != 'a' && res != 'b');

    if(res == 'a'){
        Console.Write("O número: ");
        n = int.Parse(Console.ReadLine());
        fl.Inserir(n);
        InserirMais(fl);
    }
    else
        Console.WriteLine("A fila já está vazia.");
    break;
}

Console.WriteLine("\n----- Fila -----");
fl.Imprimir();