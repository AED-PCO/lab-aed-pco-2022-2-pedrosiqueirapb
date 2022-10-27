StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\Prova AEDs - Lab 07\ex3\entrada.txt");
string linha = sr.ReadLine();
sr.Close();

StreamWriter sw = new StreamWriter(@"C:\Users\User\Desktop\Prova AEDs - Lab 07\ex3\saida.txt");
for(int i=linha.Length-1; i>=0; i--)
    sw.Write(linha[i]);
sw.Close();