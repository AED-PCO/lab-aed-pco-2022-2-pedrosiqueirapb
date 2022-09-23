# Documentação Laboratório - Aula 01

### 01 - Alguns números de quatro algarismos possuem uma característica particular. Se separamos esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
### Número = 3025 
### Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
### A soma de 30 com 25 é igual a 55
### O Quadrado de 55 é igual a 3025.
### Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.

![Resolucao ex-1](https://user-images.githubusercontent.com/97108963/186971832-86c83a04-a1c3-4cc7-9bc1-c2fac97fb336.PNG)
![Resposta ex-1](https://user-images.githubusercontent.com/97108963/186971851-e212604e-dd90-4d79-b9a1-a9dc1436c028.PNG)

**DESCRIÇÃO:** Foi criado um laço de repetição que percorresse do número 1000 ao 9999, dentro dele foram criadas duas variáveis: uma para guardar os dois primeiros algarismos do número (parte inteira após dividir por 100) e outra para pegar o resto da divisão por 100, que seriam os dois últimos algarismos. Em baixo foi feita uma condição, se o número for igual à sua parte inteira mais o resto elevado ao quadrado, então ele apareceria na tela.

---

### 02 - Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras palavras, um Número Primo possui dois divisores de 1 até ele. Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é Primo.
### Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6. Faça um programa que liste os números perfeitos de 1 a 1000.

![Resolucao ex-2a](https://user-images.githubusercontent.com/97108963/186971834-397c5d7b-2ed5-448f-b51e-d00569333784.PNG)
![Resposta ex-2a](https://user-images.githubusercontent.com/97108963/186971852-6d2b717e-da30-4c18-91b8-aa2e5f8f7b37.PNG)

**DESCRIÇÃO -** No começo do programa deve-se entrar com um número (*n*) para verificar se ele é primo ou não. Em baixo foi criado um laço de repetição que começa do um e vai até o número (*n*) que foi inserido, dentro dele há uma condição que verifica se a divisão de *n* pelos menores ou igual a ele corresponde a 0, caso seja verdade, a variável *div* (divisores) é incrementada de um número, pois sua função é calcular o número de divisores de *n*. Fora do laço outra comando condicional escreve se o número é primo ou não na tela, ele será primo quando a variável *div* foi igual a 2 (o próprio número e o 1). 

![Resolucao ex-2b](https://user-images.githubusercontent.com/97108963/186971835-b6faf214-d300-4be8-a176-27c38cd4f447.PNG)
![Resposta ex-2b](https://user-images.githubusercontent.com/97108963/186971853-d4471fbb-0052-4db9-b325-a06829468ffe.PNG)

**DESCRIÇÃO -** Foi criado um laço de repetição dentro de outro: o primeiro percorre do número 1 ao 1000 (*i*), o segundo (*j*) percorre do número 1 até o número anterior ao que foi "setado" pelo primeiro laço (*i*), dentro dele há uma condição que verifica se o resto da divisão entre *i* e *j* é igual a 0 (pois, isso comprova se um número é divisível pelo outro), caso seja verdadeiro a variável somaDiv (que faz a soma dos divisores) é somada ao divisor (*j*).
Logo em seguida há outra condição que verifica se a soma dos divisores é igual ao número e se for ele aparecerá na tela.

---

### 03 - Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. Considere que nenhum dos vetores possui elementos repetidos.
### Crie um vetor resultante C que possua os elementos comuns entre A e B.
### Crie um vetor resultante D que contenha os elementos de A que não existam em B.

![Resolucao ex-3](https://user-images.githubusercontent.com/97108963/186971837-13489216-aaae-4d09-8286-87de1a430237.PNG)
![Resposta ex-3](https://user-images.githubusercontent.com/97108963/186971859-ab535553-1d53-48c1-81d1-547fb452ebd4.PNG)

**DESCRIÇÃO -** Para o vetor C há um laço de repetição (*i*) que percorre os valores de cada posição dos vetores A e B, dentro dele há uma condição que verifica se o valor do vetor A na posição que corresponde ao valor de *i* (vetor[i]) é igual em pelo menos uma das 6 posições de B (0 à 5), para isso é utilizado o operador "ou" (||), caso seja igual, o vetor C receberá o valor do vetor A na posição *i* correspondente. Para o vetor D foi usada uma estrutura parecida, porém, a condição verificava se o valor do vetor A na posição *i* era diferente de todas as posições de B, para isso são usados os operadores != (que verifica se há diferença) e && (que analisa se todas as condições impostas são verdadeiras), dessa forma, o vetor D recebe o valor do vetor A na posição *i* correspondente.

---

### 04 - Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

![Resolucao ex-4](https://user-images.githubusercontent.com/97108963/186971840-86e689f1-aa00-4a0f-b576-77914dc03191.PNG)
![Resolucao ex-4](https://user-images.githubusercontent.com/97108963/186971844-9830aa5e-1fdb-4f14-8a52-9e8cc7669d7f.PNG)
![Resposta ex-4](https://user-images.githubusercontent.com/97108963/186971860-2e937dab-ce10-44a6-a5af-a31eb8b8be85.PNG)

**DESCRIÇÃO -** Foram criados dois laços de repetição para preencher os valores da matriz (um percorre as linhas e outro as colunas). Em baixo foram criados mais dois laços de repetição e variáveis para cada linha e cada coluna, a fim de calcular a soma de seus valores, dentro deles há duas estruturas de escolha (Switch - case), uma pega o número da linhas (*i*) e soma os seus valores (atráves da variável de soma específica para aquela linha) e outra pega o número da coluna (*j*) e soma os seus valores (atráves da variável de soma específica para aquela coluna). Esse laço é feito até que toda a matriz seja percorrida e após o seu fim, as somas aparecem na tela.

---

### 05 - Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.

![Resolucao ex-5](https://user-images.githubusercontent.com/97108963/186971849-e4898a6c-5e0c-440a-8917-85609647e67b.PNG)
![Resposta ex-5](https://user-images.githubusercontent.com/97108963/186971861-fa4e5031-3328-4c8e-a8c4-7ac7f4f173d7.PNG)

**DESCRIÇÃO -** A função recebe como parâmetro o número (numero) que se deseja saber o fatorial, é criada uma variável *fat* (fatorial) que recebe o valor 1. Em baixo há um laço de repetição que começa do valor correspondente ao parâmetro numero e vai até o 1, pois, o fatorial é a multiplicação de um número pelos seus antecessores até o 1, nesse caso a variável *fat* é quem faz o cálculo, recebendo o valor de sua multiplicação pelo número e logo em seguida os seus antecessores, até que o laço acabe. Dessa forma, o valor do fatorial do número é exibido na tela.

---

### 06 - Faça um programa que chame uma função capaz de calcular x^y, sendo x e y inteiros. Utilize passagem de parâmetros por referência.

![Resolucao ex-6](https://user-images.githubusercontent.com/97108963/186971850-c087a9ef-6a92-4c5e-adb1-51f8d4b41900.PNG)
![Resposta ex-6](https://user-images.githubusercontent.com/97108963/186971829-ddcdb559-b2df-484c-b1d7-f264bd30bf2c.PNG)

**DESCRIÇÃO -** A função recebe como parâmetros o valor da base e do expoente que são digitados pelo usuário, dentro dela o método Math.Pow() calcula a potência entre os dois números e retorna para a variável *f* (função) no programa principal o seu valor que então, é exibido na tela.
