# Plano de Testes de Usabilidade



 # Método Utilizado

O Teste será realizado  _In Person_, na presença de um observador integrante da equipe desse projeto e serão executados os métodos de Observação, Medição, Avaliação e Consolidação dos Dados.

Para cada tarefa executada pelo voluntário será possível medir:

-	Concretização da tarefa;
-	O total de erros cometidos;
-	Quantos erros de cada tipo ocorreram;
-	Quanto tempo foi necessário para concluir a tarefa;
-	Qual o nível de dificuldade relatado pelo voluntário, sendo:

  | **Escala** | **Classificação**    |
|------------|----------------------|
| 1          | Extremamente Difícil |
| 2          | Muito Difícil        |
| 3          | Moderado             |
| 4          | Fácil                |
| 5          | Muito Fácil          |

-	Qual o nível de satisfação relatado pelo voluntário, sendo:

| **Escala** | **Classificação**  |
|------------|--------------------|
| 1          | Muito Insatisfeito |
| 2          | Insatisfeito       |
| 3          | Neutro             |
| 4          | Satisfeito         |
| 5          | Muito Satisfeito   |

  # Roteiro das Tarefas

Casos de Teste | CT-01. Cadastro de Usuário 
--- | --- 
Requisitos Associados | RF-01: Permitir que os usuários criem contas utilizando o endereço de e-mail, CPF, endereço residencial, considerando métodos definidos RBAC e utilizando funções CRUD	 
Objetivo do Teste | Verificar se após a inserção de dados o sistema possibilita a validação ou mensagem de erro no cadastro de usuário, indicando o que fazer para correção do erro. 
Passos | 1. Acessar o Navegador; <br>2. Informar o endereço do Site;<br> 3. Caso o usuário possuir cadastro, fazer o login no sistema na opção “Entrar”;<br> 4. Caso o usuário não possuir cadastro, clicar em “Cadastre-se agora” e seguir as instruções. 
Critérios de Êxito | O usuário deve ser capaz de realizar o cadastro e login. 


| Caso de Teste 	| **CT-02  Efetuar login**	
---|---
Requisitos Associados | RF-01: Permitir que os usuários criem contas utilizando o endereço de e-mail, CPF, endereço residencial, considerando métodos definidos RBAC e utilizando funções CRUD	 
 Objetivo do Teste 	| Verificar se o usuário consegue realizar login e ser encaminhado para a homepage,  conseguir vizualizar quatro opções: Gerenciar refeições, Consultar receitas, Exibir consumo calórico e Consultar dietas  |
 Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no "Ícone de login" <br> - Preencher o campo de email <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. 

| Caso de Teste 	| **CT-0  Informação do Usuario **	
---|---
Requisitos Associados | RF-007	Apresentar para cada usuário uma imagem de perfil correspondente ao usuário. (thumbnail). 
 Objetivo do Teste 	| Verificar se o usuário consegue colocar sua informações pessoais e editar quando necessario   |
 Passos 	| - 1. Realizar login no sistema,<br> 2. No menu principal, escolher a aba “Informação do usuário”;<br> 3. Escolha a opção “adicionar”;<br> 4. Informar os campos obrigatórios;<br> 5. Clicar em “Salvar”.  |
|Critério de Êxito | - Informação cadastradas com sucesso 

Casos de Teste | CT-04. Cadastro de itens 
--- | --- 
Requisitos Associados | RF-002	Permitir que o usuário gerencie os itens das refeições realizadas. RF-003	Cadastrar e exibir o quantitativo calórico. RF-005	Consultar dietas, permitir ao usuário visualizar informações interativas sobre tipos de dietas e receitas alimentares, como ex: dieta cetogenica, jejum intermitente.
Objetivo do Teste | Permitir o usuário gerencie itens de receita (adicionando, eliminando e alterando), saiba a quantidade de calorias que será consumidos ou que cada ingrediente contém.
Passos | 1. Realizar login no sistema,<br> 2. No menu principal, escolher a aba “Grupo alimentar ”;<br> 3. Escolha a opção “adicionar”;<br> 4. Informar os campos obrigatórios;<br> 5. Clicar em “Adicionar”.  |
Critérios de Êxito | O usuário deve ser capaz de gerenciar suas proprias receitas e conseguir vizualizar a página de cadastro de refeições com as seguintes opções: Carboidratos, Carnes e ovos, Frutas, Laticínios, Legumes e Verduras, Leguminosos e Óleos e Gorduras além de encontrar o consumo calórico sugerido pela altura e peso do usuário.


Casos de Teste | CT-05. Cadastro de itens 
--- | --- 
Requisitos Associados | RF-010	Personalizar planos alimentares com base nas preferências dietéticas, restrições alimentares e metas de saúde individuais dos usuários. RF-009	Surgerir cardapio para o usuário, oferecendo uma alimentação controlada e saudável.
Objetivo do Teste | Vizualizar uma lista de receitas sugeridas juntamente com uma barra de pesquisa.
Passos | 1. Realizar login no sistema,<br> 2. No menu principal, escolher a aba “Receitas”;<br>  |
Critérios de Êxito | O usuário deve ser capaz de adicionar, criar e salavar sua proprias receitas.





