int n, div=0;
Console.Write("Entre com um número: ");
n = int.Parse(Console.ReadLine());
for(int i=1; i<=n; i++){
    if(n % i == 0){
        div++;
    }
}
if(div == 2){
    Console.WriteLine("O número " + n + " é um número primo.");
}
else{
    Console.Write("O número " + n + " não é um número primo.");
}