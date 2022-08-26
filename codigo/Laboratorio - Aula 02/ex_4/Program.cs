int qntChar (string Frase, char Letra){
    if(Frase.Length == 0){
        return 0;
    }
    else if(Frase[0] == Letra){
        return qntChar(Frase.Substring(1), Letra) + 1;
    }
    else{
        return qntChar(Frase.Substring(1), Letra);
    }
}

string frase; char letra; int f;

Console.WriteLine("Entre com uma frase: ");
frase = Console.ReadLine();
Console.Write("Insira uma letra: ");
letra = char.Parse(Console.ReadLine());

f = qntChar(frase, letra);
Console.Write("A letra {0} apareceu {1} vezes na frase.", letra, f);