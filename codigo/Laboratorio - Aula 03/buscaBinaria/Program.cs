/* Pesquisa binária sem pos */

int buscaItem (int[] Vetor, int Valor, int Inicio, int Fim){
    int mid = ((Inicio + Fim) / 2);

    if(Inicio <= Fim){
        if(Vetor[mid] == Valor){
            return mid;
        }
        else if(Vetor[mid] > Valor){
            return buscaItem(Vetor, Valor, Inicio, (mid-1));
        }
        else{
            return buscaItem(Vetor, Valor, (mid+1), Fim);
        }
    }
    else{
        return -1;
    }
}
int[] vetor = new int [11] {1,3,5,7,9,11,13,15,17,19,21};
Console.Write("Insira o valor que se deseja procurar: ");
int numero = int.Parse(Console.ReadLine());

int funcao = buscaItem(vetor, numero, 0, vetor.Length-1);

if(funcao == -1){
    Console.Write("O número não existe dentro do vetor.");
}
else{
    Console.Write("O valor está na posição {0}.",funcao);
}