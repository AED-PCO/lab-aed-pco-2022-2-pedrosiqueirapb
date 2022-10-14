/* Pesquisa binária com pos */

int buscaBinaria (int[] Vetor, int Valor, int Inicio, int Fim){
    int mid = ((Inicio + Fim) / 2);

    if(Inicio <= Fim){
        if(Vetor[mid] == Valor){
            int pos = mid;
            return pos;
        }
        else if(Vetor[mid] > Valor){
            return buscaBinaria(Vetor, Valor, Inicio, (mid-1));
        }
        else{
            return buscaBinaria(Vetor, Valor, (mid+1), Fim);
        }
    }
    else{
        return -1;
    }
}
int[] vetor = new int [11] {0,2,4,6,8,10,12,14,16,18,20};
Console.Write("Insira o valor que se deseja procurar: ");
int numero = int.Parse(Console.ReadLine());

int funcao = buscaBinaria(vetor, numero, 0, vetor.Length-1);

if(funcao == -1){
    Console.Write("O número não existe dentro do vetor.");
}
else{
    Console.Write("O valor está na posição {0}.",funcao);
}