# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição do problema a ser tratados neste projeto foi elaborado a partir de experiências pessoais, relacionadas ao assunto, compartilhada por alguns membros do grupo que utilizam aplicativos similares ou possuem pessoas próximas que tem dificuldade em realizar uma alimentação saudável. A partir desses relatos, foi possível deduzir alguns problemas dos usuários. O detalhamento do processo está organizado em personas e histórias de usuários.


## Personas

Persona | 1
---|---
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e3-proj-mov-t7-cooking_fit/assets/144388125/10691c91-e3a8-4393-8f8e-e9af0ad2171e" width = "250" height = "200" />| **Maria Alice**  
**Idade:** | **Ocupação:** | **Hobbies:** | **Aplicativos:**
 36 | Policial |  Escalada | Instagram, Apps bancários, Netflix, WhatsApp 
 **Motivações:** | **Frustrações:**
 Gosta de se exercitar. Gostaria de melhorar seu condicionamento físíco e converter gordura em massa magra pois seu trabalho exige do seu condicionamento físico. Quer melhorar sua alimentação mas nunca teve tempo para se dedicar a isso. | Sofre com a rotina frenética e intensa que seu trabalho exige. Está buscando uma maneira fácil de controlar suas refeições.

Persona | 2
---|---
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e3-proj-mov-t7-cooking_fit/assets/144743493/85ef5f4e-b546-4a6c-bd65-e973a9176b45" width = "250" height = "250" />| **Sandra**  
**Idade:** | **Ocupação:** | **Hobbies:** | **Aplicativos:**
 39 | Modelo Pus Size | Aprender novas receitas| Youtube, Netflix, WhatsApp  
 **Motivações:** | **Frustrações:**
Gosta de receitas saudáveis em especial na alimentação dos filhos.| Se desdobra para lidar com o trabalho e cuidar dos filhos teve uma notícia ruim, descobriu que está pré diabética e foi orientada por um profissional a mudar radicalmente sua dieta.Desesperada e sem muito tempo disponível em sua rotina procura uma ferramenta que a ajude com receitas e cuidados especiais para enfrentar esse obstáculo.

Persona | 3
---|---
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e3-proj-mov-t7-cooking_fit/assets/144743493/28922630-4a61-402e-a2d7-c3f485743a9d" width = "250" height = "250" />| **Felipe Silva**  
**Idade:** | **Ocupação:** | **Hobbies:** | **Aplicativos:**
 54 | Bancário | Jogar tênis| Apps bancários, Netflix, WhatsApp  
 **Motivações:** | **Frustrações:**
 Gostaria de sair desse estilo de vida sedentário para uma vida mais saudável. Busca um aplicativo que o auxilie nessa nova etapa de sua vida. | Trabalha quase o dia todo sentado. Depois de muitos anos dessa rotina, ele reparou que sua saúde não é mais a mesma, sobrepeso e alguns outros problemas de saúde.
  
Persona | 4
---|---
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e3-proj-mov-t7-cooking_fit/assets/144743654/49e68b85-5a7e-4194-9e70-068e0545e273" width = "270" height = "250" />| **Jeniffer**  
**Idade:** | **Ocupação:** | **Hobbies:** | **Aplicativos:**
24 | Fisioterapeuta | Pilates| Instagram, Netflix, WhatsApp  
**Motivações:** | **Frustrações:**
Gostaria de melhorar a alimentação e emagrecer para se sentir bem. | Trabalha por conta própria, tem uma péssima alimentação e está acima do peso. Estava muito sobrecarregada com o próprio negócio pensando só na saúde das outras pessoas. Com o sobrepeso decidiu procurar uma nutricionista e ir na academia para ajudar nesse processo. A dificuldade é ter constância e ser organizada com os alimentos (se preparar antes, economiza tempo e fica mais fácil de alimentar). Péssimo habito não ter controle sobre os alimentos e come alimentos ultra processados, alimentos de fácil acesso e mais em conta.

Persona | 5
---|---
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e3-proj-mov-t7-cooking_fit/assets/120505395/10cb048d-c214-4ce2-94e9-f91f91737834" width = "270" height = "200" />| **José Carlos** 
**Idade:** | **Ocupação:** | **Hobbies:** | **Aplicativos:**
37 | Autônomo | Andar de bicicleta e futebol.| Instagram, Netflix, WhatsApp 
**Motivações:** | **Frustrações:**
Tem vontade de buscar melhor qualidade de vida, pois a falta de tempo durante a semana trás com que se alimente incorretamente buscando opções fáceis como lanches e fastfoods. | Entende que precisa dedicar tempo em sua agenda para conseguir elaborar um cardápio e preparar as refeições, mas as demandas de trabalho estão cada vez maiores, sente-se preso a um looping.

