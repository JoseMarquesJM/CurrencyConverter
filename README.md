# CurrencyConverter

CurrencyConverter é um aplicativo projetado para facilitar a conversão de moedas. Ele fornece uma interface simples e intuitiva para converter valores entre diversas moedas globais, utilizando taxas de câmbio atualizadas.


# Recursos Principais

Conversão de moedas em tempo real: Converta entre diferentes moedas com base nas taxas de câmbio mais recentes.

Suporte a múltiplas moedas: Trabalhe com uma ampla variedade de moedas de todo o mundo.

Interface intuitiva: Uma experiência de usuário limpa e simples, adequada para iniciantes e especialistas.

Histórico de conversões: Visualize conversões passadas (se habilitado).


# Tecnologias Utilizadas

Plataforma: Blazor Server (ou Blazor WebAssembly, se aplicável).

Linguagem de programação: C# (.NET 8).

Serviço de taxas de câmbio: Integração com APIs externas para obter taxas atualizadas.

Estilização: MudBlazor para uma interface moderna e responsiva.


# Como Executar o Projeto

Requisitos

.NET SDK 8.0 ou superior

Um editor de código como Visual Studio ou Visual Studio Code

Conexão com a internet para acessar taxas de câmbio

# Instalação

Clone este repositório para sua máquina local:

git clone https://github.com/seu-usuario/CurrencyConverter.git

Navegue até a pasta do projeto:

cd CurrencyConverter

Restaure as dependências:

dotnet restore

Execute o projeto:

dotnet run

Abra seu navegador e acesse https://localhost:5001 (ou a URL indicada no console).

# Estrutura do Projeto

Pages/ - Contém as páginas do Blazor.

Services/ - Contém serviços para integração com APIs externas e lógica de negócio.

wwwroot/ - Contém arquivos estáticos, como CSS e imagens.

Data/ - Contém classes de modelos e dados.

# Funcionalidades Futuras

Gráficos de tendência para taxas de câmbio.

Suporte a conversões offline com taxas armazenadas localmente.

Notificações sobre alterações significativas nas taxas de câmbio.

# Contribuição

Contribuições são bem-vindas! Para contribuir:

Faça um fork deste repositório.

Crie um branch para sua funcionalidade ou correção de bug: git checkout -b minha-feature.

Faça commit das suas alterações: git commit -m 'Minha nova feature'.

Envie para o branch principal: git push origin minha-feature.

Abra um pull request.

# Licença

Este projeto está licenciado sob a Licença MIT.
