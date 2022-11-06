/* Lista */

void imprime(int[] Vetor){
    for(int i=0; i<Vetor.Length; i++){
        Console.Write(Vetor[i] + " ");
    }
}

bool listaVazia(int[] Vetor){
    int count=0;
    for(int i=0; i<Vetor.Length; i++){
        if(Vetor[i] == 0){
            count++;
        }
    }
    if(count > 0)
        return true;
    else
        return false;
}

int[] remover(int[] Vetor, int pos){
    int aux, i;
    if(Vetor[pos] == 0){
        Console.Write("A posição correspondente já está vazia.\n");
    }
    else if(pos == Vetor.Length-1){
        aux = Vetor[pos];
        Vetor[pos] = 0;
        imprime(Vetor);
    }
    else{
        for(i=pos; i<Vetor.Length-1; i++){
            aux = Vetor[pos];
            Vetor[i] = Vetor[i+1];
        }
        imprime(Vetor);
        Console.WriteLine();
        }
    return Vetor;
}

int[] inserir(int[] Vetor, int pos){
    int num, f;
    if(Vetor[pos] == 0){
        Console.Write("Número a ser inserido: ");
        num = int.Parse(Console.ReadLine());
        Vetor[pos] = num;
        imprime(Vetor);
    }
    else if(pos == Vetor.Length-1){
        Console.Write("\nNão é possível inserir na posição");
    }
    else{
        int aux=pos;
        Console.Write("Número a ser inserido: ");
        num = int.Parse(Console.ReadLine());
        if(Vetor[pos+1] == 0 && Vetor[pos+2] == 0){
            Vetor[pos+1] = Vetor[pos];
        }
        else if(Vetor[pos+1] == 0 && Vetor[pos+2] != 0){
            Vetor[pos+1] = Vetor[pos];
        }
        else{
            for(int j=Vetor.Length-1; j>pos; j--){
                if(Vetor[j-1] != 0)
                    Vetor[j] = Vetor[j-1];
            }
        }
        Vetor[aux] = num;
        imprime(Vetor);
    }
    return Vetor;
}

int[] vet = new int[10] {1,0,0,4,5,5,0,0,0,9};

char resp; int pos; bool func;
Console.WriteLine("Você deseja inserir ou remover na lista?");
Console.WriteLine("a) Inserir\tb) Remover");
resp = char.Parse(Console.ReadLine());
while(resp != 'a' && resp != 'b'){
    Console.WriteLine("\nEscolha uma opção válida.\n");
    Console.WriteLine("Você deseja inserir ou remover na lista?");
    Console.WriteLine("a) Inserir\tb) Remover");
    resp = char.Parse(Console.ReadLine());
}
switch(resp){
    case 'a':
        func = listaVazia(vet);
        if(func == true){
            Console.Write("Posição que se deseja inserir: ");
            pos = int.Parse(Console.ReadLine());
            inserir(vet, pos);
            do{
                func = listaVazia(vet);
                if(func == true){
                    Console.WriteLine("\n\nDeseja inserir mais valores?");
                    Console.WriteLine("s) Sim\tn) Não");
                    resp = char.Parse(Console.ReadLine());
                    switch(resp){
                        case 's':
                            Console.Write("Na posição: ");
                            pos = int.Parse(Console.ReadLine());
                            inserir(vet, pos);
                        break;
                        case 'n':
                            Console.Write("\nFim do programa!");
                        break;
                        default:
                            while(resp != 's' && resp != 'n'){
                                Console.WriteLine("\nEscolha uma opção válida");
                                Console.WriteLine("\n\nDeseja inserir mais valores?");
                                Console.WriteLine("s) Sim\tn) Não");
                                resp = char.Parse(Console.ReadLine());
                                if(resp == 'n'){
                                    Console.Write("\nFim do programa!");
                                }
                                else if(resp == 's'){
                                    Console.Write("Na posição: ");
                                    pos = int.Parse(Console.ReadLine());
                                    inserir(vet, pos);
                                }
                            }
                        break;
                    }
                }
            } while(func == true && resp == 's');
        }
        else{
            Console.WriteLine("A lista está cheia.");
        }
    break;
    case 'b':
        Console.Write("Posição que se deseja remover: ");
        pos = int.Parse(Console.ReadLine());
        remover(vet, pos);
        do{
            Console.WriteLine("\nDeseja remover mais valores?");
            Console.WriteLine("s) Sim\tn) Não");
            resp = char.Parse(Console.ReadLine());
            switch(resp){
                case 's':
                    Console.Write("Na posição: ");
                    pos = int.Parse(Console.ReadLine());
                    remover(vet, pos);
                break;
                case 'n':
                    Console.WriteLine("\nFim do programa!");
                break;
                default:
                    while(resp != 's' && resp != 'n'){
                        Console.WriteLine("\nEscolha uma opção válida.");
                        Console.WriteLine("\nDeseja remover mais valores?");
                        Console.WriteLine("s) Sim\tn) Não");
                        resp = char.Parse(Console.ReadLine());
                        if(resp == 'n'){
                            Console.Write("\nFim do programa!");
                        }
                        else if(resp == 's'){
                            Console.Write("Na posição: ");
                            pos = int.Parse(Console.ReadLine());
                            remover(vet, pos);
                        }
                    }
                break;
            }
        } while(resp == 's');
    break;
}