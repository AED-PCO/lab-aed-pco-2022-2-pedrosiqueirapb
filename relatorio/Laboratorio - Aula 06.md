# Documentação Laboratório - Aula 06

### 01 - Bubble Sort

![resBubbleSort](https://user-images.githubusercontent.com/97108963/192040729-46427031-aed0-407d-ab2f-402abdf7def5.PNG)
![conBubbleSort](https://user-images.githubusercontent.com/97108963/192040736-21c87f42-3b22-4b33-97a5-2dd738044ea2.PNG)

* Primeiramente, o método Random é usado para atribuir números aleatórios às posições do vetor. O método de ordenação Bubble Sort foi implementado por meio de uma função, ela recebe como parâmetro o vetor a ser ordenado e nela está contida dois laços de repetição (for), o primeiro percorre todas as posições do vetor e o segundo até a penúltima posição. Dentro do segundo laço há uma estrutura condicional que verifica se o valor da posição correspondente a j do vetor é maior do que seu sucessor, caso essa condição seja verdadeira os valores são trocados. A função realiza esse processo até que todo vetor esteja ordenado.

---

### 02 - Selection Sort

![resSelectionSort](https://user-images.githubusercontent.com/97108963/192040734-7cd975e8-c7ae-4e3a-9c7c-890302992680.PNG)
![conSelectionSort](https://user-images.githubusercontent.com/97108963/192040741-5c8bcefa-57a9-4daf-97b2-c1a21900da2a.PNG)

* O método de ordenação Selection Sort foi implementado por meio de uma função que recebe como parâmetro o vetor a ser ordenado, nela existem dois laços de repetição (for), o primeiro percorre o vetor até a penúltima posição e o segundo até a última, uma vez que a sua variável de controle está sempre uma posição a frente. Após o primeiro laço é declarada uma variável que guarda o índice do menor valor, dentro do segundo laço há uma estrutura condicional que busca no vetor o menor valor e atribui a sua posição à variável responsável por guardar esse índice, ao final do segundo laço há uma estrutura condicional que coloca o menor valor na menor posição disponível. A função realiza esse processo até que todo vetor esteja ordenado. No programa principal, o método Random atribui números aleatórios para as posições do vetor, após a chamada da função o vetor ordenado é printado na tela.

---

### 03 - Insertion Sort

![resInsertionSort](https://user-images.githubusercontent.com/97108963/192040733-3534e6ba-a1d4-4a00-9ad4-55a0710bf9c6.PNG)
![conInsertionSort](https://user-images.githubusercontent.com/97108963/192040738-edec2a57-1970-4617-a5cc-ceae47be55e2.PNG)

* O método de ordenação Insertion Sort foi implementado por meio de uma função que recebe como parâmetro o vetor a ser ordenado, nela existem dois laços de repetição (for e while), o primeiro laço percorre o vetor a partir da segunda posição até a última e após o seu início, a variável auxiliar recebe o valor da posição i correspondente e a variável j recebe o índice anterior à i, pois ela controla os antecessores de Vetor[i]. O segundo laço executa a troca dos valores caso necessário e a variável j é decrementada até que o laço termine, após seu final a primeira posição recebe o menor valor disponível, a função realiza esse processo até que todo vetor esteja ordenado. No programa principal, o método Random atribui números aleatórios para as posições do vetor, após a chamada da função o vetor ordenado é printado na tela.

---

### 04 - Merge Sort

![ex4.1](https://user-images.githubusercontent.com/97108963/194929667-981074bb-18c1-4ff1-a70d-2a8cbd90d439.PNG)
![ex4.2](https://user-images.githubusercontent.com/97108963/194929668-74303104-249f-44de-86ff-7f92943698b9.PNG)
![Terminal](https://user-images.githubusercontent.com/97108963/194929660-bc82d32b-1e1b-4eb8-901e-7737e9f4a2a3.PNG)

* O método de ordenação Merge Sort foi implementado por meio de duas funções, sendo uma delas recursiva, a função a ser chamada no programa principal (MergeSort) recebe como parâmetros o vetor a ser ordenado e os índices de início e fim, dentro dela há uma estrutura condicional que atribui à variável que controla a posição do meio o seu valor correspondente e então, a função chama a si mesma duas vezes até que o vetor tenha apenas uma posição, a fim de ordenar os valores à esquerda do meio e à sua direita, em seguida a segunda função é chamada recebendo como parâmetros o vetor e as posições de início, meio e fim. Na segunda função (Merge) é feita a ordenação dos valores nos subvetores e a junção deles, colocando-os no vetor principal até que ele esteja completamente ordenado. No programa principal, o método Random atribui números aleatórios para as posições do vetor, após a chamada da função o vetor ordenado é printado na tela.

---

### 05 - Quick Sort

![ex5.1](https://user-images.githubusercontent.com/97108963/194929837-a35970e9-67e9-42e3-8e43-799afa5f56ec.PNG)
![ex5.2](https://user-images.githubusercontent.com/97108963/194929838-a7e91f75-49c9-456c-bbba-c1d373e0fd47.PNG)
![Terminal](https://user-images.githubusercontent.com/97108963/194929835-bdabafb0-21cc-4004-b27f-e8e292bcc8aa.PNG)

* No programa principal, o método Random atribui números aleatórios para as posições do vetor, após a chamada da função o vetor ordenado é printado na tela. O método de ordenação Quick Sort foi implementado por meio de uma função que recebe como parâmetros o vetor a ser ordenado e as posições de início e fim, nela são declaradas 3 variáveis: 'pivo' que determina o valor usado como referência, 'i' que controla as posições menores que o pivô e 'j' que controla as maiores. Por meio de uma estrutura condicional são realizadas as trocas necessárias, passando os valores menores que o pivô à sua esquerda e os maiores à direita. Durante o processo o pivô assume diferentes valores e assim, o vetor é ordenado.

---

### 06 - Shell Sort

![ex6](https://user-images.githubusercontent.com/97108963/194930005-ecc674bf-e9eb-454b-a50c-f77824a9b0ba.PNG)
![Terminal](https://user-images.githubusercontent.com/97108963/194930007-bd67db9b-7b37-4947-892b-dc9786d91c91.PNG)

* No programa principal, o método Random atribui números aleatórios para as posições do vetor, após a chamada da função o vetor ordenado é printado na tela. O método de ordenação Shell Sort foi implementado por meio de uma função que recebe como parâmetros o vetor a ser ordenado e o seu tamanho, nela é declarada a variável 'h' que primeiramente recebe (Vetor.Length / 2) e a cada iteração esse valor é dividido por 2 até que chegue em 1, há três laços de repetição (2 for's e while), sendo que a estrutura while é responsável por comparar um valor com outro 'h' posições à sua frente e caso necessário a troca é feita. Esse processo se repete até que todo o vetor esteja ordenado.

---

### 07 - Counting Sort

![ex7.1](https://user-images.githubusercontent.com/97108963/195233259-3abd5768-ef96-4e0b-be47-59ea9a1f51b9.PNG)
![ex7.2](https://user-images.githubusercontent.com/97108963/195233264-6dbeaf8d-9ba9-4042-a32c-757052dc4ef6.PNG)
![ex7.3](https://user-images.githubusercontent.com/97108963/195233254-a9275d01-a466-483c-b788-5b90221a7ad5.PNG)

* Primeiramente, foi criada uma função que retorna o maior número do vetor (MaiorValor). O método de ordenação Counting Sort foi implementado por meio de uma função que recebe como parâmetro o vetor a ser ordenado, nela a função MaiorValor é chamada e é criado um vetor auxiliar que contará a quantidade de ocorrências dos números do vetor principal. Todas as posições do vetor auxiliar são zeradas para começar a contagem, em seguida um laço de repetição é responsável por incrementar +1 na posição correspondente a cada vez que o número aparece no vetor principal, o terceiro laço é responsável por inserir os números nas posições corretas.
