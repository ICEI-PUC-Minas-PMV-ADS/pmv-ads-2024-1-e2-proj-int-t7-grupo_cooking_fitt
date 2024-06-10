# Arquitetura da Solução

A arquitetura de soluções constrói soluções com base nas necessidades da empresa, é responsável por desenhar e implementar recursos e ferramentas de TI para atender as necessidades do usuário, ou seja, definir de forma estruturada quais são so componentes, propriedades e documentações necessárias para que um sistema seja desenvolvido, além de seu relacionamento com outros sistemas.

A arquitetura para a solução em questão será basicamente a hospedagem da aplicação, e integração da mesma com APIs públicas, a fim de agilizar o processo de login e contatos.

Toda codificação é armazenada no Github, o versionamento é controlado via Git Flow, para que todo o processo seja acompanhado e revertido, se preciso for.

A aplicação do projeto matriz tem integração com banco de dados.

## Diagrama de Classes

O diagrama de classes abaixo representará as classes, suas estruturas e relações que servem de modelo para objetos.

O projeto comtempla o CRUD ou seja, as quatro operações básicas utilizadas em bases de dados relacionais (Create, Read, Update e Delete).


![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupo_cooking_fitt/assets/144388125/dcc359ae-26ca-4650-95a3-a5559e8677e6)







## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.



![Modelo entidade Relacionamento (projeto conceitual)](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupo_cooking_fitt/assets/135378577/4311b1b9-e75e-4b2e-bce6-a14999471086)


## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.

### Tabela: InfoUser
| Campo             | Tipo                  | Restrições                 |
|-------------      |--------------         |----------------------------|
| Id_info           | INT                   | NOT NULL                   |
| nome              | VARCHAR(255)          | NOT NULL                   |
| dt_nasc           | DATE                  | NOT NULL                   |
| genero            | VARCHAR(10)           |                            |
| telefone          | INT                   |                            |
| form_academica    | VARCHAR(255)          |                            |
| Biografia         | VARCHAR(255)          |                            |
| link              | VARCHAR(255)          |                            |


### Tabela: Usuário
| Campo             | Tipo                  | Restrições                 |
|-------------      |--------------         |----------------------------|
| Id_usuario        | INT                   | NOT NULL                   |
| name              | VARCHAR(255)          | NOT NULL                   |
| senha             | VARCHAR(10)           | NOT NULL                   |
| Email             | VARCHAR(10)           |                            |


### Tabela: Receitas
| Campo             | Tipo                  | Restrições                 |
|-------------      |--------------         |----------------------------|
| nome              | VARCHAR(255)          | NOT NULL, FOREIGN KEY      |
| ID_receita        | INT                   | PRIMARY KEY                |
| descriçao         | VARCHAR(255)          | NOT NULL, FOREIGN KEY      |
| ativo             | BOOLEAN               | DEFAULTE FALSE             |


### Tabela: TipoCardapio
| Campo             | Tipo                  | Restrições                 |
|-------------      |--------------         |----------------------------|
| id_cardapio       | INT                   | NOT NULL                   |
| tipo              | VARCHAR(255)          | NOT NULL                   |


### Tabela: Ingrediente
| Campo             | Tipo                  | Restrições                 |
|-------------      |--------------         |----------------------------|
| nome              | VARCHAR(255)          | NOT NULL                   |
| Id_ingrediente    | INT                   | NOT NULL, PRIMARY KEY      |
| calorias          | INT                   | NOT NULL                   |
| unidade           | VARCHAR(255)          | NOT NULL                   |
| peso              | VARCHAR(255)          | NOT NULL                   |
| tipo              | VARCHAR(255)          | NOT NULL                   |
| tipo_ingrediente  | VARCHAR(255)          | NOT NULL, FOREIGN KEY      |

### Tabela: TipoIngrediente
| Campo             | Tipo                  | Restrições                 |
|-------------      |--------------         |----------------------------|
| Id_tipoingrediente| INT                   | NOT NULL, PRIMARY KEY      |
| tipo              | VARCHAR(255)          | NOT NULL                   |


### Tabela: Cardapio
| Campo              | Tipo                  | Restrições                 |
|-------------       |--------------         |----------------------------|
| Id_cardapio        | INT                   | NOT NULL, PRIMARY KEY      |
| descriçao          | VARCHAR(255)          | NOT NULL                   |
| quantidade_cardapio| INT                   | NOT NULL                   |
| calorias_cardapio  | INT                   | NOT NULL                   |


### Tabela: ItemCardapio
| Campo             | Tipo                  | Restrições                 |
|-------------      |--------------         |----------------------------|
| id_itemCardapio   | INT                   | PRIMARY KEY,, FOREIGN KEY  |
| tipo_cardapio     | VARCHAR(255)          | NOT NULL                   |




## Tecnologias Utilizadas

As tecnologias que serão ultilizadas são HTML5, CSS3 e JavaScript para o front-end, e C# e SQL server para back-end e banco de dados. As tecnologias foram escolhidas devido sua popularidade e sua versatilidade que permitem interações de usuário e de APIs externas.

* Linguagens e frameworks utilizadas para desenvolver o projeto: HTML5, CSS3, JavaScript, C#, Bootstrap, Media Queries, .NET
* IDEs de desenvolvimento: Visual Studio Code e Visual Studio
* Plataforma para hospedagem do site: Heroku e GitPages
* Plataforma para hospedagem dos arquivos: GitHub e Google Drive
* Ferramenta de versionamento: Git e GitHub Desktop
* Ferramenta para a criação de logo e imagens: Figma, Photoshop
* Ferramenta para criação do template / wireframing: Figma 
* Ferramenta para criação de diagramas e fluxos: Lucidchart e Visio
* Banco de Dados: SQL Server e Azure



## Hospedagem

O site utiliza a plataforma do Github e Azure como ambiente de hospedagem do site do projeto. O site é mantido no ambiente da URL do GitPages e Azure, através do endereço: https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupo_cooking_fitt/edit/main/docs/05-Arquitetura%20da%20Solu%C3%A7%C3%A3o.md e https://cookingfit2.azurewebsites.net/Usuarios/Login?ReturnUrl=%2F

