# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Para a especificação do projeto, foram determinadas as personas e suas histórias de usuários. Além disso, foram especificados os requisitos funcionais, não funcionais, restrições do projeto e o diagrama de casos de uso.

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas despesas e ter uma previsão de quando poderei fazer minhas viagens | Ter um futuro confortável e conquistar liberdade geográfica |
|Usuário do sistema  | Registrar minhas metas financeiras | Ser independente financeiramente |
|Usuário do sistema  | Gerenciar minhas principais categorias de gastos | Ter estabilidade financeira |
|Usuário do sistema  | Acompanhar o fluxo entre receitas e despesas, além de verificar meus gastos em um mês específico | Obter reeducação financeira e conquistar uma casa própria |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais, além das restrições que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário se cadastre. | ALTA | 
|RF-002| Permitir que o usuário gerencie sua conta. | ALTA |
|RF-003| Permitir que o usuário gerencie transações de entrada e saída. | ALTA |
|RF-004| Permitir que o usuário gerencie categorias para transações de entrada e saída. | ALTA |
|RF-005| Permitir que o usuário defina metas e orçamentos para transações de entrada e saída, respectivamente. | MÉDIA |
|RF-006| Permitir que o usuário visualize a lista de transações cadastradas. | ALTA |
|RF-007| Permitir que o usuário visualize o cálculo das entradas, saídas e o total. | ALTA |
|RF-008| Permitir que o usuário filtre todas as transações realizadas durante um determinado mês, por categoria. | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito | Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku, Vercel). | ALTA | 
|RNF-002| O site deve ser compatível e capaz de rodar nos principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) com alterações mínimas. |  ALTA | 
|RNF-003| O site deve cumprir com a Lei Geral de Proteção de Dados (LGPD). | ALTA | 
|RNF-004| O site deve ser responsivo e deve haver otimização de imagens. | ALTA | 
|RNF-005| O site deve atender aos principais critérios de acessibilidade visual. | MÉDIA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-001| O projeto deverá ser entregue no final do semestre letivo. |
|RE-002| Não é permitido à equipe terceirizar o desenvolvimento do trabalho. |
|RE-003| Deve-se utilizar uma navegação clara, com as tags html apropriadas, para que os usuários que usam leitores de tela possam navegar com mais precisão, a fim de cumprir o que foi definido na RNF-005. |
|RE-004| O design do site deve seguir as diretrizes e requisitos estabelecidos, como o uso de cores específicas, logotipos e estilo de fonte. |

## Diagrama de Casos de Uso

<img src="https://i.imgur.com/bGIQZb4.png" style="width: 70%;" alt="Logo SmartMoney">
