int MaiorValor(int[] Vetor, int Tam){
    int maiorValor = Vetor[0];

    for(int i = 1; i < Tam; i++){
        if(Vetor[i] > maiorValor){
            maiorValor = Vetor[i];
        }
    }
    return maiorValor;
}

void CountingSort(int[] Vetor){
    int Tam = Vetor.Length, maiorValor = MaiorValor(Vetor, Tam);
    int[] contador = new int[maiorValor + 1];

    for(int i=0; i<maiorValor+1; i++){
        contador[i] = 0; // zerando todas as posições
    }

    for(int i=0; i<Tam; i++){
        contador[Vetor[i]]++;
    }

    for(int i=0, j=0; i<=maiorValor; i++){
        while(contador[i] > 0){
            Vetor[j] = i;
            j++;
            contador[i]--;
        }
    }
}

Random numAleatorio = new Random();
int[] vet = new int[10];
for(int i=0; i<vet.Length; i++){
    vet[i] = numAleatorio.Next(0, 8);
}

CountingSort(vet);

for(int j=0; j<vet.Length; j++){
    Console.Write(vet[j] + " ");
}