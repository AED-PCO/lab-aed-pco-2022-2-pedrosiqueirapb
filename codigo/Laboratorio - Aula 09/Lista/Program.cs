/*
. Lista em ordem qualquer
. Passar para outra lista com o dobro de tamanho que tenha a primeira metade na ordem normal e a segunda metade na ordem inversa

Exemplo:
1 2 3 4
1 2 3 4 4 3 2 1
*/

void Imprime(int[] Vetor){
    for(int i=0; i<Vetor.Length; i++)
        Console.Write(Vetor[i] + " ");
}

int Remove(int[] Vetor, ref int pos){
    pos--; // remove os elementos começando da última posição do vetor
    return Vetor[pos];
}

int Remove2(int[] Vetor, ref int pos){
    pos++; // remove os elementos começando da posição 0 do vetor
    return Vetor[pos];
}

void Insere(int[] Vetor, ref int pos, int num){
    Vetor[pos] = num;
    pos++;
}

int[] funcao(int[] Vetor, int pos){
    int[] aux = new int[pos];
    int[] listaDobrada = new int[pos*2]; // lista com o dobro do tamanho da original

    int j=-1;
    int k = j;

    for(int i=0; i<Vetor.Length;)
        Insere(aux, ref i, Remove(Vetor, ref pos)); // função para inserir os valores invertidos da lista original na lista auxiliar

    Console.WriteLine("\n----- Lista auxiliar -----");
    Imprime(aux);

    for(int i=0; i<listaDobrada.Length/2;)
        Insere(listaDobrada, ref i, Remove2(Vetor, ref k)); // função para inserir os valores em ordem correta na primeira metade da lista

    for(int i=listaDobrada.Length/2; i<listaDobrada.Length;)
        Insere(listaDobrada, ref i, Remove2(aux, ref j)); // função para inserir os valores na ordem invertida na segunda metade da lista

    return listaDobrada;
}

int[] lista = new int[5] {1,2,3,4,5};
int [] novaLista = new int[10];

Console.WriteLine("----- Lista original -----");
Imprime(lista);
novaLista = funcao(lista, lista.Length);
Console.WriteLine("\n----- Lista dobrada -----");
Imprime(novaLista);