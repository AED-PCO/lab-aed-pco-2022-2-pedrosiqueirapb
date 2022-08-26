double calcPotencia(ref int n1, ref int n2){
    double p;
    p = Math.Pow(n1, n2);
    return p;
}

int x, y; double f;
Console.Write("Entre com um número: ");
x = int.Parse(Console.ReadLine());
Console.Write("Insira outro número: ");
y = int.Parse(Console.ReadLine());
f = calcPotencia(ref x, ref y);
Console.Write("O valor de " + x + "^" + y + " é " + f);