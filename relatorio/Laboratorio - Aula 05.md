# Documentação Laboratório - Aula 05

![ex1](https://user-images.githubusercontent.com/97108963/190524596-5bbde9ce-db2d-4317-91ed-041680ebecd9.PNG)

### 01 - Operação mais relevante:
    A operação mais relevante é res = res * i

### 02 - Operações marcadas:
    i--
    res = res * i
    return res
    
### 03 - Sequências e laços:
    A sequência do algoritmo é: uma atribuição, um laço de repetição que executa uma multiplicação n vezes, retorno do resultado da operação.
    Laço de repetição (for), que começa em n e é decrementado até 2, dentro dele há uma operação para calcular o fatorial de n. Complexidade O(n) para o pior caso.

### 04 - Variação de casos:
    Sem variação de casos.

---

![ex2](https://user-images.githubusercontent.com/97108963/190524140-440b2e79-4200-4c87-b855-ec2cc9b82133.PNG)

### 01 - Operação mais relevante:
    A operação mais relevante é if(arr[i] == x)

### 02 - Operações marcadas:
    i++
    return x
    return -1
    if(arr[i] == x)

### 03 - Sequências e laços:
    A sequência do algoritmo é: um laço de repetição que percorre os valores de um vetor, nele está contido uma estrutura de condição que retorna um valor caso essa condição seja verdadeira, a quantidade de comparações é determinada pelo valor atribuído a x e às posições do vetor. Ao final é retornado o valor -1.
    Laço de repetição (for), que começa em 0 e é incrementado até arr.Length-1, dentro dele há uma estrutura condicional. Complexidade O(n), sendo n o tamanho do vetor. No pior caso, x não estará no vetor.

### 04 - Variação de casos:
    Há variações de casos, os valores de entrada e a estrutura condicional serão determinantes para definir a complexidade e a saída do algoritmo.

---

![ex3](https://user-images.githubusercontent.com/97108963/190524141-117555d3-740a-4b57-b189-736cd5d71e05.PNG)

### 01 - Operação mais relevante:
    A operação mais relevante é res[pos] += arr1[pos]/arr1[j]

### 02 - Operações marcadas:
    pos++
    j++
    res[pos] += arr1[pos]/arr1[j]
    if(j != pos)
    return res

### 03 - Sequências e laços:
    A sequência do algoritmo é: um laço de repetição que está contido dentro do outro, sendo que os dois percorrem as posições de um vetor. Dentro do segundo laço há uma condição que executa uma operação caso pos != j. Ao final o resultado da operação é retornado.
    Dois laços de repetição (for), que começam em 0 e são incrementados até arr1.Length-1, dentro do segundo laço há uma estrutura condicional. Complexidade O(n^2) para o pior caso, sendo n o tamanho do vetor. O número de comparações dependerá do tamanho do vetor.

### 04 - Variação de casos:
    Sem variação de casos.

---

![ex4](https://user-images.githubusercontent.com/97108963/190524135-74eb4692-a91e-4a81-b5d2-3851d08b2a94.PNG)

### 01 - Operação mais relevante:
    A operação mais relevante é vet[i] = soma/(i+1)

### 02 - Operações marcadas:
    i++
    j++
    soma += dados[j]
    vet[i] = soma/(i+1)
    return vet

### 03 - Sequências e laços:
    A sequência do algoritmo é: declaração de um vetor, um laço de repetição que está contido dentro do outro. Logo após ao primeiro laço há uma atribuição à variável soma, já dentro do segundo laço existem duas operações, uma de soma e a outra de divisão. Ao final do algoritmo o vetor é retornado.
    Dois laços de repetição (for), que começam em 0 e são incrementados, o primeiro até dados.Length-1 e o segundo até o valor correspondente à variável i. Complexidade O(n^2) para o pior caso.

### 04 - Variação de casos:
    Sem variação de casos.
