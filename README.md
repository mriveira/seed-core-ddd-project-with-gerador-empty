# seed-core-ddd-project-with-gerador-empty
Seed vazio para projetos  SPA / DDD / Gerador

-- PRÉ REQUISITOS;

1-) git shell [https://git-for-windows.github.io/]

2-) node.js [https://nodejs.org/en/])

3-) npm install -g @angular/cli

3-) opcional [Conemu [https://www.fosshub.com/ConEmu.html/ConEmuSetup.161206.exe]]

-- SETUP


1-) Clonar Esse Rep na pasta C:\Projetos (git clone https://github.com/wilsonsantosnet/seed-core-ddd-project-with-gerador-empty.git)

2-) abrir solution seed.sln

3-) compilar projeto

4-) Conferir arquivo ConfigExternalResources no greador para ver quais repositórios serão clonados, e em quais pastas os arquivos serão copiados

5-) Clicar com botão direito no projeto de gerador e rodar em debug

6-) escolher a opção 1 (clonar e copiar para aplicação)

7-) No projeto Gerador.Gen Mostar Todos os Arquivos 

8-) Incluir na pasta templates as pastas Back e Front

9-) Selecionar todos os aquivos da pasta Back e Front, clicar com botão direito , opção property e marcar para Copiar Sempre (Copy Always)

10-) Compilar

12-) abrir prompt de comando entrar na pasta Seed.Spa.UI rodar npm install 

13-) no gerador configurar a classe ConfigContext com as tabelas que serão geradas [linha 46]

14-) Configurar connection string no gerador app.config.

15-) Verifica no arquivo App.Config os caminhos onde serão gerador os arquivos de Back e front variaves de appSettings

16-) Rodar gerador opção 3 (gerar código)

17-) no projeto Seed.Api pasta Services configurar a connectionstring do arquivo appsettings.json

18-) No projeto Seed.ui pasta Presentation, encontrar o arquivo /src/app/global.service.ts, nesse arquivo existe uma classe chamanda AuthSettings com uma propriedade chamada CLIENT_ID, essa propriedade deve conter o valor  da propriedade ClientId confirada no item do tipo implicit, no método GetClients do arquivo Config.cs do projeto de Sso.Server.Api da pata SSO\Auth 

19-) No projeto de Seed.API da pasta Services no arquivo  Program descomentar  essa linha ".UseStartup<Startup>()"

20-) No projeto de Sso.Server.Api da pata SSO\Auth no arquivo UserServices descomentar código de autenticação defualt e retira o return fora da task

21-) No projeto de Sso.Server.Api da pata SSO\Auth no arquivo Startup.cs na linha AddIdentityServer , remover o ponto e virgula e descomentar as linhas baixo

22-) o método AddSigningCredential desse mesmo arquivo, só deve ficar descomentado caso vc tenha um certificado digital ,nesse caso vc descomenta esse método e comenta o método AddTemporarySigningCredential. caso contrario comenta o primeiro e descomenta o segundo

23-) Clicar com botão direito na Solution , item propertys, startuo Project , escolher Multiple Startup Project e marcar como start os projetos de Seed.Api / Sso.Server.Api

24-) entra na pasta Seed.Spa.Ui e rodar no prompt de comando ng serve --open

