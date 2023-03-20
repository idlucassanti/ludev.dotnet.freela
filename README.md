# PARTE 1: PROJETO

Vantagens e Desvantagens das ferramentas.

Identificar e aplicar boas práticas, identificar e corrigir as más.

Compreender e justificar cada decisão.


Qual o Problema a ser resolvido?
Entender o Domínio e como esse Domínio resolve o Problema do Cliente.


## Projeto DevFreela

Plataforma para cadastro e contratação de serviços de Freelance de desenvolvedores.

API completa para implementar as funcionalidades necessárias para um sistema desse tipo.

- CRUD de Serviço de Freelance.
- CRUD de Usuários e Perfis Freelance e Cliente(criar permissões).
- Comentários para um Serviço.
- Definir, iniciar e finalizar o Projeto.

Fluxo Principal

O Cliente publica uma oportunidade de projeto na plataforma.
Um Freelancer encontra essa oportunidade, e troca mensagens como Cliente.
Acertada as condições, o cliente seleciona o Freelancer como profissional escolhido e inicia o projeto.
Vão ser adicionadas mensagens ao projeto, sobre o avanço.
O projeto poderá ser concluído e o Freelancer terá seu saldo atualizado, bem como seu perfil.


## Modelagem de Domínio

Modelagem para aplicar no início de qualquer projeto que será iniciado.

Técnica de Narrativa descrevendo o mais fiel possível ao usuário.



""
Análise:
- Clientes, Freelancers e Projetos são substantivos.
- Contratar serve como funcionalidade do sistema.


""
- Definir as caracteristicas dos Projetos => CRUD.
- Publicam => Cadastrar o projeto na plataforma.
- Comunicam é um verbo.


""
- Clientes iniciam => Ação/Funcionalidade do sistema
- Interagir => Entidade Mensagem surge. Ação/Funcionalidade do sistema.
- Concluir o projeto => Ação/Funcionalidade do sistema.



Entidades:

- Clientes/Freelancers
- Projetos
- Habilidades
- Mensagem


Ações:
- Definir, Iniciar e Terminar os projetos.
- Cliente e Freelancer se comunicam.
- Definição de Habilidade de um Freelancer.


Em resumo: A narrativa permite facilitar a modelagem de domínio de maneira mais fiel possível ao domínio. Entender melhor como funciona o domínio.



# PROTOCOLO HTTP

- O que é o protocolo HTTP
- Cabeçalho HTTP
- Status Code HTTP
- Verbos HTTP









- Requisições HTTP

- Protocolo base para a comunicação de dados na internet, permitindo obter recursos como páginas HTML.
- Quando desenvolvemos uma API, permitindo o acesso aos seus recursos, geralmente através do protocolo HTTP.

Informações complementares a respeito da requisição HTTP

- Content-Length: tamanho
- Content-Type: tipo
- Cache-Control: estratégia de cache (armazenar no site ou nao)
- Status : stauts
authorization



Status HTTP => 

Sucesso

200 => OK => retorna objeto
201 => Created => resultado foi a criação de um recurso no sistema
202 => Accepted => requisição foi mas ainda não foi concluida com sucesso, falta processamento (fila de mensageria)
204 => No Content => requisição foi um sucesso mas não tem uma resposta necessária (PUT, DELETE)


Erro da requisição

400 => Bad Request => Alguma informação de entrada(input) enviada para API não está
401 => Unauthorized => Requisição não está com usuário ou senha ou não não tem altorização
404 => Not Found => Recurso não foi encontrado => Recurso nao encontrado


Erro do sistema

500 => Internal Server Error


Verbos HTTP =>


Representa ações dentro em cima de um Recurso HTTP

GET => Consultar retorna status 200 ou 404. Não altera estado do Sistema.


POST => Criação de um Recurso => Retorna 201 caso seja criado com sucesso ou 400 caso encontrado alguma falha.


PUT => Atualização de Recurso => Retornando 204, 400 ou 404.


DELETE => Retorna 204 ou 404.


# API REST

- O que é API REST

- Caracteristicas

Padrão de comunicação entre sistemas geral para simplificar os pontos de acesso entre sistemas.

- Baseado em Recursos (entidades do sistema que podem dispor da api)



Exemplos de URLs seguindo padrão REST para acesso de recursos:

api/users/1 => GET, PUT, DELETE => (recurso único)
api/projects => GET, POST => (conjunto de projetos)
api/skills => GET, POST
api/users/1/projects => GET, POST

Maneiras diferentes, mas ambas representam o padrão REST






# ASP.NET CORE CLI

dotnet new sln -n Ludev.Freela

dotnet new webapi -n Ludev.Freela.API -o Ludev.Freela.API

dotnet sln add ./Ludev.Freela.API/Ludev.Freela.API.csproj


dotnet build







# ASP.NET CORE: Controllers
Controllers => Agrupa todas as ações relacionadas a um recurso específicado.

Controller é uma subclasse de ControllerBase, ou seja, herda de ControllerBase suas caracteristicas


- Todo Controlador Herda de ControllerBase
- Todo Controlador precisa definir a Rota Base para disponibilizar as ações do recurso.

- Agrupar todas as Actions de um recurso.

# ASP.NET CORE: Actions

