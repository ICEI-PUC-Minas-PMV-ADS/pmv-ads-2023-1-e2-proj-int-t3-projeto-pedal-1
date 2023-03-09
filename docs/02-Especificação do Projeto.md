# Especificações do Projeto

A definição do problema e os pontos a serem tratados neste projeto foram formatados a partir da participação de esportistas em encontros com membros da equipe de desenvolvimento em ambientes recreativos durante as manhas dos finais de semana. Os usuários de bike relataram suas experiencias e expectativas e os dados levantados neste processo foram consolidados na forma de personas e histórias de usuários. 

## Personas

<table>
    <tbody>
        <tr>
            <td rowspan=3> <img src="/docs/img/flavia.png" width=120% height=120%> <br> Foto de Edward Cisnero em Unsplash </td>
            <td colspan=2> <h1>Flávia dos Santos</h1> </td> 
        </tr>
        <tr>
            <td rowspan=2><h4>Idade:</h4> 52 <br> <h4>Ocupação:</h4> Engenheira Civíl, é sócia de uma empresa de projetos. </td>
            <td><strong>Objetivo:</strong><br> <ul><li>Cuidar da saúde e se divertir;</li><li>Conhecer novas pessoas;</li></ul></td>
        </tr>
        <tr>
            <td><strong>Hobbies:</strong> <ul><li>Ouvir música;</li> <li>Ler bons livros;</li></li></ul></td>
        </tr>
  	    <tr>
            <td colspan="3"><strong>Motivações:</strong><br> <ul><li>Prefere resolver todas as suas necessidades por meio da internet, no momento que puder;</li> <li>Gostaria de diversificar a atividade física que realiza no período da noite;</ul></td></tr>
       <tr>
            <td colspan="3"><strong>Frustrações:</strong> <ul><li>Gosta de pedalar mas se sente desmotivada por não ter companhia.</li></td></tr>
    </tbody>
</table>

<table>
    <tbody>
        <tr>
            <td rowspan=3> <img src="/docs/img/bruno.png" width=100% height=100%> <br> Foto de Edward Cisnero em Unsplash </td>
            <td colspan=2> <h1>Bruno Caldeira</h1> </td> 
        </tr>
        <tr>
            <td rowspan=2><h4>Idade:</h4> 35 <br> <h4>Ocupação:</h4> Professor de alemão da fundação Goethe;</td>
            <td><strong>Objetivo:</strong><br> <ul><li>Propor passeios de bike para grupos;</li><li>Conhecer novas pessoas;</li></ul></td>
        </tr>
        <tr>
            <td><strong>Hobbies:</strong> <ul><li>Fazer ginástica;</li> <li>Jogar Games;</li></li></ul></td>
        </tr>
  	    <tr>
            <td colspan="3"><strong>Motivações:</strong><br> <ul><li>Gosta de criar roteiros diferentes de bike;</li> <li>Gostaria de reunir o maior número de pessoas e passeios de bike;</ul></td></tr>
       <tr>
            <td colspan="3"><strong>Frustrações:</strong> <ul><li>Não consegue reunir pessoas para seus passeios de bike;.</li></td></tr>
    </tbody>
</table>

<table>
    <tbody>
        <tr>
            <td rowspan=3> <img src="/docs/img/carlos.png" width=100% height=100%> <br> Foto de Edward Cisnero em Unsplash </td>
            <td colspan=2> <h1>Dr. Carlos Caetano</h1> </td> 
        </tr>
        <tr>
            <td rowspan=2><h4>Idade:</h4> 48 <br> <h4>Ocupação:</h4> Médico que atende em diversos hospitais;</td>
            <td><strong>Objetivo:</strong><br> <ul><li>Preencher seu tempo vago com atividades físicas;</li><li> Conhecer novas pessoas;</li></ul></td>
        </tr>
        <tr>
            <td><strong>Hobbies:</strong> <ul><li>Natação;</li> <li>Viagens;</li></li></ul></td>
        </tr>
  	    <tr>
            <td colspan="3"><strong>Motivações:</strong><br> <ul><li>Se sente mais seguro pedalando em grupos;</td></tr>
       <tr>
            <td colspan="3"><strong>Frustrações:</strong> <ul><li>Não conhece roteiros de bike na zona rural;</li></td></tr>
    </tbody>
