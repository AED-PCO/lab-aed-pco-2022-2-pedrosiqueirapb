/* 100, 500, 1000, 10000 */
/* comparações e trocas */

void SelectionSort (int[] Vetor){
    int aux, indiceMenor, comp=0, trc=0;
    for(int i=0; i<Vetor.Length-1; i++){
        indiceMenor = i;
        for(int j=i+1; j<Vetor.Length; j++){
            if(Vetor[indiceMenor] > Vetor[j]){
                indiceMenor = j;
            }
            comp++;
        }
        if(i != indiceMenor){
            aux = Vetor[i];
            Vetor[i] = Vetor[indiceMenor];
            Vetor[indiceMenor] = aux;
            trc++;
        }
        comp++;
    }
    Console.WriteLine("Comparações = {0}, Trocas = {1}", comp, trc);
}
Random numAleatorio = new Random();

int[] vet = new int [10];

for(int i=0; i<vet.Length; i++){
    vet[i] = numAleatorio.Next(0,100); 
}

SelectionSort(vet);

for(int j=0; j<vet.Length; j++){
    Console.Write(vet[j] + " ");
}