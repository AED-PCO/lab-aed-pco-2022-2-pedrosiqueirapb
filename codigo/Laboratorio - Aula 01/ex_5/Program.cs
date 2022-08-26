static double calculaFat(int numero){
    int fat = 1;
    for(int i=numero; i>=1; i--){
        fat = fat * i;
    }
    return fat;
}

double f;
int x;
Console.Write("Entre com um número: ");
x = int.Parse(Console.ReadLine());
f = calculaFat(x);
Console.Write("O fatorial de " + x + " é " + f);