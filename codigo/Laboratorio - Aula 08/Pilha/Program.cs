/* Pilha */

int[] inserir(int[] Vetor){
    int num;
    if(Vetor[Vetor.Length-1] != 0){
        Console.Write("A pilha está cheia.\n");
        return Vetor;
    }
    for(int i=0; i<Vetor.Length-1; i++){
        if(Vetor[i] == 0){
            Console.Write("Entre com um número para a posição {0}: ", i);
            num = int.Parse(Console.ReadLine());
            Vetor[i] = num;
            Console.WriteLine("Deseja continuar inserindo na pilha?");
            Console.WriteLine("s) Sim\tn) Não");
            char resp = char.Parse(Console.ReadLine());
            switch(resp){
                case 's':
                    Console.Write("Entre com um número para a posição {0}: ", i+1);
                    num = int.Parse(Console.ReadLine());
                    Vetor[i+1] = num;
                    if(i+1 != Vetor.Length-1){
                        Console.WriteLine("Deseja continuar inserindo na pilha?");
                        Console.WriteLine("s) Sim\tn) Não");
                        resp = char.Parse(Console.ReadLine());
                        if(resp == 'n'){
                            return Vetor;
                        }
                    }
                break;
                case 'n':
                    return Vetor;
                break;
                default:
                    do{
                        Console.WriteLine("\nEscreva uma opção válida!\n");
                        Console.WriteLine("Deseja continuar inserindo na pilha?");
                        Console.WriteLine("s) Sim\tn) Não");
                        resp = char.Parse(Console.ReadLine());
                    } while(resp != 's' && resp != 'n');
                break;
            }
        }
    }
    if(Vetor[Vetor.Length-1] == 0 && Vetor[Vetor.Length-2] != 0){
        Console.Write("Entre com um valor para a última posição: ");
        int val = int.Parse(Console.ReadLine());
        Vetor[Vetor.Length-1] = val;
    }
    return Vetor;
}

int[] remover(int[] Vetor){
    if(Vetor[0] == 0){
        Console.WriteLine("A pilha já está vazia.");
    }
    for(int i=Vetor.Length-1; i>=0; i--){
        while(Vetor[i] != 0){
            if(Vetor[i] != 0){
                Vetor[i] = 0;
                for(int j=0; j<Vetor.Length; j++){
                    Console.Write(Vetor[j] + " ");
                }
            }
            else if(Vetor[0] == 0){
                Console.Write("A pilha já está vazia.\n");
            }
            if(Vetor[0] != 0){
                Console.WriteLine();
                Console.WriteLine("\nDeseja continuar removendo?");
                Console.WriteLine("s) Sim\tn) Não");
                char resp = char.Parse(Console.ReadLine());
                switch(resp){
                    case 's':
                        if(Vetor[i] != 0){
                            Vetor[i] = 0;
                        }
                    break;
                    case 'n':
                        return Vetor;
                    break;
                    default:
                        do{
                            Console.WriteLine("\nEscolha uma opção válida");
                            Console.WriteLine();
                            Console.WriteLine("Deseja continuar removendo?");
                            Console.WriteLine("s) Sim\tn) Não");
                            resp = char.Parse(Console.ReadLine());
                        } while(resp != 's' && resp != 'n');
                    break;
                }
            }
        }
    }
    return Vetor;
}

int[] vet = new int[10] {1, 1, 1, 1, 1, 0, 0, 0, 0, 0};

Console.Write("Você deseja inserir ou remover da pilha? \n");
Console.WriteLine("a) Remover\tb) Inserir");
char resp = char.Parse(Console.ReadLine());

switch(resp){
    case 'a':
    int[] func = remover(vet);
    break;
    case 'b':
    int[] function = inserir(vet);
    for(int i=0; i<vet.Length; i++)
        Console.Write(function[i] + " ");
    break;
    default:
        Console.Write("Escreva uma resposta válida.");
    break;
}
