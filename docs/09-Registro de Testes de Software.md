# Registro de Testes de Software

Nesta etapa de trabalho é realizado o registro dos testes propostos no item plano de testes. Foram realizado testes de inserção de novos usuário e proponente de roteiro, teste de inserção de novo roteiro e teste de adesão a determinado roteiro por vários usuários.  


## Teste de Inserção de Novo Usuário


Inicialmente foi realizado teste para inserção de um usuário no banco de dados. Foi inserido o registro Ricardo Lemos.
Na figura a seguir a imagem da esquerda corresponde a interface para inserção do novo registro e as imagens da direita a tela index antes (superior) e depois (inferior) da inserção do novo usuário.

<img src="/docs/img/teste_5.png" width=100% height=100%>

<br><br>
A figura a seguir apresenta "prints" da tabela usuário do banco de dados antes e depois da inserção do registro número 24 Ricaardo Lemos. <br>

<img src="/docs/img/teste_6.png" width=100% height=100%>

## Teste de Inserção de Novo Proponente de Roteiro

Inicialmente foi realizado teste para inserção de proponente de roteiros na aplicação web. Foi inserido o registro Sergio Penido
Na figura a seguir a imagem da esquerda corresponde a interface para inserção do novo registro e as imagens da direita a tela index antes (superior) e depois (inferior) da inserção do registro.
 
<img src="/docs/img/teste_3.png" width=100% height=100%>

<br><br>
A figura a seguir apresenta "prints" da tabela Proponentes antes e depois da inserção do registro 6 (Sergio Penido). 
<br>
<img src="/docs/img/teste_4.png" width=100% height=100%>



## Teste de Inserção de Novo Roteiro

Neste teste foi inserido um novo roteiro na aplicação. Foi inserido uma atividadde noturna no Prado. 
Na figura abaixo a imagem da esquerda mostra a interface para criação de um novo roteiro e as imanges da direita apresenta a tela Roteito/Index antes (superior) e depois (inferior) da inserção do registro. 

<img src="/docs/img/teste_1.png" width=100% height=100%>

<br><br>
A figura a seguir apresenta "prints" da do banco de daodos antes e depois da inserção do registro 5 (Prado).
<br>
<img src="/docs/img/teste_2.png" width=100% height=100%>


## Teste de Adesão a um Roterio por vários Usuário

A adesão de determinado usuário a um roterio foi testada nesta etapa. Com os conteúdos das tabelas usuário e roteiros foi ralizada a adesão. 
Na figura a seguir a imagem da esquerda mostra a interface para realização da adesão e as imanges da direita acima apresenta a tabela Muitos-para-Muitos no banco de dados e abaixo as relações já estabelecidas entre usuários e o roteiro "Santa Tereza".

<img src="/docs/img/teste_7.png" width=100% height=100%>


## Avaliação

Os testes de software realizados mostraram o desempenho satisfatório para muitas das funcionalidaddes básicas da aplicação. Falta ainda os itens abaixo para implementação e testes:
- Login
- Segurança
- Implementação das regras de negócio
- Utilização do template padrão da aplicação.

