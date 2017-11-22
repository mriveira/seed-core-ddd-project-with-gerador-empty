# seed-core-ddd-project-with-gerador-empty
Seed vazio para projetos  SPA / DDD / Gerador

-- PRÉ REQUISITOS;

1-) git shell [https://git-for-windows.github.io/]

2-) node.js [https://nodejs.org/en/])

3-) npm install -g @angular/cli

3-) opcional [Conemu [https://www.fosshub.com/ConEmu.html/ConEmuSetup.161206.exe]]




-- SETUP

01-) Clonar esse repositório na pasta C:\Projetos (git clone https://github.com/wilsonsantosnet/seed-core-ddd-project-with-gerador-empty.git)

02-) Abrir solution seed.sln

03-) Compilar projeto

04-) Conferir arquivo ConfigExternalResources.cs no gerador para ver quais repositórios serão clonados, e em quais pastas os arquivos serão copiados

05-) Clicar com botão direito no projeto de gerador e rodar em debug

06-) Escolher a opção 1 (clonar e copiar para aplicação)

07-) Mostrar todos os arquivos no projeto Gerador.Gen (dentro da pasta 7-Gerador)

08-) Incluir na pasta Templates as sub-pastas Back e Front

09-) Selecionar todos os aquivos da pasta Back e Front, clicar com botão direito, clicar em properties e mudar a opção Copy to Output Directory para Copy always

10-) Compilar a solução

12-) Abrir prompt de comando, entrar na pasta Seed.Spa.UI (dentro da pasta 1-Presentation) e rodar o comando "npm install"

13-) Configurar no Gerador.Gen (dentro da pasta 7-Gerador) a classe ConfigContext.cs com as tabelas que serão geradas [linha 46]

14-) Configurar a connection string no arquivo App.config do projeto Gerador.Gen (dentro da pasta 7-Gerador).

15-) Verifica no mesmo arquivo App.Config os caminhos onde serão gerados os arquivos de Back e Front (variaves da chave <appSettings>)

16-) Rodar o gerador com opção 3 (gerar código)

17-) Configurar a connection string no arquivo appsettings.json do projeto Seed.Api (dentro da pasta 2-Services)

18-) Encontrar o arquivo /src/app/global.service.ts no projeto Seed.Spa.Ui (dentro da pasta 1-Presentation). Nesse arquivo existe uma classe chamanda AuthSettings com uma propriedade chamada CLIENT_ID. No construtor dessa classe, a propriedade deve conter o mesmo valor  da propriedade ClientId confirada no arquivo Config.cs do projeto de Sso.Server.Api (dentro da pasta 6-SSO) no método GetClients no item do tipo GrantTypes.Implicit.

19-) Descomentar a linha ".UseStartup<Startup>()" no arquivo Program.cs do projeto Seed.API (dentro da pasta 2-Services)

20-) Descomentar o código de autenticação default e retira o return fora da task no arquivo UserServices.cs do projeto Sso.Server.Api (dentro da da pata 6-SSO)

21-) Remover o ponto e virgula e descomentar as linhas seguintes dentro do método ConfigureServices no arquivo Startup.cs (linha 48) do projeto Sso.Server.Api (dentro da da pata 6-SSO) 
OBS: O método AddSigningCredential (desse mesmo arquivo) só deve ficar descomentado caso vc tenha um certificado digital - nesse caso vc deve descomentar esse método e comentar o método AddTemporarySigningCredential. Caso contrario, comentar o primeiro e descomentar o segundo.

22-) Clicar com botão direito na Solution, clicar na opção Properties, na opção Startup Project escolher Multiple Startup Projects e marcar como START os projetos Seed.Api e Sso.Server.Api

23-) Rodar a aplicação pelo Visual Studio

24-) Abrir o prompt de comando, entrar na pasta Seed.Spa.Ui e rodar o comando "ng serve --open"

