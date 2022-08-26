void exibeMatriz (int [,] matriz){
    for(int i=0; i<5; i++){
        for(int j=0; j<3; j++){
            Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
int[,] matriz = new int[5,3];
for(int i=0; i<5; i++){
    for(int j=0; j<3; j++){
        Console.Write("Entre com um valor para a posição ({0}, {1}): ", i, j);
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
exibeMatriz(matriz);
int somaL1=0, somaL2=0, somaL3=0, somaL4=0, somaL5=0, somaC1=0, somaC2=0, somaC3=0;
for(int i=0; i<5; i++){
    for(int j=0; j<3; j++){
        switch(i){
            case 0:
            somaL1 = somaL1 + matriz[i, j];
            break;
            case 1:
            somaL2 = somaL2 + matriz[i, j];
            break;
            case 2:
            somaL3 = somaL3 + matriz[i, j];
            break;
            case 3:
            somaL4 = somaL4 + matriz[i, j];
            break;
            case 4:
            somaL5 = somaL5 + matriz[i, j];
            break;
        }
        switch(j){
            case 0:
            somaC1 = somaC1 + matriz[i, j];
            break;
            case 1:
            somaC2 = somaC2 + matriz[i, j];
            break;
            case 2:
            somaC3 = somaC3 + matriz[i, j];
            break;
        }
    }
}
Console.WriteLine("Soma linha 1 = {0}", somaL1);
Console.WriteLine("Soma linha 2 = {0}", somaL2);
Console.WriteLine("Soma linha 3 = {0}", somaL3);
Console.WriteLine("Soma linha 4 = {0}", somaL4);
Console.WriteLine("Soma linha 5 = {0}", somaL5);
Console.WriteLine("Soma coluna 1 = {0}", somaC1);
Console.WriteLine("Soma coluna 2 = {0}", somaC2);
Console.WriteLine("Soma coluna 3 = {0}", somaC3);