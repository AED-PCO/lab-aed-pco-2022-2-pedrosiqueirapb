# Documentação Laboratório - Aula 02

### **01** - Escreva um método recursivo que retorne o fatorial de um número.

![Resolucao ex-1](https://user-images.githubusercontent.com/97108963/186972076-7f8a0fd5-7bfe-4369-843f-2f8c1d6471ba.PNG)
![Resposta ex-1](https://user-images.githubusercontent.com/97108963/186972088-6c78191f-3cf0-4a00-8459-1acc333ff23c.PNG)

**DESCRIÇÃO -** A função recebe como parâmetro o número (n) que se deseja calcular o fatorial, dentro dela há uma variável (*res*) que multiplica o número pela chamada da função, que dessa vez recebe o número subtraído de 1 (a fim de percorrer os seus antecessores), isso é feito até uma condição de parada em que n seja igual a 2, pois não é necessário multiplicar pelo número 1, então o fatorial do número é retornado para a variável *f* (função) no programa principal e seu resultado é exibido na tela.

---

### **02** - Uma multiplicação pode ser vista como uma sequência de somas. Escreva um método recursivo que realize a multiplicação de dois números inteiros, A e B, recebidos por parâmetro.

![Resolucao ex-2](https://user-images.githubusercontent.com/97108963/186972078-0bb11a1e-35a5-486f-a28c-56136b9f3f64.PNG)
![Resposta ex-2](https://user-images.githubusercontent.com/97108963/186972089-b3b2a34b-b6aa-4bd9-a406-6ec049699662.PNG)

**DESCRIÇÃO -** A função recebe o multiplicando (x) e o multiplicador (y) como parâmetros, dentro dela há uma condição que retorna o valor do multiplicando caso o multiplicador seja igual a 1, pois todo número multiplicado por 1 é ele mesmo, outra condiçaõ verifica se algum dos dois termos é igual a 0 e retorna 0, pois todo número multiplicado por zero é zero. Se esses casos não forem verdadeiros, a função retorna o valor de x mais a chamada da função passando como parâmetros x e y menos 1, isso acontece pois o valor do multiplicando deve ser mantido para calcular a soma e o valor do multiplicador deve ser diminuído a cada vez que a soma é calculada, até chegar na condição de parada em que y vale 1.

---

### **03** - Escreva um método recursivo que realize a potenciação entre dois números inteiros, A e B, recebidos por parâmetro. Seu método deve, portanto, retornar o resultado de A^B.

![Resolucao ex-3](https://user-images.githubusercontent.com/97108963/186972082-f683e0b8-46cd-4546-a1d8-99543620be09.PNG)
![Resposta ex-3](https://user-images.githubusercontent.com/97108963/186972092-286a2cda-5719-4897-b0d3-8f91daa61375.PNG)

**DESCRIÇÃO -** A função recebe a base (A) e o expoente (B) como parâmetros, nela há um retorno do valor da base vezes a chamada da função, que dessa vez recebe como parâmetros os valores de A e B menos 1, pois o expoente é a quantidade de vezes que a base será multiplicada e essa quantidade precisa diminuir a cada repetição até chegar ao 1. Para isso, há uma condição que retorna A caso B seja igual a 1 (todo número elevado a 1 é ele mesmo) e outra que retorna 1 caso B seja igual a 0 (todo número elevado a 0 é igual a 1).

---

### **04** - Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase.

![Resolucao ex-4](https://user-images.githubusercontent.com/97108963/186972083-05492acb-2944-4199-a7bd-6eea1bb91807.PNG)
![Resposta ex-4](https://user-images.githubusercontent.com/97108963/186972094-63ef55bc-bd04-43d4-9750-88845345a3fa.PNG)

**DESCRIÇÃO -** A função recebe como parâmetros a frase digitada pelo usuário (Frase) e a letra (Letra) que deseja-se saber a quantidade de ocorrências dela na frase. Há uma condição de parada que retorna 0 caso não exista caracteres na frase, caso isso seja falso, há uma outra condição de parada que verifica se o caractere da frase na posição 0 (string é um vetor de caracteres) é igual à Letra, se isso for verdadeiro, a função é retornada passando a letra e a frase com o método SubString(1) como parâmetros, somada de 1 (que funciona como um contador de caracteres se a letra for encontrada). Caso a letra não seja encontrada, a função é retornada através de outra condição de parada, isso é feito até que todas as posições sejam percorridas.

---

### **05** - Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.

![Resolucao ex-5](https://user-images.githubusercontent.com/97108963/186998537-50113c08-6a1b-4a0c-b048-fbf334579571.PNG)
![Resposta ex-5](https://user-images.githubusercontent.com/97108963/186972095-c673c1a8-8c03-4609-af66-3145e44c181c.PNG)
![Resposta ex-5](https://user-images.githubusercontent.com/97108963/186972096-eaf42290-6817-4f47-a7a6-ba5f1d8746fb.PNG)

**DESCRIÇÃO -** A função recebe como parâmetros o vetor e o seu número de posições subtraído de 1 (o vetor começa na posição 0 e por isso, sua última posição é o seu tamanho menos 1), há uma condição de parada que retorna 0 se o tamanho do vetor for igual a -1, pois, caso isso aconteça o vetor já foi percorrido e caso seja colocado um número par na posição 0, ele será somado (e não será retornado 0). Em baixo há outra condição para o caso do valor na posição ser ímpar (independente se for negativo ou positivo), se o valor for ímpar a função é retornada (subtraindo a posição *i* em -1), pois, não se deseja somar os valores ímpares. A partir do momento que essas condições forem falsas, há uma outra condição em que o número só entra se for par, quando isso acontece há o retorno da soma do valor na posição correspondente mais a chamada da função (subtraindo *i* menos 1). Dessa forma, cria-se um looping que só acaba quando todos os valores do vetor forem percorridos.

---

### **06** - Escreva um método recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal.

![Resolucao ex-6](https://user-images.githubusercontent.com/97108963/186996096-be73d145-744d-498a-829c-39452ccd8b64.PNG)
![Resposta ex-6](https://user-images.githubusercontent.com/97108963/186972070-c944497b-42c7-4cb6-9a00-c7ae1aeb0ea6.PNG)

**DESCRIÇÃO -** A função recebe a frase digitada pelo usuário como parâmetro e Frase.Length subtraído de 1, pois, a frase é um vetor de caracteres e sua primeira posição é 0, fazendo com que a última seja o tamanho da frase menos 1. Há na função uma condição que retorna a frase caso o seu tamanho seja 0 (isso acontece, pois, se não há nada escrito, não há vogais que possam ser retiradas), se essa condição for falsa a variável *semVogal* retira as vogais da frase através do método Replace(), que substitui as vogais por um espaço vazio, em seguida a função é chamada novamente passando como parâmetros a variável *semVogal* e o tamanho da frase subtraído de 1, para que a cada chamada seja percorrido uma posição da string, até a posição 0.

---

### **07** - Escreva um método recursivo que receba como parâmetro a posição que se deseja saber da Sequência de Fibonacci.

![Resolucao ex-7](https://user-images.githubusercontent.com/97108963/187046371-a10f62cc-bab0-498a-bf93-f6a8e67ceb29.PNG)
![Resposta ex-7](https://user-images.githubusercontent.com/97108963/187046372-626523ea-95e2-4a47-bbf4-d52b443b44e3.PNG)

**DESCRIÇÃO -** A função recebe a posição que se deseja saber o valor na Sequência de Fibonacci, se a posição for a 1º o programa retorna o valor 0 e se for a 2º retorna 1 (esses são os dois primeiros valores da sequência por padrão). Caso a posição seja outra, o programa retorna a soma da função pela própria função, sendo que em uma a passagem de parâmetros é feita pela posição subtraída de 1 e na outra a posição é subtraída de 2, isso acontece, pois, um número na Sequência de Fibonacci é o resultado da soma de seus dois números anteriores.
