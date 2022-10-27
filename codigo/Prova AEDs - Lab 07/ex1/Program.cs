StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\Prova AEDs - Lab 07\ex1\arq1.txt");
string linha = sr.ReadLine();
sr.Close();
linha = linha.Replace(",", "");
linha = linha.Replace(".", "");
string[] arq = linha.Split(' ');

Console.Write("Insira um texto: ");
string txt = Console.ReadLine();
string[] vet = txt.Split(' ');

int iguais=0;
for(int i=0; i<vet.Length; i++){
    for(int j=0; j<arq.Length; j++){
        if(arq[j] == vet[i])
            iguais++;
    }
}
int difer = (arq.Length-iguais) + (vet.Length-iguais);
Console.Write("Iguais = {0}, Diferentes = {1}", iguais, difer);