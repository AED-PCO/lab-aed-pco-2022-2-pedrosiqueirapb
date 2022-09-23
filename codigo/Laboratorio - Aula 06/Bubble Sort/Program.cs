/* 10, 100, 500, 1000, 5000, 10000 */
/* comparação e troca */

Random numAleatorio = new Random();

int comp=0, trc=0;
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
                trc++;
            }
            comp++;
        }
    }
}

BubbleSort(vet);

for(int i=0; i<vet.Length; i++){
    Console.Write(vet[i] + " ");
}
Console.WriteLine("\nComparações = {0}, Trocas = {1}", comp, trc);