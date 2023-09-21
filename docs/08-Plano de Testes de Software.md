# Plano de Testes de Software

Nesta seção são apresentados os planos de teste de software.
<br>
<br>
<table style="border-collapse: collapse;">
  <tr>
    <th style="border: 1px solid white; padding: 10px;">Caso de teste</th>
    <td style="border: 1px solid black; padding: 10px;">CT-01: Registro de Despesas</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Requisitos</th>
   <td style="border: 1px solid black; padding: 10px;">RF-01: Os usuários devem poder registrar despesas em categorias (alimentação, transporte, moradia, entretenimento).</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Objetivo de teste</th>
   <td style="border: 1px solid black; padding: 10px;">Verificar se os usuários conseguem registrar despesas em categorias especificadas.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Passos</th>
   <td style="border: 1px solid black; padding: 10px;">Faça login na plataforma.
Acesse a função de registro de despesas.
Escolha uma categoria de despesa (por exemplo, "alimentação").
Insira o valor da despesa.
Adicione uma descrição opcional.
Clique em "Registrar".</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Critérios de êxito</th>
   <td style="border: 1px solid black; padding: 10px;">A despesa é registrada com sucesso na categoria selecionada.
O valor da despesa é armazenado corretamente.
A descrição (se fornecida) é armazenada corretamente.</td>
  </tr>
</table>
<br>
<br>
<table style="border-collapse: collapse;">
  <tr>
    <th style="border: 1px solid white; padding: 10px;">Caso de teste</th>
    <td style="border: 1px solid black; padding: 10px;">CT-02 - Comparação de Receitas e Despesas</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Requisitos</th>
   <td style="border: 1px solid black; padding: 10px;">RF-02 - Os usuários devem poder comparar suas receitas e despesas.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Objetivo de teste</th>
   <td style="border: 1px solid black; padding: 10px;">Verificar se os usuários podem visualizar uma comparação clara entre suas receitas e despesas.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Passos</th>
   <td style="border: 1px solid black; padding: 10px;">Faça login na plataforma.
Acesse a função de comparação de receitas e despesas.
Visualize o gráfico ou tabela de comparação.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Critérios de êxito</th>
   <td style="border: 1px solid black; padding: 10px;">Os dados de receita e despesa são exibidos corretamente no gráfico ou tabela.
O usuário pode entender facilmente a diferença entre ganhos e gastos.</td>
  </tr>
</table>
<br>
<br>
<table style="border-collapse: collapse;">
  <tr>
    <th style="border: 1px solid white; padding: 10px;">Caso de teste</th>
    <td style="border: 1px solid black; padding: 10px;">CT-03 - Teste de Usabilidade</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Requisitos</th>
   <td style="border: 1px solid black; padding: 10px;">RNF-03 - A plataforma deve ser fácil de usar.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Objetivo de teste</th>
   <td style="border: 1px solid black; padding: 10px;">Avaliar a facilidade de uso da plataforma.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Passos</th>
   <td style="border: 1px solid black; padding: 10px;">Recrute um grupo de usuários reais representativos.
Peça aos usuários para realizar tarefas comuns, como registrar uma despesa.
Observe o feedback e a interação dos usuários com a interface.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Critérios de êxito</th>
   <td style="border: 1px solid black; padding: 10px;">A maioria dos usuários deve ser capaz de concluir as tarefas sem dificuldade significativa.
O feedback dos usuários sobre a interface deve ser principalmente positivo.</td>
  </tr>
</table>
<br>
<br>
<table style="border-collapse: collapse;">
  <tr>
    <th style="border: 1px solid white; padding: 10px;">Caso de teste</th>
    <td style="border: 1px solid black; padding: 10px;">CT-04: Teste de Desempenho</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Requisitos</th>
   <td style="border: 1px solid black; padding: 10px;">RNF-04: A plataforma deve funcionar sem problemas sob carga.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Objetivo de teste</th>
   <td style="border: 1px solid black; padding: 10px;">Avaliar o desempenho da plataforma sob carga.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Passos</th>
   <td style="border: 1px solid black; padding: 10px;">Crie um cenário de teste que simule um grande número de usuários acessando simultaneamente.
Monitore o tempo de resposta da plataforma.
Avalie como a plataforma lida com picos de tráfego.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Critérios de êxito</th>
   <td style="border: 1px solid black; padding: 10px;">O tempo de resposta não deve exceder um limite aceitável sob carga máxima.
A plataforma deve ser capaz de lidar com picos de tráfego sem falhas críticas.</td>
  </tr>
