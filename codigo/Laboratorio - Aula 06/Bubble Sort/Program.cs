Random numAleatorio = new Random();

int[] vet = new int [10];
for(int j=0; j<vet.Length; j++){
    vet[j] = numAleatorio.Next(0,100); 
}

void BubbleSort (int[] Vetor){
    int aux, i, j;
    for(i=0; i<Vetor.Length; i++){
        for(j=0; j<Vetor.Length-1; j++){
            if(Vetor[j] > Vetor[j+1]){
                aux = Vetor[j];
                Vetor[j] = Vetor[j+1];
                Vetor[j+1] = aux;
            }
        }
    }
}

BubbleSort(vet);

for(int i=0; i<vet.Length; i++){
    Console.Write(vet[i] + " ");
}
