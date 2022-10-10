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

 
## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
