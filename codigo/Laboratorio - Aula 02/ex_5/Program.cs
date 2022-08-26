int calculaSoma (int[] Vetor, int i){
  if(i == -1){
    return 0;
  }
  else if(Vetor[i] % 2 == 1 || Vetor[i] % 2 == -1){
    return calculaSoma(Vetor, i-1);
  }
  else{
    return Vetor[i] + calculaSoma(Vetor, i-1);
  }
}

int f, i;
int [] vetor = new int [10];
for(i = 0; i < vetor.Length; i++){
Console.Write("Entre com um valor para a posição {0}: ", i);
vetor[i] = int.Parse(Console.ReadLine());
}
f = calculaSoma(vetor, i-1);
Console.Write("A soma dos valores pares do vetor é {0}", f);
Console.ReadKey();