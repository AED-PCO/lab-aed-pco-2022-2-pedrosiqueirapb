for(int i=1; i<=1000; i++){
    int somaDiv = 0;
for(int j=1; j<i; j++){
    if(i % j == 0){
        somaDiv = somaDiv + j;
    }
}
if(somaDiv == i){
        Console.WriteLine("O número {0} é um número perfeito.", i);
    }
}