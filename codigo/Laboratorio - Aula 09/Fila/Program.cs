// Copiar uma fila para outra ao contrário

void Imprime(int[] Vetor){
    for(int i=0; i<Vetor.Length; i++){
        Console.Write(Vetor[i] + " ");
    }
}

int RemoveDaFila(int[] Vetor){
    int aux = Vetor[0]; // a fila sempre retorna o elemento na posição 0
    for(int i=0; i<Vetor.Length-1; i++) // shift na fila após o elemento na posição zero ter sido retirado
        Vetor[i] = Vetor[i+1];
    
    return aux;
}

int RemoveDaPilha(int[] Vetor, ref int pos){
    pos--; // os elementos na pilha começam a ser retirados na última posição
    return Vetor[pos];
}

void Insere(int[] Vetor, ref int pos, int num){
    Vetor[pos] = num; // pilha e fila inserem na última posição disponível
    pos++;
}

int[] Copiar(int[] Vetor, int pos){
    int[] pilha = new int[pos];
    int[] aux = new int[pos];

    for(int i=0; i<Vetor.Length;)
        Insere(pilha, ref i, RemoveDaFila(Vetor));

    Console.WriteLine("\n----- Pilha auxiliar -----");
    Imprime(pilha);

    for(int j=0; j<Vetor.Length;)
        Insere(aux, ref j, RemoveDaPilha(pilha, ref pos));

    return aux;
}

int[] fila = new int[5] {1,2,3,4,5};
int[] novaFila = new int[5];

Console.WriteLine("----- Fila original -----");
Imprime(fila);

novaFila = Copiar(fila, fila.Length);

Console.WriteLine("\n----- Nova fila -----");
Imprime(novaFila);