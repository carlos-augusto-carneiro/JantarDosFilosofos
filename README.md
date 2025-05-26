# Jantar dos Filósofos

Este é um projeto que implementa o clássico problema do Jantar dos Filósofos usando C# e Windows Forms. O projeto simula cinco filósofos (Alan Turing, Ada Lovelace, Filosofo 2, Djikstra e Filosofo 3) que alternam entre os estados de pensando, faminto e comendo.

## 🎯 Funcionalidades

- Interface gráfica com botões representando cada filósofo
- Simulação visual dos estados dos filósofos:
  - Pensando (amarelo)
  - Faminto (vermelho)
  - Comendo (verde)
- Imagens personalizadas para cada filósofo em diferentes estados
- Sistema de threads para simular o comportamento concorrente dos filósofos
- Implementação do algoritmo de prevenção de deadlock

## 🛠️ Tecnologias Utilizadas

- C# (.NET Framework 4.7.2)
- Windows Forms
- Threading
- GDI+ para manipulação de imagens

## 📋 Pré-requisitos

- Windows 10 ou superior
- .NET Framework 4.7.2 ou superior
- Visual Studio 2019 ou superior (para desenvolvimento)

## �� Como Executar

### Comandos Rápidos

Para executar o projeto diretamente, use os seguintes comandos:

```bash
# Clonar o repositório
git clone https://github.com/seu-usuario/Jantar-dos-Filosofos.git

# Entrar na pasta do projeto
cd Jantar-dos-Filosofos

# Compilar o projeto
dotnet build

# Executar o projeto
dotnet run
```

> **Importante**: Certifique-se de ter o .NET Framework 4.7.2 instalado no seu sistema Windows.

### Usando Visual Studio

1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/Jantar-dos-Filosofos.git
```

2. Abra o arquivo `Jantar dos Filosofos.sln` no Visual Studio

3. Compile o projeto (F6 ou Build > Build Solution)

4. Execute o projeto (F5 ou Debug > Start Debugging)

### Usando VSCode

1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/Jantar-dos-Filosofos.git
```

2. Instale as extensões necessárias no VSCode:
   - C# (Microsoft)
   - C# Extensions
   - .NET Core Tools

3. Abra a pasta do projeto no VSCode:
```bash
code Jantar-dos-Filosofos
```

4. Instale o .NET SDK se ainda não tiver:
   - Baixe do site oficial: https://dotnet.microsoft.com/download

5. Restaure as dependências:
```bash
dotnet restore
```

6. Compile o projeto:
```bash
dotnet build
```

7. Execute o projeto:
```bash
dotnet run
```

> **Nota**: Como este é um projeto Windows Forms, você precisará ter o .NET Framework instalado no Windows para executá-lo, mesmo usando o VSCode.

## 🎮 Como Usar

1. Ao iniciar o programa, você verá 5 botões representando os filósofos
2. Clique em cada botão para iniciar a thread do respectivo filósofo
3. Observe as mudanças de estado e cores:
   - Amarelo: Filósofo está pensando
   - Vermelho: Filósofo está faminto
   - Verde: Filósofo está comendo

## 📝 Estrutura do Projeto

- `Form1.cs`: Contém a interface gráfica e a lógica de atualização dos estados
- `Program.cs`: Contém a lógica principal do problema dos filósofos
- `Resources/`: Pasta contendo as imagens dos filósofos em diferentes estados

## 🔒 Algoritmo de Prevenção de Deadlock

O projeto implementa uma solução para o problema do deadlock através da seguinte estratégia:
- O último filósofo pega os garfos em ordem inversa
- Uso de locks para garantir exclusão mútua
- Sistema de prioridade para evitar starvation

## 🤝 Contribuindo

1. Faça um Fork do projeto
2. Crie uma Branch para sua Feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a Branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 👥 Autores

- Seu Nome - Desenvolvimento inicial

## 🙏 Agradecimentos

- Inspirado no clássico problema do Jantar dos Filósofos de Edsger Dijkstra
- Imagens dos filósofos retiradas de fontes públicas 