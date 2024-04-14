# Plano de Testes de Software

Os requisitos para realização dos testes de software são: 

- Site publicado na Internet.
- Navegador da Internet - Chrome, Firefox, Edge, Opera e Safari.
- Conectividade de Internet para acesso às plataformas (APISs).

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.
 
| **Caso de Teste** 	| **CT-01 – Gerenciar loguin** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - Permitir que os usuários criem contas utilizando o endereço de e-mail, CPF, endereço residencial, considerando métodos definidos RBAC e utilizando funções CRUD. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Digitar a sua altura e seu peso <br> - Selecionar o seu grau realizado de atividade física <br> - Vizualizar o consumo diário desejável de calorias.  |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Gerenciar Refeições	|
|Requisito Associado | RF-02	- Permitir que o usuário gerencie os itens das refeições realizadas. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar o gerenciamento de seus refeições. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em gerenciar refeições|
|Critério de Êxito | - Abrir a página de refeições. |
|  	|  	|
| Caso de Teste 	| CT-03  – Exibir consumo calórico	|
|Requisito Associado | RF-03	- Exibir o quantitativo calórico cadastrado diariamente. |
| Objetivo do Teste 	| Verificar se o usuário consegue ter acesso a quantidade de calórias consumidas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em exibir consumo calórico.|
|Critério de Êxito | - Abrir a página consumo calórico. |
|  	|  	|
| Caso de Teste 	| CT-04  – Consultar receitas	|
|Requisito Associado | RF-04	- Disponibilizar aos usuários uma barra de pesquisa eficiente que permite aos usuários buscar receitas específicas por nome ou ingredientes. |
| Objetivo do Teste 	| Verificar se o usuário consegue consultar receitas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em consultar receitas <br> - Pesquisar alguma receita|
|Critério de Êxito | - Abrir a página da receita pesquisada. |
|  	|  	|
| Caso de Teste 	| CT-05  – Consultar dietas	|
|Requisito Associado | RF-05 - Consultar dietas, permitir ao usuário visualizar informações interativas sobre tipos de dietas e receitas alimentares, como ex: dieta cetogenica, jejum intermitente. |
| Objetivo do Teste 	| Verificar se o usuário consegue consultar dietas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em consultar dietas|
|Critério de Êxito | - Abrir a página da dieta pesquisada. |
|  	|  	|
| Caso de Teste 	| CT-06  – Salvar receitas	|
|Requisito Associado | RF-06 - Salvar as receitas pesquisadas e cardapios planejados, armazenando essas informações no armazenamento local do navegador. |
| Objetivo do Teste 	| Verificar se o usuário consegue salvar receitas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em consultar receitas <br> - Pesquisar alguma receita <br> - Clicar em salvar na receita pesquisada. |
|Critério de Êxito | - Receita salva com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-07  – Gerenciar perfil	|
|Requisito Associado | RF-07 - Apresentar para cada usuário uma imagem de perfil correspondente ao usuário. (thumbnail). |
| Objetivo do Teste 	| Verificar se o usuário consegue personalizar a foto de perfil. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em configurações <br> - Clicar em perfil <br> - Clicar em alterar foto de perfil. |
|Critério de Êxito | - Foto alterada com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-08  – Avaliar e Comentar receitas.	|
|Requisito Associado | RF-08 - Comentar e avaliar receitas. |
| Objetivo do Teste 	| Proporcionar que o usuário consiga  avaliar e comentar uma receita escolhida. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em consultar receitas <br> - Pesquisar alguma receita <br> - Clicar em salvar na receita pesquisada <br> - Clicar em avaliar - Escolhe se quer comentar algo na caixa de texto.|
|Critério de Êxito | - Avaliação feita com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-09  – Sugerir Cardápio.	|
|Requisito Associado | RF-09 - Surgerir cardapio para o usuário, oferecendo uma alimentação controlada e saudável. |
| Objetivo do Teste 	| Oferecer um cardápio saúdavel para o usúario. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar na tela de auxilio de criação de dietas <br> - Selecione a proteína que quer usar.   |
|Critério de Êxito | - Pesquisa efetuada com sucesso. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
