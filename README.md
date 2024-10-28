
# Desafios de Programação Orientada a Objetos em C#

## Instruções

- Os desafios devem ser desenvolvidos individualmente.
- Cada desafio foi implementado em um projeto próprio e todos estão na mesma solução (solution) **DesafiosCSharp**.
- A classe que usada em mais de um desafio, não foi duplicada e usamos como referências.

## Desafios

1. **Projeto Pirâmide**
   - Crie a classe `Piramide` e implemente:
     - Propriedade inteira `N` (N ≥ 1 e alterável).
     - Construtor para inicializar o valor de `N`. Gere uma exceção caso `N < 1`.
     - Método `Desenha` que imprime uma pirâmide com os números de 1 a `N`.
     - **Exemplo de saída para N = 4:**
       ```
       1
       121
       12321
       1234321
       ```

2. **Projeto Vértice**
   - Crie a classe `Vertice` e implemente:
     - Propriedades reais `X` e `Y` (leitura pública e escrita privada).
     - Construtor para inicializar os valores de `X` e `Y`.
     - Método `Distancia` para calcular a distância euclidiana de um vértice a outro.
     - Método `Move` para mover o vértice para outra posição `(x, y)`.
     - Método para verificar se dois vértices são iguais.

3. **Projeto Triângulo**
   - Usando a classe `Vértice` do desafio 2, crie a classe `Triangulo`, que possui 3 vértices (leitura pública e escrita privada). Nessa classe implemente:
     - Construtor para inicializar os vértices do triângulo. Gere uma exceção caso os vértices não formem um triângulo.
     - Método para verificar se dois triângulos são iguais.
     - Propriedade `Perimetro` para retornar o perímetro do triângulo.
     - Propriedade `Tipo` para retornar o tipo do triângulo (equilátero, isósceles ou escaleno).
     - Propriedade `Area` para retornar a área do triângulo.

4. **Projeto Polígono**
   - Usando a classe `Vértice` do desafio 2, crie a classe `Poligono`, que possui 3 ou mais vértices. Nessa classe implemente:
     - Construtor para inicializar os vértices do polígono (pelo menos 3 vértices). Gere uma exceção caso o polígono não tenha ao menos 3 vértices.
     - Método booleano `AddVertice` para adicionar um novo vértice `v` ao polígono.
     - Método `RemoveVertice` para remover um vértice `v` do polígono. Gere uma exceção caso o polígono fique com menos de 3 vértices.
     - Método para retornar o perímetro do polígono.
     - Propriedade para retornar a quantidade de vértices do polígono.

5. **Projeto Intervalo**
   - Crie a classe `Intervalo` para representar um intervalo de tempo com data/hora inicial e final.
   - Implementar:
     - Construtor para inicializar a data/hora inicial e final. Gere uma exceção caso data/hora inicial > data/hora final.
     - Métodos para verificar intersecção e igualdade de intervalos.
     - Propriedade `Duracao` para retornar a duração de um intervalo.

6. **Projeto ListaIntervalo**
   - Usando a classe `Intervalo` do desafio 5, crie a classe `ListaIntervalo` que implementa uma lista de intervalos.
   - Implementar:
     - Método `Add` para adicionar um novo intervalo à lista.
     - Propriedade `Intervalos` que retorna uma lista imutável dos intervalos ordenados por data/hora inicial.

7. **Projeto Armstrong**
   - Implemente um método de extensão denominado `IsArmstrong` que retorna um valor booleano indicando se um número inteiro positivo é ou não um número de Armstrong. 
   - Imprima todos os números de Armstrong de 1 a 10000.

8. **Projeto Certidão Nascimento**
   - Crie as classes `Pessoa` e `CertidaoNascimento` com os atributos, propriedades e construtores adequados.
   - Regras de associação:
     - Uma pessoa pode ter ou não uma certidão.
     - Uma certidão sempre pertence a uma única pessoa.

9. **Projeto Carro**
   - Crie as classes `Carro` e `Motor` para representar um carro e seu motor.
   - Implementar regras de negócio para troca de motor e cálculo de velocidade máxima.

10. **Projeto Validação Dados**
    - Crie uma aplicação que faz a entrada de dados de um cliente, validando conforme regras específicas.
    - Em caso de erro, deve emitir mensagens adequadas e solicitar nova entrada.

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para enviar pull requests ou abrir issues para discutir melhorias.

## Licença

Este projeto é licenciado sob a [MIT License](LICENSE).