Persona | 6
---|---
<img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e3-proj-mov-t7-cooking_fit/assets/135378577/7176129c-d8a5-4b0a-8c68-17c5506565b9" width = "200" height = "250" />| **Rodrigo oliveira**  
**Idade:** | **Ocupação:** | **Hobbies:** | **Aplicativos:**
45 | Servente de pedreiro | Ver televisão.| Star+, Netflix, WhatsApp  
**Motivações:** | **Frustrações:**
Tem vontade de controlar sua alimentação diária assim como sua condição física de trabalho.| Possui problema de pressão alta e início de diabete. O médico recomendou um controle alimentar além da medicação.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Maria Alice  | ver meu progresso           | saber onde tenho que melhorar               |
|Maria Alice       | visualizar quantas calorias já consumi                 | saber quantas ainda posso consumir |
|Sandra  | Encontrar receitas saudáveis          | combater a pré-diabetes           |
|Felipe Silva | Controlar os horários de suas refeições  | nao perder nenhuma refeição importante  |
|Jeniffer | Ter constância e ser organizada com os alimentos |melhor organização na alimentação e emagrecer para se sentir bem.
|José Carlos  | Dedicar mais tempo a preparar refeições saudáveis | buscar qualidade de vida, prevenir futuros problemas de saúde |
|Rodrigo oliveira  | Melhorar e controlar as refeições  | perder hábitos alimentares ruins que prejudicam a saúde |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que os usuários criem contas utilizando o endereço de e-mail, CPF, endereço residencial, considerando métodos definidos RBAC e utilizando funções CRUD | ALTA | 
|RF-002| Permitir que o usuário gerencie os itens das refeições realizadas | ALTA | 
|RF-003| Exibir o quantitativo calórico cadastrado diariamente | ALTA | 
|RF-004| Disponibilizar aos usuários uma barra de pesquisa eficiente que permite aos usuários buscar receitas específicas por nome ou ingredientes. | ALTA |
|RF-005| Consultar dietas, permitir ao usuário visualizar informações interativas sobre tipos de dietas e receitas alimentares, como ex: dieta cetogenica, jejum intermitente. | MÉDIA |
|RF-006| Salvar as receitas pesquisadas e cardapios planejados, armazenando essas informações no armazenamento local do navegador.  | MÉDIA |
|RF-007| Apresentar para cada usuário uma imagem de perfil correspondente ao usuário.  (thumbnail).   | MÉDIA |
|RF-008| Comentar e avaliar receitas.   | MÉDIA |
|RF-009| Surgerir cardapio para o usuário, oferecendo uma alimentação controlada e saudável. | BAIXA |
|RF-010| Personalizar planos alimentares com base nas preferências dietéticas, restrições alimentares e metas de saúde individuais dos usuários.   | BAIXA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel. | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s. |  BAIXA | 
|RNF-003| Interface Amigável e Intuitiva: Projetar uma interface de usuário intuitiva e amigável, com navegação fácil e instruções claras, para garantir que os usuários possam usar o aplicativo sem dificuldades. | MÉDIA |
|RNF-004| A plataforma deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge). | ALTA |
|RNF-005| A plataforma deve funcionar 24 horas por dia, 7 dias por semana. | ALTA |
|RNF-006| A plataforma deve haver sistemas de backup robustos para garantir que os dados dos usuários estejam protegidos e que seja possível restaurá-los em caso de falha ou perda de dados e deve ser capaz de criar e recuperar cadastros. | ALTA |
|RNF-007| A plataforma deve ser capaz de lidar com um grande número de usuários simultâneos sem comprometer o desempenho ou a disponibilidade. | ALTA |
|RF-008| A plataforma deve possibilitar que os usuários tenha acesso à aplicação (receitas salvas) offline. | MÉDIA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre 06/2024. |
|02| A equipe não pode subcontratar / tercerizar o desenvolvimento do trabalho.|
|03| O aplicativo deve se restringir às tecnologias básicas da Web no Frontend. |
|04| A esquipe não deverá aceitar parcerias de qualquer area de negócios, focando em parceria na área de saúde e educação. |
|05| As receitas não pode violar os Normas de Segurança Alimentar. |
|06| A equipe deve restringir a publicidade de alimentos não saudáveis ​​ou a promoção de determinados ingredientes considerados prejudiciais à saúde.|

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e3-proj-mov-t7-cooking_fit/assets/144388125/608759cc-7a76-4cd7-ad82-6e52f077d1ad)



