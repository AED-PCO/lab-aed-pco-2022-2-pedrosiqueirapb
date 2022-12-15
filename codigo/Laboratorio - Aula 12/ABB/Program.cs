ArvoreBinaria Arvore = new ArvoreBinaria();

int num = 0;
int res = res = mensagem();

while (res != 7){
    switch (res){
        case 1:
        Console.Write("O valor: ");
        num = int.Parse(Console.ReadLine());
        Arvore.Insere(num);
        Sair();
        break;
        case 2:
        Console.Write("O valor: ");
        num = int.Parse(Console.ReadLine());
        Arvore.Remove(num);
        Sair();
        break;
        case 3:
        bool resultado;
        Console.Write("Valor a ser pesquisado: ");
        num = int.Parse(Console.ReadLine());
        resultado = Arvore.Busca(num);
        Console.WriteLine(resultado);
        Sair();
        break;
        case 4:
        Console.WriteLine("----- Impressão em ordem -----");
        Arvore.emOrdem();
        Sair();
        break;
        case 5:
        Console.WriteLine("----- Impressão em pós ordem -----");
        Arvore.posOrdem();
        Sair();
        break;
        case 6:
        Console.WriteLine("----- Impressão em pré ordem -----");
        Arvore.preOrdem();
        Sair();
        break;
        default:
        break;
        }

        Console.Clear();
        res = mensagem();
        }
        

        static int mensagem(){
            int res;
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("(1) Inserção | (2) Remoção | (3) Buscar valor | (4) Impressão em ordem | (5) Impressão em pós ordem\n(6) Impressão em pré ordem | (7) Sair");
            res = int.Parse(Console.ReadLine());
            return res;
        }

        static void Sair(){
            Console.WriteLine("\nENTER...");
            Console.ReadKey();
        }