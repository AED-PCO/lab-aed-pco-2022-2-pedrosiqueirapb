int fat (int n){
if(n == 2){
    return 2;
}
int res = 0;
res = n * fat(n-1);
return res;
}
int n, f;
Console.Write("Entre com um número: ");
n = int.Parse(Console.ReadLine());
f = fat(n);
Console.Write("O fatorial de {0} é {1}", n, f);