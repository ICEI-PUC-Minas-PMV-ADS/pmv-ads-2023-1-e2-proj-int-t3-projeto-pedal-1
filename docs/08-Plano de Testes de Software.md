# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome completo, endereço, altura, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-002	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Informações na página inicial	|
|Requisito Associado | RF-003	-  A aplicação deverá apresentar na página principal todos os roteiros propostos por outros usuários. Com o dia, data e local, antes de logar. |
| Objetivo do Teste 	| Verificar se as informações aparecem corretas na página inicial. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Verificar roteiros propostos por outros usuários. <br> 
|Critério de Êxito | - As informações estão corretas. |
|  	|  	|
| Caso de Teste 	| CT-04 – Validação de senha	|
|Requisito Associado | RF-004	- O sistema deverá validar as informações inseridas pelo usuário no momento do login |
| Objetivo do Teste 	| Verificar se o usuário inseriu as informações corretas e validar a senha. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> -Informações inseridas da forma certa <br> Validação das infomações inseridas pelo usuário. |
|Critério de Êxito | - Validação de senha concluída.  |
|  	|  	|
| Caso de Teste 	| CT-05 – Mensagem de erro.	|
|Requisito Associado | RF-005	- A aplicação deverá apresentar mensagem de erro, caso o usuário cadastrado não insira as informaões conforme informou no cadastro. |
| Objetivo do Teste 	| Verificar se o sistema validou as informações. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> Validação de informações. <br> Informações inseridas de forma incorreta. <br> Exibir mensagem de erro.  |
|Critério de Êxito | - Informações de cadastro validadas com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-06 – Roteiros no perfil do usuário cadastrado.	|
|Requisito Associado | RF-006	- Após fazer o login, o sistema deve mostrar os roteiros propostos com seus respectivos inscritos. |
| Objetivo do Teste 	| Verificar se as informações aparecem no perfil dos usuários.  |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br>  - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> Fazer validação de cadastro. <br> - Acessar os percursos através do seu perfil <br> |
|Critério de Êxito | - Os roteiros aparecem da forma correta. |
|  	|  	|
| Caso de Teste 	| CT-07 – Quadro de premiações	|
|Requisito Associado | RF-007	- O sistema deve mostrar o quadro de medalhas. |
| Objetivo do Teste 	| Verificar se o quadro esta correto e se as infromações inseridas também estão corretas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> Fazer validação de cadastro. <br> - Verificar quadro na página inicial do site. <br> |
|Critério de Êxito | - Usuário conseguiu acessar o quadro de medalhas. |
|  	|  	|
| Caso de Teste 	| CT-08 – Cadastro de roteiros.	|
|Requisito Associado | RF-008	- O usuário proponente deverá cadastrar roteiros. |
| Objetivo do Teste 	| O usuário deve conseguir cadastrar roteiros no seu perfil. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Fazer validação de cadastro <br> - Propor roteiros no seu perfil. <br>  |
|Critério de Êxito | - Os roteiros foram propostos com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-09 – Cancelamento de roteiros	|
|Requisito Associado | RF-009	- O usuário proponente deverá cancelar roteiros. |
| Objetivo do Teste 	| Verificar se o usuário consegue cancelar os roteiros. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Fazer validação de cadastro <br> - Cancelar roteiro, quando o usuário julgar necessário. |
|Critério de Êxito | - Cancelamento realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-10 – Cancelamento de usuários.	|
|Requisito Associado | RF-010	- O usuário proponente deverá cancelar a adesão do usuário faltoso na atividade. |
| Objetivo do Teste 	| Verificar se o usuário consegue fazer o cancelamento dos usuário que faltaram nas atividades. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> -Fazer validação de cadastro <br> - Acessar o perfil do usuário, onde a atividade esta cadastrada <br> - Fazer o cancelamento do usuário na atividade |
|Critério de Êxito | - O cancelamento do usuário na atividade foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-11 – Cadastro do horário do inicio e do fim da atividade.	|
|Requisito Associado | RF-011	- O usuário proponente deverá cadastrar o horárico de início e fim do roteiro executado. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar os horários. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Fazer validação de cadastro <br> - Acessar o perfil do usuário, onde o roteiro está cadastrado <br> - Cadastrar os horários de inicío e do fim da atividade |
|Critério de Êxito | - Os horários foram cadastrados com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-12 – Adesão aos roteiros	|
|Requisito Associado | RF-012	- O usuário deverá aderir à determinado roteiro.  |
| Objetivo do Teste 	| Verificar se o usuário consegue aderir aos roteiros de outros usuários. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Fazer validação de cadastro <br> - Acessar os roteiros na página inicial do sistema. <br> - Fazer adesão ao roteiro que se identifica. |
|Critério de Êxito | - A adesão ao roteiro desejado foi feita com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-13 – Cancelamento de atividade.	|
|Requisito Associado | RF-013	- O usuário deverá cancelar sua adesão à determinado roteiro. |
| Objetivo do Teste 	| Verificar se o usuário consegue cancelar ativiade. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Fazer validação de cadastro <br> - Acessar ao roteiro escolhido <br> - Fazer o cancelamento da atividade. |
|Critério de Êxito | - O cancelamento da atividade foi feito com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-14 – Roteiros já executados.	|
|Requisito Associado | RF-014	- O usuário deverá pesquisar os roteiros já realizados. |
| Objetivo do Teste 	| Verificar se o usuário consegue acessar aos roteiros já executados. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> -Fazer validação do cadastro <br> - Acessar a barra de pesquisa  <br> - Encontrar roteiros realizados anteriormente. |
|Critério de Êxito | - O usuário conseguiu encontrar os roteiros desejados. |
|  	|  	|
| Caso de Teste 	| CT-15 – Localizar os colegas companheiros	|
|Requisito Associado | RF-015	- O usuário deverá pesquisar os colegas de pedal mais companheiros. |
| Objetivo do Teste 	| Verificar se o usuário consegue localizar os colegas mais companheiros para os percursos. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> -Fazer validação do cadastro <br> - Acessar a barra de pesquisa  <br> - Encontrar colegas companheiros. |
|Critério de Êxito | - O usuário conseguiu localizar os colegas companheiros. |
|  	|  	|
| Caso de Teste 	| CT-16 – Obter índice de massa corporal	|
|Requisito Associado | RF-016	- O usuário deverá obter o seu índice da massa corporal. |
| Objetivo do Teste 	| Verificar se o usuário consegue obter seu índice de massa corporal. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Fazer validação do cadastro <br> - Preencher o campo do peso <br> - Preencher o campo altura <br> |
|Critério de Êxito | - O usuário conseguiu acessar seu índice de massa corporal. |
|  	|  	|
| Caso de Teste 	| CT-17 – Gasto calórico	|
|Requisito Associado | RF-017	- O usuário deverá obter o seu gasto calórico em cada roteiro realizado. |
| Objetivo do Teste 	| Verificar se o usuário consegue ter acesso a informação do seu gasto calórico. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Fazer validação do cadastro <br> Clicar em "Login" <br> Inserir altura <br> Inserir peso <br> Clicar em "ok".|
|Critério de Êxito | - O usuário conseguiu acessar as informações com sucesso.  |


 