</table>
<br>
<br>
<table style="border-collapse: collapse;">
  <tr>
    <th style="border: 1px solid white; padding: 10px;">Caso de teste</th>
    <td style="border: 1px solid black; padding: 10px;">CT-05 - Teste de Segurança</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Requisitos</th>
   <td style="border: 1px solid black; padding: 10px;">RNF-05 - A plataforma deve garantir a segurança dos dados do usuário.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Objetivo de teste</th>
   <td style="border: 1px solid black; padding: 10px;">Verificar a robustez da segurança da plataforma.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Passos</th>
   <td style="border: 1px solid black; padding: 10px;">Tente acessar a plataforma sem fazer login.
Tente fazer login com credenciais inválidas.
Tente injetar código malicioso em campos de entrada.
Tente acessar dados de outros usuários.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Critérios de êxito</th>
   <td style="border: 1px solid black; padding: 10px;">O acesso não autorizado é impedido, e o sistema exibe mensagens de erro apropriadas.
O sistema não permite a injeção de código malicioso.
Os dados de usuários são estritamente protegidos e não podem ser acessados por outros usuários.</td>
  </tr>
</table>
<br>
<br>
<table style="border-collapse: collapse;">
  <tr>
    <th style="border: 1px solid white; padding: 10px;">Caso de teste</th>
    <td style="border: 1px solid black; padding: 10px;">CT-06: Teste de Compatibilidade</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Requisitos</th>
   <td style="border: 1px solid black; padding: 10px;">RNF-06: A plataforma deve funcionar em diferentes navegadores e dispositivos.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Objetivo de teste</th>
   <td style="border: 1px solid black; padding: 10px;">Verificar a compatibilidade da plataforma.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Passos</th>
   <td style="border: 1px solid black; padding: 10px;">Acesse a plataforma usando diferentes navegadores (Chrome, Firefox, Safari, Edge).
Acesse a plataforma em dispositivos móveis (iOS e Android).
Verifique a responsividade da interface em telas de diferentes tamanhos.
</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Critérios de êxito</th>
   <td style="border: 1px solid black; padding: 10px;">A plataforma é totalmente funcional e exibe corretamente em todos os navegadores testados.
A interface se adapta corretamente a diferentes tamanhos de tela em dispositivos móveis.</td>
  </tr>
</table>
<br>
<br>
<table style="border-collapse: collapse;">
  <tr>
    <th style="border: 1px solid white; padding: 10px;">Caso de teste</th>
    <td style="border: 1px solid black; padding: 10px;">CT-07 - Teste de Backup e Recuperação</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Requisitos</th>
   <td style="border: 1px solid black; padding: 10px;">RNF-07 - A plataforma deve ser capaz de fazer backup e recuperar dados em caso de falhas.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Objetivo de teste</th>
   <td style="border: 1px solid black; padding: 10px;">Verificar a capacidade da plataforma de fazer backup e restaurar dados.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Passos</th>
   <td style="border: 1px solid black; padding: 10px;">Simule uma falha de sistema.
Tente recuperar os dados após a falha.
Verifique se os dados são restaurados com sucesso.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Critérios de êxito</th>
   <td style="border: 1px solid black; padding: 10px;">A plataforma deve ser capaz de fazer backup regularmente.
Os dados devem ser recuperados com sucesso após uma falha.
</td>
  </tr>
</table>
<br>
<br>
<table style="border-collapse: collapse;">
  <tr>
    <th style="border: 1px solid white; padding: 10px;">Caso de teste</th>
    <td style="border: 1px solid black; padding: 10px;">CT-08 - Teste de Documentação</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Requisitos</th>
   <td style="border: 1px solid black; padding: 10px;">RNF-08 - A documentação do software deve estar completa e precisa.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Objetivo de teste</th>
   <td style="border: 1px solid black; padding: 10px;">Avaliar a qualidade da documentação.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Passos</th>
   <td style="border: 1px solid black; padding: 10px;">Revise a documentação do usuário.
Verifique se a documentação técnica está disponível e detalhada.
Tente seguir as instruções da documentação para realizar tarefas comuns.</td>
  </tr>
  <tr>
   <th style="border: 1px solid white; padding: 10px;">Critérios de êxito</th>
   <td style="border: 1px solid black; padding: 10px;">A documentação do usuário deve ser clara e compreensível.
A documentação técnica deve ser abrangente e precisa.
As instruções da documentação devem levar a resultados corretos.</td>
  </tr>
</table>

<!-- <span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Enumere quais cenários de testes foram selecionados para teste. Neste tópico o grupo deve detalhar quais funcionalidades avaliadas, o grupo de usuários que foi escolhido para participar do teste e as ferramentas utilizadas.
 
## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7) -->
