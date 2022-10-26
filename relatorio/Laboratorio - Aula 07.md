# Documentação Laboratório - Aula 07

### 01 - Modele, projete e calcule a complexidade de um programa que:
**a.** Leia as linhas de um arquivo chamado "arq1.txt".  
**b.** Peça para o usuário inserir um texto no terminal/console.  
**c.** Compare o texto escrito pelo usuário e o texto lido no arquivo, e escreva na tela quantos termos "IGUAIS" e "DIFERENTE".

![Ex1](https://user-images.githubusercontent.com/97108963/198106486-4d5eeabf-91f3-4b68-9d91-14a9c5efbfd1.PNG)  
![Ex1](https://user-images.githubusercontent.com/97108963/198106569-276bd8e8-856c-4e4e-b7e8-38d359a34715.PNG)  
![Ex1](https://user-images.githubusercontent.com/97108963/198107313-64d1dda8-a1e5-47db-be70-57d57212b92c.PNG)  
**d.** Descreva quais as operações relevantes.  
**Resposta:** As operações relevantes são: atribuições, comparações, leitura do arquivo e a criação de dois vetores. A complexidade do algoritmo é O(n^2).

### 02 - Dado o código a seguir, responda:
![Ex2](https://user-images.githubusercontent.com/97108963/197843649-21904d7c-529d-47b1-84e8-899313a555a3.PNG)  
**a.** Quantos e quais são os casos base/condições de parada para a função funcRec1()?  
**Resposta:** Para essa chamada recursiva, existe apenas uma condição de parada, que retorna 0 caso o número de entrada seja menor ou igual a 1. A partir disso, as chamadas são desempilhadas.  
![Ex2](https://user-images.githubusercontent.com/97108963/197845231-f7ec6e4b-5f31-47ef-8381-0b12f6853b7a.PNG)

**b.** Explique com suas palavras o que a função funcRec1() calcula.  
**Resposta:** A função se chama recursivamente, passando como parâmetro o valor de entrada subtraído de 2 e somado de 5 quando esse for maior do que 1, a condição de parada nunca será satisfeita nesse caso, já que para isso o número precisa ser menor ou igual a 1, o que leva a um looping infinito até que o compilador não consiga mais executá-lo.  
**Exemplo:** a = 2  
1º chamada recursiva: funcRec1((2-2)+5) ... funcRec1(5)  
2º chamada recursiva: funcRec1((5-2)+5) ... funcRec1(8)  
3º chamada recursiva: funcRec1((8-5)+5) ... funcRec1(11)  
**Execução do código:**  
![Ex2](https://user-images.githubusercontent.com/97108963/198042500-fe0863cc-5038-42e8-8080-4408c8568cb2.PNG)  
![Ex2](https://user-images.githubusercontent.com/97108963/198042497-2a74d32b-a12c-41a8-a87a-af0091d3bc5d.PNG)

**c.** Represente a pilha de execução para a chamada funcRec1(6).  
**Resposta:**  
a = 6  
1º chamada recursiva: funcRec1((6-2)+5) ... funcRec1(9)   
2º chamada recursiva: funcRec1((9-2)+5) ... funcRec1(12)  
3º chamada recursiva: funcRec1((12-2)+5) ... funcRec1(15)  
4º chamada recursiva: funcRec1((15-2)+5) ... funcRec1(18)  
5º chamada recursiva: funcRec1((18-2)+5) ... funcRec1(21)  
6º chamada recursiva: funcRec1((21-2)+5) ... funcRec1(24)  

![Ex2](https://user-images.githubusercontent.com/97108963/198102727-661eacbd-9e4a-4173-bd05-209008847ded.PNG)  

### 03 - Modele, projete e calcule a complexidade de um programa que:
**a.** Leia a primeira linha de um arquivo chamado "entrada.txt".  
**b.** Escreva em um arquivo chamado "saida.txt" o conteúdo lido no arquivo de entrada ao contrário.  
**Observações:** considere que o arquivo "entrada.txt" contenha no mínimo uma linha de conteúdo.

![Ex3](https://user-images.githubusercontent.com/97108963/197834072-bdc2d019-dd73-4302-85ba-8e650a279893.PNG)  
![arqEx3 1](https://user-images.githubusercontent.com/97108963/197834076-a14a6882-f7f1-4be1-b58e-65ad56f0b5b2.PNG)  
![arqEx3 2](https://user-images.githubusercontent.com/97108963/197834078-bc3122fe-f0ac-4267-828a-02980fa6200a.PNG)  
**c.** Descreva quais as operações relevantes.    
**Resposta:** As operações relevantes são: atribuição, leitura do arquivo e escrita no outro arquivo.   
string linha = sr.ReadLine()  
sw.Write(linha[i])  
A complexidade do algoritmo é O(n).  

![Ex3](https://user-images.githubusercontent.com/97108963/198102722-612b6940-9049-48f1-83bb-0ba5ca42f6d9.PNG)  

### 04 - Um banco famoso enfrenta problemas de consulta em seu banco de registros. Dentre os problemas identificados pela gerência está a localização das contas dos seus titulares nas listagens e nos relatórios impressos em diferentes situações. Um especialista de TI sugeriu ordenar as contas por meio dos CPF dos seus n titulares antes das impressões. Dentre alguns algoritmos pré-selecionados para essa ordenação, o especialista escolheu o algoritmo de ordenação por inserção. Se você fosse o especialista, responda:
**a.** O especialista escolheu um bom algoritmo? Justifique.  
**Resposta:** Não, o algortimo Insertion Sort tem uma complexidade de tempo muito alta: O(n^2), por isso, ele faria várias comparações entre os CPFs, uma vez que o método pega um número e compara com seus antecessores e quando acha valores maiores, os "empurram" para frente e o insere na menor posição disponível. Fazer isso com um CPF de cada vez seria bastante custoso, considerando que a empresa possui vários clientes.  
**b.** Qual algoritmo de ordenação utilizaria?  
**Resposta:** Merge Sort, pois, o método é mais eficiente por usar a estratégia "dividir para conquistar", com complexidade O(N log N). O processo de ordenação é mais rápido, uma vez que, o vetor com os CPFs dos clientes é dividido sucessivamente em subvetores até que não seja mais possível dividí-lo (Vetor.Length = 1), em seguida esses vetores menores se juntam com outros e são ordenados até que todos os CPFs estejam em ordem crescente. Esse processo de divisão dimunui o processo em partes e dependendo da disposição dos números no vetor, são feitas poucas comparações em relação ao Insertion Sort.  
**c.** Descreva quais as operações relevantes.  
**Resposta:** As operações relevantes são de dividir o vetor ao meio sucessivamente, comparar os números dos subvetores e ordená-los.  
**d.** Demonstre a viabilidade da sua solução para 10 registros.  
**Resposta:** Para 50000 registros o tempo de execução foi de 01:43. Segue abaixo a solução para 10 registros:

![Ex4](https://user-images.githubusercontent.com/97108963/198063908-35875572-f410-4d45-9192-091fc4fcb004.png)  
![Ex4](https://user-images.githubusercontent.com/97108963/198062923-26c059e4-6e47-4018-8ee2-e675b48ff193.PNG)  
![Ex4](https://user-images.githubusercontent.com/97108963/198062925-546a5cb8-7d73-440b-aee0-5981e78ee756.PNG)  

### 05 - O código a seguir implementa uma função recursiva. Analise-o e indique o que será retornado pela função, caso os parâmetros possuam os seguintes dados: v = {10, 5, 7, 15, 22, 9, 30} e a = 6.
![Ex5](https://user-images.githubusercontent.com/97108963/198041848-d4078d3a-e3eb-4ebd-b210-c503cc847558.PNG)  
**Resposta:** A função recursiva se chama até a = 1, a partir daí, as chamadas serão desempilhadas e quando entrarem na estrutura condicional abaixo da chamada da função, ela retornará o número 22, que está na posição 4 do vetor.

![Ex5](https://user-images.githubusercontent.com/97108963/198055123-151b64a7-9339-4a6e-9084-5dbd1bb06e68.PNG)  

