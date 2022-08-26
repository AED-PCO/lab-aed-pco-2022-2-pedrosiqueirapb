int somatorio (int x, int y){
    if(y == 1){
        return x;
    }
    else if(x == 0 || y == 0){
        return 0;
    }
    else{
        return x + somatorio(x, y-1);
    }
}
int n1, n2, f;
Console.Write("Entre com um número a ser multiplicado: ");
n1 = int.Parse(Console.ReadLine());
Console.Write("Quantas vezes esse número será multiplicado? ");
n2 = int.Parse(Console.ReadLine());
f = somatorio(n1, n2);
Console.Write("O resultado da multiplicação é {0}", f);