string retornaFrase(string Frase, int Tam){
    if(Tam == 0){
        return "Digite uma frase na próxima vez.";
    }
    else{
    string semVogal = Frase.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "").
                            Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "").
                            Replace("á", "").Replace("é", "").Replace("í", "").Replace("ó", "").Replace("ú", "").
                            Replace("Á", "").Replace("É", "").Replace("Í", "").Replace("Ó", "").Replace("Ú", "").
                            Replace("â", "").Replace("ê", "").Replace("î", "").Replace("ô", "").Replace("û", "").
                            Replace("Â", "").Replace("Ê", "").Replace("Î", "").Replace("Ô", "").Replace("Û", "").
                            Replace("ã", "").Replace("õ", "").Replace("Ã", "").Replace("Õ", "").Replace("à", "").
                            Replace("è", "").Replace("ì", "").Replace("ò", "").Replace("ù", "").Replace("À", "").
                            Replace("È", "").Replace("Ì", "").Replace("Ò", "").Replace("Ù", "");                       
    retornaFrase(semVogal, Tam-1);
    return semVogal;
    }
}
string frase, f;
Console.Write("Escreva uma frase: ");
frase = Console.ReadLine();
f = retornaFrase(frase, frase.Length-1);
Console.Write(f);