</table>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Flávia dos Santos | Preciso fazer atividade física regular | Para manter meu peso controlado |
|Flávia dos Santos | Necessito de motivação para atividade física | Tenho que manter a regularidade para não desanimar |
|Bruno Caldeira | Propor roteiros diferentes de bike | Avaliar o nível de dificuldade e o público-alvo ideal para cada programação |
|Bruno Caldeira | Conhecer o maior número de esportistas | Gostaria de montar uma empresa de atividade outdoor |
|Dr. Carlos Caetano| Pedalar em grupos grandes | Me sinto mais seguro|
|Dr. Carlos Caetano | Fazer peladas longas em parques nacionais/estaduais e reservas naturais | Quero ter contato com a natureza |
|Andrea Bacelar| Preciso variar de atividade física | Meu corpo já se acomodou com as corridas  |
|Andrea Bacelar | Preciso melhorar ainda mais minha capacidade cardiovacular | Quero me inscrever na São Silvestre |
|Alexandre Silveira | Quero saber a quantidade de calórico gastas na atividade proposta | Para controlar minha alimentação e peso  |
|Alexandre Silveira | Quero acompanhar meu índice de massa corporal | Para avaliar a efetividade das pedaladas na perda de peso |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O usuário proponente deverá ser capaz de propor roteiros ciclísticos no site | ALTA | 
|RF-002| O usuário proponente deverá ser capaz de cadastrar informações sobre o roteiro, tais como: local, data, horário, ponto de encontro e grau de dificuldadea | ALTA | 
|RF-003| O usuário proponente deverá ser capaz de cadastrar o link do GoogleMaps para cada um dos roteiros  | ALTA |
|RF-004| O usuário deverá ser capaz de visualizar os roteiros disponíveis no aplicativo Web sem fazer Login | ALTA | 
|RF-005| O usuário deverá ser capaz de fazer a adesão a determinado roteiro escolhido | ALTA |
|RF-006| O usuário proponente deverá ser capaz de cancelar determinado roteiro escolhido | ALTA |
|RF-007| O usuário deverá ser capaz de verificar os roterios que já realizou | MÉDIA |
|RF-008| O usuário deverá ser capaz de verificar o colegas mais frequentes de pedalada | MÉDIA |
|RF-009| O usuário deverá ser capaz de verificar o seu indice de massa corporal | MÉDIA |
|RF-010| O usuário deverá ser capaz de verificar o seu gasto energético após a atividade | MÉDIA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deverá permitir o cadastro de roteiros ciclísticos | ALTA | 
|RNF-002| O site deverá permitir a adesão do usuário ao roteiro desejados | ALTA | 
|RNF-003| O site deverá enviar notificação ao usuário proponente a cada adesão |  MÉDIA | 
|RNF-004| O site deverá permitir pesquisa aos dados cadastrados | MÉDIA | 
|RNF-005| O site deverá calcular o índice de massa corporal | BAIXA | 
|RNF-006| O site deverá calcular o gasto calórico para determinado usuário | BAIXA | 


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 15/06/2023 |
|02| O aplicativo deve envolver às tecnologias da Web backend, banco de dados e armazenamento em nuvem   |
|03| A equipe não pode subcontratar o desenvolvimento do trabalho  |


## Diagrama de Casos de Uso

Para o projeto em desenvolvimento foi elaborado um diagrama de casos de uso considerando 3 atores: o usuário comum, usuário proponente e sistema de login, os requisitos funcionaís e os relacionamentos. 

<img src="/docs/img/casoUso.png" width=100% height=100%>

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

<--
> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
-->
