int funcRec1(int a){
    if(a<=1)
        return 0;
    else
        return funcRec1((a-2)+5);
}

int func;
Console.Write("Insira um número: ");
int num = int.Parse(Console.ReadLine());
func = funcRec1(num);
Console.Write("Retorno da função = {0}", func);