Lista list = new Lista();

void InserirMais(){
    Console.WriteLine("\nDeseja inserir?");
    Console.WriteLine("s) Sim\tn) Não");
    char res = char.Parse(Console.ReadLine());
    int pos=0;
    switch(res){
        case 's':
        Console.Write("O número: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEm alguma posição?");
        Console.WriteLine("s) Sim\tn) Não");
        res = char.Parse(Console.ReadLine());
        switch(res){
            case 's':
            Console.Write("Na posição: ");
            pos = int.Parse(Console.ReadLine());
            list.InserirPos(num, pos);
            break;
            case 'n':
            list.AdicionaValor(num);
            break;
            default:
            do{
                Console.WriteLine("\nEscolha uma opção válida!");
                Console.WriteLine("\nEm alguma posição?");
                Console.WriteLine("s) Sim\tn) Não");
                res = char.Parse(Console.ReadLine());
            } while(res != 's' && res != 'n');

            if(res == 's'){
                Console.Write("Na posição: ");
                pos = int.Parse(Console.ReadLine());
                list.InserirPos(num, pos);
            }
            else
                list.AdicionaValor(num);
            break;
        }
        InserirMais();
        break;
        case 'n':
        Remover();
        break;
        default:
        do{
            Console.WriteLine("\nEscolha uma opção válida!");
            Console.WriteLine("\nDeseja inserir?");
            Console.WriteLine("s) Sim\tn) Não");
            res = char.Parse(Console.ReadLine());
        } while(res != 's' && res != 'n');

        if(res == 's'){
            Console.Write("O número: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Na posição: ");
            pos = int.Parse(Console.ReadLine());
            list.InserirPos(num, pos);
            InserirMais();
        }
        else
            Remover();
        break;
    }
}

void Remover(){
    int del=0, val=0;
    Console.WriteLine("\nDeseja remover?");
    Console.WriteLine("s) Sim\tn) Não");
    char res = char.Parse(Console.ReadLine());
    bool vazio = list.ListaVazia();
    if(vazio == false){
        switch(res){
            case 's':
            Console.Write("O valor: ");
            val = int.Parse(Console.ReadLine());
            del = list.Remover(val);
            Console.WriteLine("Valor removido: {0}", del);
            Remover();
            break;
            case 'n':
            Console.WriteLine("\nFim do programa!");
            break;
            default:
            do{
                Console.WriteLine("\nEscolha uma opção válida!");
                Console.WriteLine("\nDeseja remover?");
                Console.WriteLine("s) Sim\tn) Não");
                res = char.Parse(Console.ReadLine());
            } while(res != 's' && res != 'n');

            if(res == 's'){
                Console.WriteLine("O valor: ");
                val = int.Parse(Console.ReadLine());
                del = list.Remover(val);
                Console.WriteLine("Valor removido: {0}", del);
                Remover();
            }
            else
                Console.WriteLine("\nFim do programa!");
            break;
        }
    }
    else
        Console.WriteLine("A lista está vazia!");
}

Console.WriteLine("Você deseja inserir ou remover da lista?");
Console.WriteLine("a) Inserir\tb) Remover");
char res = char.Parse(Console.ReadLine());
switch(res){
    case 'a':
    Console.Write("O número: ");
    int num = int.Parse(Console.ReadLine());
    list.AdicionaValor(num);
    InserirMais();
    break;
    case 'b':
    Console.WriteLine("A lista já está vazia.");
    break;
    default:
    do{
        Console.WriteLine("\nEscolha uma opção válida!");
        Console.WriteLine("Você deseja inserir ou remover da lista?");
        Console.WriteLine("a) Inserir\tb) Remover");
        res = char.Parse(Console.ReadLine());
    } while(res != 'a' && res != 'b');

    if(res == 'a'){
        Console.Write("O número: ");
        num = int.Parse(Console.ReadLine());
        list.AdicionaValor(num);
        InserirMais();
    }
    else
        Console.WriteLine("A lista já está vazia.");
    break;
}

Console.WriteLine("\n----- Lista -----");
list.Imprimir();