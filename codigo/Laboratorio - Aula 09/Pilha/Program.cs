/* Copiar uma pilha para outra */

void Imprime(int[] Vetor){
    for(int i=0; i<Vetor.Length; i++)
        Console.Write(Vetor[i] + " ");
}

int Remove(int[] Vetor, ref int index){
    index--; // index começa em Vetor.Length e precisa ser decrementado
    return Vetor[index];
}

void Insere(int[] Vetor, ref int index, int num){
    Vetor[index] = num;
    index++; // index começa em 0 e precisa ser incrementado
}

int[] Copiar(int[] Vetor, int pos){
    int[] aux = new int[Vetor.Length];
    int[] copia = new int[Vetor.Length];
    int index = pos; // pos não pode ser alterado, então se usa o index na passagem por referência

    for(int i=0; i<Vetor.Length;)
        Insere(aux, ref i, Remove(Vetor, ref index));
    
    Console.WriteLine("\n----- Pilha auxiliar -----");
    Imprime(aux);

    for(int j=0; j<Vetor.Length;){
        Insere(copia, ref j, Remove(aux, ref pos)); // neste ponto pos já pode ser alterado
    }
    return copia;
}

int[] pilha = new int[5] {1,2,3,4,5};
int[] copia = new int[5];

Console.WriteLine("----- Pilha original -----");
Imprime(pilha);

copia = Copiar(pilha, pilha.Length);

Console.WriteLine("\n----- Pilha copiada -----");
Imprime(copia);