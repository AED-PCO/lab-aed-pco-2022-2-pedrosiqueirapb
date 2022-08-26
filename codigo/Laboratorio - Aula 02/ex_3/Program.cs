int pot (int A, int B){
if(B == 1){
    return A;
}
else if(B == 0){
    return 1;
}
int res = 0;
res = A * pot(A, B-1);
return res;

}
int n1, n2, f;
Console.Write("Entre com um número: ");
n1 = int.Parse(Console.ReadLine());
Console.Write("Insira outro número: ");
n2 = int.Parse(Console.ReadLine());
f = pot(n1, n2);
Console.Write("O resultado da conta é {0}", f);