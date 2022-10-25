# Documentação Laboratório - Aula 07

### 01 - Modele, projete e calcule a complexidade de um programa que:
**a.** Leia as linhas de um arquivo chamado "arq1.txt".  
**b.** Peça para o usuário inserir um texto no terminal/console.  
**c.** Compare o texto escrito pelo usuário e o texto lido no arquivo, e escreva na tela quantos termos "IGUAIS" e "DIFERENTE".  
**d.** Descreva quais as operações relevantes.   

### 02 - Dado o código a seguir, responda:
![codigoEx2](https://user-images.githubusercontent.com/97108963/197843649-21904d7c-529d-47b1-84e8-899313a555a3.PNG)  
**a.** Quantos e quais são os casos base/condições de parada para a função funcRec1()?  
Resposta: Para essa chamada recursiva, existe apenas uma condição de parada, que retorna 0 caso o número de entrada seja menor ou igual a 1.  
![Ex2](https://user-images.githubusercontent.com/97108963/197845231-f7ec6e4b-5f31-47ef-8381-0b12f6853b7a.PNG)    
**b.** Explique com suas palavras o que a função funcRec1() calcula.  
Resposta: A função se chama recursivamente, passando como parâmetro o valor de entrada subtraído de 2 e somado de 5 quando esse for maior do que 1, a condição de parada nunca será satisfeita nesse caso, já que para isso o número precisa ser menor ou igual a 1, o que leva a um looping infinito até que o compilador não consiga mais executá-lo.  
**Exemplo:** a = 2  
1º chamada recursiva: funcRec1((2-2)+5) ... funcRec1(5)  
2º chamada recursiva: funcRec1((5-2)+5) ... funcRec1(8)  
3º chamada recursiva: funcRec1((8-5)+5) ... funcRec1(11)  
**c.** Represente a pilha de execução para a chamada funcRec1(6).  
Resposta:  
a = 6
1º chamada recursiva: funcRec1((6-2)+5) ... funcRec1(9)   
2º chamada recursiva: funcRec1((9-2)+5) ... funcRec1(12)  
3º chamada recursiva: funcRec1((12-2)+5) ... funcRec1(15)  
4º chamada recursiva: funcRec1((15-2)+5) ... funcRec1(18)  
5º chamada recursiva: funcRec1((18-2)+5) ... funcRec1(21)  
6º chamada recursiva: funcRec1((21-2)+5) ... funcRec1(24)  

### 03 - Modele, projete e calcule a complexidade de um programa que:
**a.** Leia a primeira linha de um arquivo chamado "entrada.txt".  
**b.** Escreva em um arquivo chamado "saida.txt" o conteúdo lido no arquivo de entrada ao contrário.  
**Observações:** considere que o arquivo "entrada.txt" contenha no mínimo uma linha de conteúdo.  
![Ex3](https://user-images.githubusercontent.com/97108963/197834072-bdc2d019-dd73-4302-85ba-8e650a279893.PNG)  
![arqEx3 1](https://user-images.githubusercontent.com/97108963/197834076-a14a6882-f7f1-4be1-b58e-65ad56f0b5b2.PNG)  
![arqEx3 2](https://user-images.githubusercontent.com/97108963/197834078-bc3122fe-f0ac-4267-828a-02980fa6200a.PNG)  
**c.** Descreva quais as operações relevantes.    
Resposta: As operações relevantes são: atribuição, leitura do arquivo e escrita no outro arquivo.  
string linha = sr.ReadLine()  
sw.Write(linha[i])  
Complexidade O(n)  

### 04 - Um banco famoso enfrenta problemas de consulta em seu banco de registros. Dentre os problemas identificados pela gerência está a localização das contas dos seus titulares nas listagens e nos relatórios impressos em diferentes situações. Um especialista de TI sugeriu ordenar as contas por meio dos CPF dos seus n titulares antes das impressões. Dentre alguns algoritmos pré-selecionados para essa ordenação, o especialista escolheu o algoritmo de ordenação por inserção. Se você fosse o especialista, responda:
**a.** O especialista escolheu um bom algoritmo? Justifique.  
Resposta: Não, o algortimo Insertion Sort tem uma complexidade de tempo muito alta: O(n^2), por isso, ele faria várias comparações entre os CPFs, uma vez que o método pega um número e compara com seus antecessores e quando acha valores maiores, os "empurram" para frente e o insere na menor posição disponível. Fazer isso com um CPF de cada vez seria bastante custoso, considerando que a empresa possui vários clientes.  
**b.** Qual algoritmo de ordenação utilizaria?  
Resposta: Merge Sort, pois, o método é mais eficiente por usar a estratégia "dividir para conquistar", com complexidade O(N log N). O processo de ordenação é mais rápido, uma vez que, o vetor com os CPFs dos clientes é dividido sucessivamente em subvetores até que não seja mais possível dividí-lo (Vetor.Length = 1), em seguida esses vetores menores se juntam com outros e são ordenados até que todos os CPFs estejam em ordem crescente. Esse processo de divisão dimunui o processo em partes e dependendo da disposição dos números no vetor, são feitas poucas comparações em relação ao Insertion Sort.  
**c.** Descreva quais as operações relevantes.
Operações relevantes: dividir o vetor ao meio sucessivamente, comparar os números dos subvetores e ordená-los.  
**d.** Demonstre a viabilidade da sua solução para 10 registros.  


### 05 - O código a seguir implementa uma função recursiva. Analise-o e indique o que será retornado plea função, caso os parâmetros possuam os seguintes dados: v = {10, 5, 7, 15, 22, 9, 30} e a = 6.
