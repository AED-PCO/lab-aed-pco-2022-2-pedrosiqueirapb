void ShellSort(int[]Vetor, int Tam){
    for (int h=Tam/2; h>0; h/=2){
        for (int i = h; i < Tam; i++){
            int valor = Vetor[i];
            int k = i;

            while (k>=h && Vetor[k-h] > valor){
                Vetor[k] = Vetor[k-h];
                k -= h;
            }
            Vetor[k] = valor;
        }
    }
}

int[] vet = new int[10];
Random numAleatorio = new Random();
for(int i=0; i<vet.Length; i++){
    vet[i] = numAleatorio.Next(0,100);
}
ShellSort(vet, vet.Length);
for(int j=0; j<vet.Length; j++){
    Console.Write(vet[j] + " ");
}