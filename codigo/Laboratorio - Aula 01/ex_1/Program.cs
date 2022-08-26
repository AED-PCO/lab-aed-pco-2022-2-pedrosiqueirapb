int quoc, rest;
for(int i=1000; i<=9999; i++){
    quoc = i/100; // pega apenas a parte inteira do resultado
    rest = i % 100; // pega o resto da divisão
    if(i == Math.Pow(rest + quoc, 2)){
        Console.WriteLine(i);
    }
}