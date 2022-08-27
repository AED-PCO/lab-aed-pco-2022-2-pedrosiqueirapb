/* 0, 1, 1, 2, 3, 5, 8, 13... */
int Fibonacci (int pos){
    if(pos == 1){
        return 0;
    }
    else if(pos == 2){
        return 1;
    }
    else{
        return Fibonacci(pos - 1) + Fibonacci(pos - 2);
    }
}
int n, f;
Console.Write("Entre com a posição que se deseja saber da Sequência de Fibonacci: ");
n = int.Parse(Console.ReadLine());
f = Fibonacci(n);
Console.WriteLine("O número da {0}° posição da Sequência de Fibonacci é {1}", n, f);