# Documentação Laboratório - Aula 09

### 01 - Copiar uma pilha para outra.

![Pilha](https://user-images.githubusercontent.com/97108963/200976349-031b1044-37f7-4c09-9b28-9133c52a20bf.PNG)

**DESCRIÇÃO -** No programa principal há dois vetores de 5 posições declarados, um para a pilha e outro para sua cópia e as duas são imprimidas na tela ao final do programa. A função Remove recebe a pilha e a posição que se deseja remover como parâmetros, ela decrementa a posição e retorna o valor contido nela. A função Insere recebe a pilha, a posição e o número que se deseja inserir como parâmetros, ela atribui à posição(index) o número e incrementa index, pois, ao inserir na pilha vazia, deve-se começar da primeira posição. A função Imprime recebe a pilha como parâmetro e a imprime na tela.  
A função Copiar recebe a pilha e uma posição como parâmetros, nela há dois vetores auxiliares com o número de posições da pilha. Há um laço de repetição que insere em um dos vetores auxiliares(aux) os valores da pilha na sua ordem inversa, uma vez que, a retirada acontece a partir da última posição, o outro laço de repetição insere no outro vetor auxiliar(copia) os valores de aux e assim eles estarão na mesma ordem da pilha, ao final o vetor(copia) é retornado.

---

### 02 - Copiar uma fila para outra ao contrário.

![Fila](https://user-images.githubusercontent.com/97108963/200976352-b670803a-301a-40af-94cc-19c020d5192c.PNG)

**DESCRIÇÃO -** No programa principal há dois vetores de 5 posições declarados, um para a fila e outro para sua cópia e as duas são imprimidas na tela ao final do programa. A função RemoveDaFila recebe a fila como parâmetro, retorna o valor da primeira posição e faz o shift. A função RemoveDaPilha recebe a pilha e a posição que se deseja remover como parâmetros, ao final retorna o valor removido. A função Insere recebe um vetor, a posição e o número que se deseja inserir como parâmetros, ela atribui o valor e incrementa a posição. A função Imprime recebe um vetor como parâmetro e o imprime na tela.  
A função Copiar recebe a fila e uma posição como parâmetros, nela há dois vetores auxiliares com o número de posições da fila. Um laço de repetição é responsável for chamar a função Insere, que preenche o vetor que se comporta como pilha(pilha) com os valores da fila passada como parâmetro, o outro laço também chama a função Insere preenchendo o outro vetor(aux) com os valores de pilha, só que na ordem inversa, pois, na pilha os valores começam a ser retirados da última posição. Ao final aux é retornado.

---

### 03 - Passar uma lista para outra com o dobro do tamanho, com a primeira metade na ordem normal e a segunda metade na ordem inversa.

![Lista](https://user-images.githubusercontent.com/97108963/200976346-4a9ec308-e92b-4a30-a543-20fddebeef16.PNG)

**DESCRIÇÃO -** No programa principal há dois vetores declarados, um com 5 posições e outro com 10, os dois são imprimidos na tela ao final do programa. A função Imprime recebe um vetor como parâmetro e o imprime na tela. A função Remove recebe um vetor e uma posição(pos) como parâmetros, pos é decrementado e o valor da posição que se deseja remover é retornado. A função Remove2 também recebe um vetor e uma posição(pos) como parâmetros, pos é incrementado e o valor da posição que se deseja remover é retornado. A função Insere recebe um vetor, a posição e o número que se deseja inserir como parâmetros, ela atribui o valor e incrementa a posição.  
A função chamada funcao recebe a lista e o tamanho dela como parâmetros, nela há dois vetores auxiliares, um com o número de posições da lista(aux) e o outro com o dobro do tamanho(listaDobrada). Um laço de repetição é responsável por inserir os valores invertidos da lista passada como parâmetro para aux, um segundo laço insere os valores na ordem correta na primeira metade de listaDobrada, o terceiro laço insere os valores de aux na segunda metade de lista dobrada. Dessa forma, a lista terá a primeira metade na ordem normal e a segunda na ordem inversa.
