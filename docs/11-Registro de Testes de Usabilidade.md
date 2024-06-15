Os testes de usabilidades foram feitos de forma presencial e os resultados estão descritos na tabela abaixo

### CTU-01: Cadastro de novo usuário.

| **Usuário** | **Caso de teste** | **Tempo** | **Ações** | **Qtd. Erros** | **Se recuperou do erro**                                  | **Comentários e observações**                                                                                                     |
| ----------- | ----------------- | --------- | --------- | -------------- | --------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- |
| Usuário 1   | CT-02             | 00:01:30  | 6         | 0              | ---                                                       | Usuário com alguma dificuldade, realizou o cadastro relativamente rápido  |
| Usuário 2   | CT-02             | 00:01:00  | 6         | 0              | ---                                                       | Usuário achou a experiência de cadastro intuitiva e conseguiu realizar corretamente                                               |

### CTU-02: Logar no sistema.

| **Usuário** | **Caso de teste** | **Tempo** | **Ações** | **Qtd. Erros** | **Se recuperou do erro**          | **Comentários e observações**                                                                                                 |
| ----------- | ----------------- | --------- | --------- | -------------- | --------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| Usuário 1   | CT-02             | 00:00:30  | 3         | 0              | ---                               | Realizou o processo sem duvidas                                                                                               |
| Usuário 2   | CT-02             | 00:00:25  | 3         | 0              | ---                               | Realizou o processo rapidamente sem dúvidas de como executar                                                                  |

### CTU-03: Consultar por receitas.

| **Usuário** | **Caso de teste** | **Tempo** | **Ações** | **Qtd. Erros** | **Se recuperou do erro** | **Comentários e observações**                                                                                                                                                            |
| ----------- | ----------------- | --------- | --------- | -------------- | ------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Usuário 1   | CT-03             | 00:01:30  | 4         | 0              | ---                      | Realizou o processo rapidamente sem dúvidas de como executar                                                                                                                             |
| Usuário 2   | CT-03             | 00:01:00  | 4         | 0              | ---                      | Realizou o processo rapidamente sem dúvidas de como executar                                                                                                                             |

### CTU-04: Gerenciar Refeições.

| **Usuário** | **Caso de teste** | **Tempo** | **Ações** | **Qtd. Erros** | **Se recuperou do erro** | **Comentários e observações**                                                                                                                                                                                                                                                                                                       |
| ----------- | ----------------- | --------- | --------- | -------------- | ------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Usuário 1   | CT-03             | 00:02:30  | 7         | 0              | ---                      | Usuário não gostou do fluxo para cadastrar/gerenciar os eventos, achou confuso                                                                                                                                                                                                                                       |
| Usuário 2   | CT-03             | 00:02:30  | 7         | 0              | ---                      | Usuário não gostou da experiência de cadastrar/gerenciar e reclamou de faltar explicações no caminho                                                                                                                                                                                    |

### CTU-05: Exibir consumo calórico.

| **Usuário** | **Caso de teste** | **Tempo** | **Ações** | **Qtd. Erros** | **Se recuperou do erro**                                               | **Comentários e observações**                                                                                                                                                                                |
| ----------- | ----------------- | --------- | --------- | -------------- | ---------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Usuário 1   | CT-05             | 00:03:40  | 10        | 0              | ---                                                                    | Usuário encontrou teve dificuldade de entender e precisou de auxílio. |
| Usuário 2   | CT-05             | 00:06:15  | 18        | 3              | Sim após ajustar os critérios de pesquisa na barra superior            | Usuário teve dificuldade inicial para encontrar o evento, após algumas explicações conseguiu obter a informação                                                                             |                                                           |



<h2>Relatório dos Testes de Usabilidade</h2>

### Observações

Após a conclusão dos testes de usabilidade, foram identificadas oportunidades significativas de aprimoramento no software, visando proporcionar uma experiência mais intuitiva e eficiente aos usuários. Este relatório destaca as principais descobertas, recomendações e insights derivados das avaliações realizadas, proporcionando uma visão abrangente sobre a usabilidade do sistema.

### Relatório:

Na condução dos testes, levaram-se em consideração os parâmetros de tempo de execução, quantidade de ações necessárias para a conclusão da tarefa, incidência de erros e avaliação da experiência do usuário.

#### Testes que obtiveram resultados satisfatórios

Nos testes de **CTU-01**, **CTU-02**, **CTU-03** todos as métricas avaliadas como quantidade de ações, tempo de execução e numero de erros tiveram resultados sem grandes variações e receberam feedback positivo dos usuários. Nestes casos de testes não foram identificadas necessidades de aprimoramento na interface da aplicação.

#### Testes que obtiveram resultados não satisfatórios

**CTU-04 Gerenciar Refeições**

A experiência do usuário evidencia dificuldade em identificar e localizar o evento desejado. Elementos explicativos quando passa o mouse no ícone podem ajudar.

| **Média de tempo** | **Média de ações** | **Quantidade de erros nos testes** |
| ------------------ | ------------------ | ---------------------------------- |
| 00:01:30           | 6                  | 2                                  |

**CTU-05: Exibir consumo calórico.**

Durante os testes, foi observado um fluxo não linear na ação comm necessidade de intervenção

| **Média de tempo** | **Média de ações** | **Quantidade de erros nos testes** |
| ------------------ | ------------------ | ---------------------------------- |
| 00:02:05           | 12                 | 2                                  |

### Plano de correção

Foram identificadas as seguintes propostas de melhoria na aplicação para adequar a usuabilidade da tela home Ingredientes a escolha do usuário para encontrar o evento:

- Criar um pagina para que o usuário visualize todas os ingredientes e filtre por calorias e tipo
- Inserir link para acesso rápido ao cardápio já elaborado

Para melhoria da tela de login foi identificado a seguinte melhoria.

- Implementar a função ara recuperar a senha do usuário