- Verbo HTTP
- Parâmetros
- Respostas

Actions são os métodos que estão dentro de um Controlador

- Os métodos Actions retorna o tipo IActionResult, que é uma interface implementada pelas respostas do padrão HTTP.
- IActionResult implementa os métodos de Retorno HTTP.


Parâmetros

- Parâmetros de URL => Geralmente, parâmetros de URL é para identificadores únicos de um recurso.

- Query String => "?" após URL => Filtros e Buscas

- Corpo da Requisição => 






Action GET
- 
- Parâmetros: URL e QueryString
- Retorna: Ok ou NotFound


Action POST
- Verbo HTTP: POST
- Parâmetros: Apenas Corpo da Requisição
- Retorna: Created ou BadRequest

Action PUT
- Verbo HTTP: PUT
- Parâmetros: URL e Corpo da Requisição
- Retorna: NoContent ou BadRequest

Pode alterar apenas alguns campos do objeto para atualização.


Action DELETE
- Verbo HTTP DELETE
- Parâmetros: Apenas URL
- Retorna: NoContet ou NotFound




# ASP.NET CORE: Rotas

Definida pela anotação Route, influência na disponibilização de todos os pontos de acessos aos recursos de todos os Controladores da API.


Para APIs, o padrão é utilizar "api/[controller]"


[Route("api/projects")]


# ASP.NET CORE: Swagger

O que é Swagger => Ferramenta utilizada bastante durante do desenvolvimento de sofware por facilitar

- Documentar API => visualziar dos pontos de acesso disponibilizados pela API.


Gerar uma interface gráfica contendo todos os pontos de acesso(endpoints) da API organizado por Controlador.

Permite realizar requisições para os endpoints diretamente da ferramenta.

Testar as APIs e ter visão Macro de todos os pontos de acesso da API.










# ASP.NET CORE: 

Quais são as funcionalidades?

- CRUD de Projetos
- Cadastrar Usuário de acordo com seu Tipo de Perfil

- Criar os pontos de acesso do Usuário


# ASP.NET CORE: Configurações

.NET Core permite carregar configurações da aplicação de vários lugares diferentes, ambos através da interface IConfiguration

Através da interface IConfiguration é possível carregar as configurações do appsettings.json dentro de qualquer lugar da Aplicação via Injeção de Dependência.


Exemplo de locais que armazenam configurações de uma Aplicação:

- Arquivos de configurações, como: appsettings.json
- Variáveis de ambiente
- Argumentos de linha de comando
- Da núvem Azure, como configurações de Aplicativo e pelo Azure Key Vault.


Prática:

- Classe modelo de configurações: AppSettings.cs
- Configurar via ServiceCollection: services.Configure<AppSettings>(Configuration.GetSection("Settings"));
- Disponbilizar na classe via interface IOptions<AppSettings> no construtor da classe.

Cria uma instancia da classe AppSettings disponbilizando por toda aplicação.



É possível carregar diferentes versões do arquivo de configuração, de acordo com o ambiente, que é devido pela variável de ambiente ASPNETCORE_ENVIRONMENT.


ex:

- appsettings.Development.json
- appsettings.Staging.json
- appsettings.Productin.json


Padrão: Classe de Configuração


A internface IConfiguration permite obter as configurações definidas no arquivo appsettings.json


services.Configure<>();

IOptions<AppSettings> 


_options = options.Value;


Incluir classe com Configurações da Aplicações do AppSettings




Obter Configurações do arquivo appsettings.json








# .NET CORE: Injeção de Dependência

Inserir uma dependencia de um objeto através do construtor.
No aspnet core é feito isso de maneira nativa pela classe Startup.

Melhora a qualidade do código, uma vez que tira dependencia interna do código jogando para o construtor.

Isso fica mais claro quando trabalha com testes unitáiros

Essa técnica deixa o código mais testável.

Ciclo de Vida

- Singleton => Mesma instancia para TODA a aplicação.
- Scoped => UMA instancia por CADA requisição.
- Transient => UMA instancia por CLASSE.




Criamos uma instancia do objeto dentro do ciclo de vida da aplicação.


- Protocólo HTTP
- Padrão REST
- História do ASP.NET Core
- Comandos CLI
- Pontos de Acesso
- Controllers
- Actions
- Rotas[Route]
- Swagger
- Criação dos Endpoints
- Criação das ações do usuário
- Criação das funcionalidades
- Configurações de Ambiente
- Variável de Ambiente
- Classe que representa a configuração
- Injeção de Dependência
- Ciclo de vida dos objetos(Singleton, Scoped e Transient)

# PARTE 3: ARQUITETURA LIMPA

# PARTE 4: PERSISTENCIA COM EF

# PARTE 5: CQRS(COMMAND QUERY RESPONSABILITY SEGREGATION)

# PARTE 6: PADRÃO REPOSITORY

# PARTE 7: VALIDAÇÃO DE APIs

# PARTE 8: AUTORIZAÇÃO E AUTENTICAÇAÕ COM JWT

# PARTE 9: TESTES UNITÁRIOS COM xUNIT

# PARTE 10: AZURE DEVOPS

# PARTE 11: MICROSSERVIÇOS E MENSAGERIA