/* 10, 50, 100, 1000 */
/* comparações e trocas */

void InsertionSort (int[] Vetor){
    int aux, j, comp=0, trc=0;
    for(int i=1; i<Vetor.Length; i++){
        aux = Vetor[i];
        j = i-1;
        while(j>=0 && aux < Vetor[j]){
            Vetor[j+1] = Vetor[j];
            j--;
            trc++;
        }
        comp+=2;
        Vetor[j+1] = aux;
        trc++;
    }
    Console.WriteLine("Comparações = {0}, Trocas = {1}", comp, trc);
}

Random numAleatorio = new Random();

int[] vet = new int [10];
for(int i=0; i<vet.Length; i++){
    vet[i] = numAleatorio.Next(0,100); 
}

InsertionSort(vet);

for(int j=0; j<vet.Length; j++){
    Console.Write(vet[j] + " ");
}