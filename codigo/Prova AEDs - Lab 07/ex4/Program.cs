﻿void Merge(long[] Vetor, long Inicio, long Meio, long Fim){
  long tamL = Meio - Inicio + 1, tamR = Fim - Meio, i, j, k;
  long[] left = new long[tamL];
  long[] right = new long[tamR];

  for (i = 0; i < tamL; ++i){
    left[i] = Vetor[Inicio + i];
  }
  for (j = 0; j < tamR; ++j){
    right[j] = Vetor[Meio + 1 + j];
  }

  i = 0; j = 0; k = Inicio;

  while (i < tamL && j < tamR){
    if (left[i] <= right[j]){
      Vetor[k++] = left[i++];
    }
    else{
      Vetor[k++] = right[j++];
    }
  }
  while (i < tamL){
    Vetor[k++] = left[i++];
  }
  while (j < tamR){
    Vetor[k++] = right[j++];
  }
}

void MergeSort(long[] Vetor, long Inicio, long Fim){
  if (Inicio < Fim){
    long mid = Inicio + (Fim - Inicio) / 2;
    MergeSort(Vetor, Inicio, mid);
    MergeSort(Vetor, mid + 1, Fim);
    Merge(Vetor, Inicio, mid, Fim);
  }
}

long[] vet = new long[10];
Random numAleatorio = new Random();
for(int i=0; i<vet.Length; i++){
  vet[i] = numAleatorio.NextInt64(10000000000, 99999999999);
}

MergeSort(vet, 0, vet.Length-1);
for(int j=0; j<vet.Length; j++){
    Console.WriteLine(vet[j]);
}