# Documentação Laboratório - Aula 08

### 01 - Pilha

![Pilha1.0](https://user-images.githubusercontent.com/97108963/200974524-cab6c6b9-b022-43b8-9776-6607da866f52.PNG)
![Pilha1.1](https://user-images.githubusercontent.com/97108963/200974522-e9f9b3f5-8dbf-4f77-9290-0f6fa15dc0cf.PNG)

* No programa principal há uma rotina que fornece duas opções ao usuário, caso ele queira remover ou inserir na pilha, a partir da opção que ele escolhe é chamada a função correspondente: remover ou inserir. A função inserir recebe a pilha como parâmetro e inicia com uma estrutura condicional que verifica se sua última posição é diferente de 0, caso seja verdadeiro a função imprime que a pilha está cheia e a retorna para o usuário, em seguida há um laço de repetição que percorre a pilha desde a primeira posição até a penúltima e caso alguma dessas posições esteja vazia, é imprimido uma mensagem ao usuário para que ele insira um valor para a posição correspondente e uma mensagem perguntando se ele deseja continuar inserindo na próxima posição, isso se repete até que o laço chegue na penúltima posição da pilha ou até o usuário digitar que não deseja inserir mais valores.  
* A função remover recebe a pilha como parâmetro, em seguida há uma estrutura condicional que verifica se a primeira posição está vazia e caso seja verdadeiro é imprimida uma mensagem de que ela já está vazia, uma vez que, os valores são sempre removidos pela última posição e se a primeira já está vazia não há mais valores depois dela, posteriormente há um laço de repetição que começa da última posição e vai até a primeira, uma vez que, o valor acessado vai ser sempre o último disponível, há uma estrutura condicional que verifica se o valor da posição é diferente de 0 e se for verdadeiro a função atribui 0 para a posição, em seguida outra estrutura condicional verifica se a primeira posição está vazia e se for verdadeiro imprime uma mensagem dizendo que a pilha já está vazia e ao fim há outra estrutura condicional que verifica se a primeira posição está preenchida e se for verdadeiro pergunta se o usuário deseja continuar removendo, isso se repete até que a primeira posição esteja vazia pou o usuário digite que não queia mais remover.

---

### 02 - Fila

![Fila1.0](https://user-images.githubusercontent.com/97108963/200974526-efaa4bcd-c6fe-4c5d-b282-fea941520381.PNG)
![Fila1.1](https://user-images.githubusercontent.com/97108963/200974525-d8aa03e5-1016-4714-9617-f2cbeb31e62f.PNG)

* No programa principal há uma rotina que fornece duas opções ao usuário, caso ele queira remover ou inserir na pilha, a partir da opção que ele escolhe é chamada a função correspondente: remover ou inserir. A função inserir recebe a fila como parâmetro e no começo há uma estrutura de repetição que percorre desde a primeira posição até a penúltima, dentro dela há uma estrutura condicional que verifica se a posição correspondente está vazia e dentro dela há uma rotina que pede ao usuário que entre com o valor para a posição e imprime uma mensagem, caso ele queira inserir mais valores no caso da fila ainda ter posições vazias, por último há outra estrutura condicional que pede ao usuário inserir um valor na última posição no caso dela estar vazia e a penúltima for diferente de 0 e então a fila é retornada.  
* A função remover recebe a fila como parâmetro e há uma estrutura de repetição que percorre a fila desde a primeira posição até a penúltima e faz o shift, passando o valor da posição i+1 para a posição i e então o primeiro valor da fila será removido. No programa principal uma rotina pergunta ao usuário se ele quer remover mais valores, isso se repete até que todas as posições estejam vazias ou até o usuário digitar que não deseja remover mais.

---

### 03 - Lista

![Lista1.0](https://user-images.githubusercontent.com/97108963/200974528-d637eadc-8340-40f0-9d2e-da65dfc0faff.PNG)
![Lista1.1](https://user-images.githubusercontent.com/97108963/200974520-7db5fb4c-afae-4fa5-a2f6-1aaa448333df.PNG)

* No programa principal há uma rotina que fornece duas opções ao usuário, caso ele queira remover ou inserir na pilha, a partir da opção que ele escolhe é chamada a função correspondente: remover ou inserir. A função inserir recebe a lista e a posição que se deseja inserir como parâmetros, há uma estrutura condicional que verifica se a posição está vazia e insere o valor digitado pelo usuário, caso a condição do if não seja satisfeita há uma rotina que insere o valor na posição desejada e faz o shift. No programa principal há uma rotina que verifica se ainda há posições vazias e pergunta ao usuário se ele quer inserir mais valores.  
* A função remover recebe a lista e a posição que se deseja remover como parâmetros, primeiramente há uma estrutura condicional que verifica se a posição já está vazia e caso seja verdade imprime uma mensagem ao usuário, uma outra estrutura verifica se a posição passada como parâmetro é a última da lista e caso for verdadeira atribui 0 à posição, caso as duas condições não sejam satisfeitas há uma rotina que remove o valor fazendo o shift até a posição em que o usuário inseriu
