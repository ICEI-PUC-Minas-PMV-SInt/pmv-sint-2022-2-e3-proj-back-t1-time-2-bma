# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Enumere quais cenários de testes foram selecionados para teste. Neste tópico o grupo deve detalhar quais funcionalidades avaliadas, o grupo de usuários que foi escolhido para participar do teste e as ferramentas utilizadas.

Os testes funcionais serão realizados com a utilização do XXXXXX para simular o acesso ao site. Para a segunda etapa, será testada a página de login de acesso do usuário, descrito no Caso de Teste CT-01. Nesse cenário a página será testada por um dos membros da equipe, de preferência aquele que não participo diretamente na construção dessa página. As outras páginas, a serem desenvolvidas na próxima etapa, serão testadas, preferencialmente, pelo administrador de BMA. 

Os testes funcionais a serem realizados no site estão descritos a seguir.

<table> 
  <tr>
   <th>Caso de Teste</th>
   <th> CT-01</th>
  </tr>
 <tr>
   <th>Requisitos associados</th>
   <th> RF-001 Permitir que o usuário faça login de entrada. <br>
        RF-002 Permitir que o usuário faça logoff do sistema.
   </th>
 </tr> 
 <tr> 
  <th> Objetivo do teste</th>
   <th> Verificar se a autenticação do usuário ocorre corretamente.</th>
 </tr>
 <tr> 
  <th> Passos</th>
  <th> 
  <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página de login.</li>
    <li>Efetuar o login.</li>
    <li>Acessar a página autorizada.</li>
    <li>Efetuar o logoff.</li>
   </ol>
   </th>
 </tr>
 <tr> 
  <th> Critérios de Êxito</th>
  <th> 
   <ul> 
    <li>A página de login precisa ser carregada.</li>
    <li>Deve ocorrer a autenticação do usuário.</li>
    <li>Após o login a página autorizada precisa ser carregada.</li>
    <li>A página carregada deve ter acesso ao botão de logoff.</li>
    <li>Após o logoff, a página de login deve ser novamente carregada.</li>    
   </ul> 
   </th>
 </tr>  
 </table>

 <table> 
  <tr>
   <th>Caso de Teste</th>
   <th> CT-02</th>
  </tr>
 <tr>
   <th>Requisitos associados</th>
   <th> RF-003 Permitir que o administrador cadastre os usuários do sistema. <br>
   RF-004 Permitir que o administrador consulte, altere e exclua o cadastro dos usuários do sistema.
   </th>
 </tr> 
 <tr> 
  <th> Objetivo do teste</th>
   <th> Verificar se o cadastro de usuários ocorre corretamente e que todos os campos obrigatórios são cadastrados corretamente.</th>
 </tr>
 <tr> 
  <th> Passos</th>
  <th> 
  <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página de login.</li>
    <li>Efetuar o login.</li>
    <li>Acessar a página de cadastro do funcionário.</li>
    <li>Efetuar o cadastro de funcionários.</li>
   <li>Acessar a página de de funcionários cadastrados.</li>
   <li>Alterar os dados do funcionário cadastrado.</li>
   <li>Efetuar o logoff.</li>
   </ol>
   </th>
 </tr>
 <tr> 
  <th> Critérios de Êxito</th>
  <th> 
   <ul> 
    <li>Após o login a página de cadastro de funcionários precisa ser carregada.</li>
    <li>A página deve apresentar o formulário de cadastro.</li>
    <li>O cadastro de funcionário deve ser realizado.</li>
    <li>A página de funcionários cadastrados deve permitir a alteração dos dados do funcionário.</li>
    <li>A página carregada deve ter acesso ao botão de logoff.</li>
    <li>Após o logoff, a página de login deve ser novamente carregada.</li> 
   </ul> 
   </th>
 </tr>  
 </table>
 
 <table> 
  <tr>
   <th>Caso de Teste</th>
   <th> CT-03</th>
  </tr>
 <tr>
   <th>Requisitos associados</th>
   <th> RF-005 Permitir que o usuário cadastre os beneficiários.<br>
        RF-006 Permitir que o usuário consulte, altere e exclua o cadastro dos beneficiários.<br>
        RF-010 Permitir que o usuário realize a redefinição de senha.<br>
   </th>
 </tr> 
 <tr> 
  <th>Objetivo do teste</th>
  <th> Verificar se ocorre o cadastro de beneficiários e que todos os campos obrigatórios são cadastrados corretamente.</th>
 </tr>
 <tr> 
  <th>Passos</th>
  <th> 
  <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página de login.</li>
    <li>Efetuar o login.</li>
    <li>Acessar a página de cadastro de beneficiário.</li>
    <li>Efetuar o cadastro de beneficiário.</li>
    <li>Acessar a página de beneficiários cadastrados.</li>
    <li>Alterar os dados do beneficiário cadastrado.</li>
    <li>Efetuar o logoff.</li>
   </ol>
   </th>
 </tr>
 <tr> 
  <th> Critérios de Êxito</th>
  <th> 
   <ul> 
    <li>Após o login a página de cadastro de beneficiários precisa ser carregada.</li>
    <li>A página deve apresentar o formulário de cadastro.</li>
    <li>O cadastro do beneficiário deve ser realizado.</li>
    <li>A página de funcionários cadastrados deve permitir a alteração dos dados do beneficiário.</li>
    <li>A página carregada deve ter acesso ao botão de logoff.</li>
    <li>Após o logoff, a página de login deve ser novamente carregada.</li>    
   </ul> 
   </th>
 </tr>  
 </table>
 
 <table> 
  <tr>
   <th>Caso de Teste</th>
   <th> CT-04</th>
  </tr>
 <tr>
   <th>Requisitos associados</th>
   <th> RF-007 Permitir que o usuário registre as retiradas de cestas pelo beneficiário.<br>
        RF-008 Restringir a retirada de cesta, conforme periodicidade estabelecida pelo município.<br>
        RF-009 Permitir que o usuário visualize histórico de retirada dos beneficiários.
   </th>
 </tr> 
 <tr> 
  <th>Objetivo do teste</th>
  <th>Verificar se ocorre o cadastro de retirada de cesta e que todos os campos obrigatórios são cadastrados corretamente.</th>
 </tr>
 <tr> 
  <th>Passos</th>
  <th> 
  <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página de login.</li>
    <li>Efetuar o login.</li>
    <li>Acessar a página de cadastro de cestas.</li>
    <li>Efetuar o cadastro de cesta.</li>
    <li>Acessar os dados das cestas cadastradas.</li>
    <li>Alterar os dados da cesta cadastrada.</li>
    <li>Efetuar logoff.</li>	
   </ol>
   </th>
 </tr>
 <tr> 
  <th> Critérios de Êxito</th>
  <th> 
   <ul> 
     <li>Após o login a página de cadastro de cestas precisa ser carregada.</li>
    <li>A página deve apresentar o formulário de cadastro de retirada de cestas.</li>
    <li>Durante o cadastro, os dados do beneficiário devem ser acessados de acordo com o CPF informado.</li>
    <li>A página deve informar se o beneficiário já retirou a cesta no intervalo de tempo estabelecido pelo município.</li>
    <li>O cadastro da cesta deve ser realizado.</li>
    <li>A área de cestas cadastradas deve permitir a alteração dos dados da entrega de cesta.</li>
    <li>A página carregada deve ter acesso ao botão de logoff.</li>
    <li>Após o logoff, a página de login deve ser novamente carregada.</li>
   </ul> 
   </th>
 </tr>  
 </table>
 
 <table> 
  <tr>
   <th>Caso de Teste</th>
   <th> CT-05</th>
  </tr>
 <tr>
   <th>Requisitos associados</th>
   <th> RF-011	 Consultar data de recebimento de cesta.<br>
        RF-012 Consultar local de retirada de cesta.<br>
        RF-013 Consultar recebimento de cesta<br>

   </th>
 </tr> 
 <tr> 
  <th>Objetivo do teste</th>
  <th>Verificar se ocorre o acesso à página de consulta para retirada de cestas.</th>
 </tr>
 <tr> 
  <th>Passos</th>
  <th> 
  <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página de login do beneficiário.</li>
    <li>Efetuar o login.</li>
    <li>Acessar a página de área do beneficiário.</li>
    <li>Efetuar a consulta das datas e local de retirada de cestas.</li>
    <li>Efetuar logoff.</li>	
   </ol>
   </th>
 </tr>
 <tr> 
  <th> Critérios de Êxito</th>
  <th> 
   <ul> 
     <li>Após o login a página da área do beneficiário precisa ser carregada.</li>
     <li>A página precisa apresentar os dados para a retirada de cesta pelo beneficiário cadastrado.</li>
     <li>A página carregada deve ter acesso ao botão de logoff.</li>
     <li>Após o logoff, a página de login deve ser novamente carregada.</li>
   </ul> 
   </th>
 </tr>  
 </table>
## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
