# Documentação Laboratório - Aula 03

### 01 - Ordenação binária com pos.



**DESCRIÇÃO:**

---

### 02 - Ordenação binária sem pos.



**DESCRIÇÃO:**

---

### 03 - Pesquisa binária com pos.

![cod3](https://user-images.githubusercontent.com/97108963/190245427-abd58d08-1891-49a7-8fa6-14a5addb2020.PNG)
![res3](https://user-images.githubusercontent.com/97108963/190245434-c3cc84d7-ef78-440e-9387-788794d8ef23.PNG)

**DESCRIÇÃO:** A pesquisa binária foi implementada por meio de uma função recursiva que recebe como parâmetros o vetor, suas posições de início, fim e o valor que se deseja procurar. Primeiramente, é declarada uma variável para controlar a posição do meio a cada iteração, em seguida há uma estrutura condicional que verifica se o valor na posição do meio é igual, maior ou menor ao valor pesquisado pelo usuário. Dessa forma, existem três casos:
. Igual: a posição é atribuída a uma variável chamada 'pos' e seu valor é retornado para o programa principal;
. Menor: o algoritmo passa a analisar apenas os valores à direita do meio, uma vez que, à sua esquerda os valores são todos menores e então, temos certeza que o número pesquisado não estará lá.
. Maior: o algoritmo passa a analisar apenas os valores à esquerda do meio, uma vez que, à sua direita os valores são todos maiores e então, temos certeza que o número pesquisado não estará lá.
A função repete esse processo passando valores diferentes para as posições de início e fim e assim, em algum momento o número poderá ser encontrado e sua posição será retornada ao programa principal, caso não seja encontrado a função retorna o valor -1. No programa principal foi declarado um vetor ordenado, uma mensagem para o usuário entrar com o número que ele deseja pesquisar, a chamada da função e uma variável que recebe o seu valor de retorno e por fim, uma estrutura condicional que dependendo do valor de retorno da função exibe mensagens diferentes. Para o valor -1, exibe uma mensagem de que o número pesquisado não existe no vetor, para um valor diferente disso exibe a posição em que o número se encontra.

---

### 04 - Pesquisa binária sem pos.

![cod4](https://user-images.githubusercontent.com/97108963/190245433-9ae558bc-0dae-4185-a6e2-3d1dc0293671.PNG)
![res4](https://user-images.githubusercontent.com/97108963/190245435-2bcb1b3e-6d81-4ee9-8cc5-79031e01779b.PNG)

**DESCRIÇÃO:** A pesquisa binária foi implementada por meio de uma função recursiva que recebe como parâmetros o vetor, suas posições de início, fim e o valor que se deseja procurar. Primeiramente, é declarada uma variável para controlar a posição do meio a cada iteração, em seguida há uma estrutura condicional que verifica se o valor na posição do meio é igual, maior ou menor ao valor pesquisado pelo usuário. Dessa forma, existem três casos:
. Igual: a posição é retornada para o programa principal;
. Menor: o algoritmo passa a analisar apenas os valores à direita do meio, uma vez que, à sua esquerda os valores são todos menores e então, temos certeza que o número pesquisado não estará lá.
. Maior: o algoritmo passa a analisar apenas os valores à esquerda do meio, uma vez que, à sua direita os valores são todos maiores e então, temos certeza que o número pesquisado não estará lá.
A função repete esse processo passando valores diferentes para as posições de início e fim e assim, em algum momento o número poderá ser encontrado e sua posição será retornada ao programa principal, caso não seja encontrado a função retorna o valor -1. No programa principal foi declarado um vetor ordenado, uma mensagem para o usuário entrar com o número que ele deseja pesquisar, a chamada da função e uma variável que recebe o seu valor de retorno e por fim, uma estrutura condicional que dependendo do valor de retorno da função exibe mensagens diferentes. Para o valor -1, exibe uma mensagem de que o número pesquisado não existe no vetor, para um valor diferente disso exibe a posição em que o número se encontra.

---

### 05 - Contador de comparações.

![ex5](https://user-images.githubusercontent.com/97108963/194961855-8347d4ec-711a-4900-96e0-069b4e3b16d3.PNG)

**DESCRIÇÃO:** Em um algoritmo as comparações são feitas nas estruturas 'if' e 'else if'. O código possui 4 estruturas condicionais e por isso, o contador é incrementado de 4 vezes ao final, sendo que o valor correspondente à variável i é comparado em todas essas estruturas e entrará apenas em uma (caso médio). Caso seja atribuído diferentes valores para i, no pior caso a variável será comparada todas as vezes e o resultado será falso em todas elas.
