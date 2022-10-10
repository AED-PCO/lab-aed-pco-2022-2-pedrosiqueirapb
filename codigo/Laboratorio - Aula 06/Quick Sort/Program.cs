void QuickSort(int[] Vetor, int Inicio, int Fim){
    int i = Inicio, j = Fim, pivo = Vetor[Inicio];

    while(i <= j){
        while(Vetor[i] < pivo){
            i++;
        }
        while(Vetor[j] > pivo){
            j--;
        }
        if(i <= j){
            int aux = Vetor[i];
            Vetor[i] = Vetor[j];
            Vetor[j] = aux;
            i++;
            j--;
        }
    }
    if(Inicio < j){
        QuickSort(Vetor, Inicio, j);
    }
    if(i < Fim){
        QuickSort(Vetor, i, Fim);
    }
}

int[] vet = new int[10];
Random numAleatorio = new Random();
for(int i=0; i<vet.Length; i++){
    vet[i] = numAleatorio.Next(0,50);
}
QuickSort(vet, 0, vet.Length-1);
for(int j=0; j<vet.Length-1; j++){
    Console.Write(vet[j] + " ");
}