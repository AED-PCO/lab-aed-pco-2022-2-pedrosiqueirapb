/* Fila */

// Função para inserir na fila.
int[] inserir(int[] Vetor){
    for(int i=0; i<Vetor.Length-1; i++){
        if(Vetor[i] == 0){
            Console.Write("Entre com um valor para a {0}° posição: ", i);
            int val = int.Parse(Console.ReadLine());
            Vetor[i] = val;
            Console.WriteLine("Deseja continuar inserindo na fila? ");
            Console.WriteLine("s) Sim\tn) Não");
            char resp = char.Parse(Console.ReadLine());
            Console.WriteLine();
            switch(resp){
                case 's':
                    i++;
                    Console.Write("Entre com um valor para a {0}° posição: ", i);
                    val = int.Parse(Console.ReadLine());
                    Vetor[i] = val;
                    if(Vetor[i] != 0 && Vetor[Vetor.Length-1] == 0){
                        Console.WriteLine("Deseja continuar inserindo na fila? ");
                        Console.WriteLine("s) Sim\tn) Não");
                        resp = char.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }
                break;
                case 'n':
                    return Vetor;
                break;
                default:
                    do{
                        Console.WriteLine("! Escreva uma opção válida.\n");
                        Console.WriteLine("Deseja continuar inserindo na fila? ");
                        Console.WriteLine("s) Sim\tn) Não");
                        resp = char.Parse(Console.ReadLine());
                        Console.WriteLine();
                    } while(resp != 's' && resp != 'n');
                    
                break;
            }
        }
    }
    if(Vetor[Vetor.Length-1] == 0 && Vetor[Vetor.Length-2] != 0){
        Console.Write("Insira um valor para a última posição: ");
        int res = int.Parse(Console.ReadLine());
        Vetor[Vetor.Length-1] = res;
    }
    return Vetor;
}

// Função para remover na fila.
int[] remover(int[] Vetor){
    for(int i=0; i<Vetor.Length-1; i++){
        Vetor[i] = Vetor[i+1];
    }
    return Vetor;
}

// Programa principal

int[] vet = new int[10] {1,2,3,4,5,0,0,0,0,0};

Console.WriteLine("Você deseja inserir ou remover da fila?");
Console.WriteLine("a) Remover\tb) Inserir");
char resp = char.Parse(Console.ReadLine());

switch(resp){
    case 'a':
        if(vet[0] == 0)
            Console.WriteLine("A fila está vazia.");
        else{
            int[] func = remover(vet);
            for(int i=0; i<vet.Length; i++)
                Console.Write(vet[i] + " ");
            Console.WriteLine();
            Console.WriteLine("\nDeseja continuar removendo?");
            Console.WriteLine("s) Sim\tn) Não");
            char opcao = char.Parse(Console.ReadLine());
            if(opcao != 's' && opcao != 'n'){
                do{
                    Console.WriteLine();
                    Console.WriteLine("Escolha uma opção válida.");
                    Console.WriteLine("\nDeseja continuar removendo?");
                    Console.WriteLine("s) Sim\tn) Não");
                    opcao = char.Parse(Console.ReadLine());
                } while(opcao != 's' && opcao != 'n');
            }
            while(opcao == 's' && vet[0] != vet[vet.Length-1]){
                int[] funcao = remover(vet);
                for(int i=0; i<vet.Length; i++){
                    Console.Write(vet[i] + " ");
                }
                Console.WriteLine();
                if(vet[0] == vet[vet.Length-1]){
                    Console.ReadKey();
                }
                else{
                    Console.WriteLine("\nDeseja continuar removendo?");
                    Console.WriteLine("s) Sim\tn) Não");
                    opcao = char.Parse(Console.ReadLine());
                    if(opcao != 's' && opcao != 'n'){
                        Console.WriteLine("\nEscolha uma opção válida.");
                        Console.WriteLine("\nDeseja continuar removendo?");
                        Console.WriteLine("s) Sim\tn) Não");
                        opcao = char.Parse(Console.ReadLine());
                    }
                }
            }
        }
    break;
    case 'b':
        if(vet[vet.Length-1] != 0){
            Console.WriteLine("A fila já está preenchida.");
        }
        else{
            int[] function = inserir(vet);
            for(int j=0; j<vet.Length; j++){
                Console.Write(vet[j] + " ");
            }
        }
    break;
    default:
        Console.Write("Escolha uma opção válida.");
    break;
}