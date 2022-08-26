int[] A = new int [5];
int[] B = new int [5];
int[] C = new int [5];
int[] D = new int [5];
Console.WriteLine("----- Vetor A -----");
for(int i=0; i<5; i++){
    Console.Write("Entre com um valor para a posição " + i + ": ");
    A[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("----- Vetor B -----");
for(int i=0; i<5; i++){
    do{
        Console.Write("Entre com um valor para a posição " + i + ": ");
        B[i] = int.Parse(Console.ReadLine());
    }while (B[i] == A[i]);
}
Console.WriteLine("----- Vetor C -----");
for(int i=0; i<5; i++){
    if(A[i] == B[0] || A[i] == B[1] || A[i] == B[2] || A[i] == B[3] || A[i] == B[4]){
        C[i] = A[i];
        Console.Write(C[i] + " \n");
    }
}
Console.WriteLine("----- Vetor D -----");
    for(int i=0; i<5; i++){
        if(A[i] != B[0] && A[i] != B[1] && A[i] != B[2] && A[i] != B[3] && A[i] != B[4]){
        D[i] = A[i];
        Console.Write(D[i] + " ");
    }
}