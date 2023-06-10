# TutorialCrystalReport
Tutorial Crystal Report WebForms
Primeiro, é necessário baixar e instalar as extensões de uma ferramenta que cria o design do Crystal Report no .NET. Foram utilizadas as seguintes extensões da SAP: SAP Crystal Report Runtime e Crystal Reports for Visual Studio. Você pode encontrar essas extensões neste link: https://www.sap.com/cmp/td/sap-crystal-reports-visual-studio-trial.html

Após isso, você pode criar a aplicação web da sua preferência. Eu criei um aplicativo web ASP.NET (Framework 4.6.1) usando Web Forms. Em seguida, você pode criar uma tela .aspx e seguir os passos abaixo.

Adicionando conexão com o banco de dados e o Crystal Report (SQL Server):
No Explorador de Campo (caso não esteja visível no lado esquerdo do Visual Studio, você pode encontrá-lo no menu Exibir, que fica na barra de ferramentas do Visual Studio):

* Clique com o botão direito do mouse em "Campos de Banco de Dados" > "Auxiliar do Banco de Dados".
* Um menu chamado "Assistente do Banco de Dados" será aberto. Clique em "Criar Nova Conexão".
* Clique no "+" em "OLE DB (ADO)" e selecione a opção "SQL Server Native Client 11.0".
* Um formulário será exibido para que você possa inserir as informações do seu servidor.
* Preencha os campos:
    * Servidor: insira o nome do seu servidor. Caso seja local, pode ser "localhost" dependendo da sua configuração.
    * Caso suas credenciais de segurança estejam atreladas ao certificado do Windows, marque a opção "Segurança Integrada".
    * No campo "Banco de Dados", digite o nome do seu banco de dados.
* Após preencher as informações, siga adiante e conclua a configuração.
* Depois de concluir a configuração da conexão, sua nova conexão, no meu caso "localhost", aparecerá em "OLE DB (ADO)".
* Agora você pode selecionar a tabela desejada, que será utilizada no formulário do Crystal Report.
* Feito isso, as colunas da tabela selecionada aparecerão no Explorador de Campo > "Campos de Banco de Dados". Basta arrastar as colunas desejadas para o design do Web Forms.
Pronto! As configurações para o design do seu Crystal Report estão completas.

Para gerar o relatório via arquivo .aspx:

* Crie uma tela com uma ação do Web Forms.
* Importe os pacotes necessários:
    * using CrystalDecisions.CrystalReports.Engine;
    * using CrystalDecisions.Shared;
    * using System.IO;
* Crie a conexão com o banco de dados e faça a consulta da tabela desejada para um DataTable.
* Mapeie o DataTable para o documento (DataSource).
* Exporte o resultado para o caminho escolhido. No exemplo apresentado, foi escolhida a área de trabalho do Windows.
* Espero que essas instruções sejam úteis para você! Se tiver alguma dúvida, estou à disposição.
