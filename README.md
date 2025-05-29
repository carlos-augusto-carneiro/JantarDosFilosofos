# Jantar dos Filósofos

Este é um projeto que implementa o clássico problema do Jantar dos Filósofos usando C# e Windows Forms. O projeto simula cinco filósofos (Alan Turing, Ada Lovelace, Bertrand Russell, Edsger Dijkstra e Simone de Beauvoir) que alternam entre os estados de pensando, faminto e comendo.

> **Importante**: Certifique-se de ter o .NET Framework 4.7.2 instalado no seu sistema Windows.


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
- VsCode ou Visual Studio (para desenvolvimento)

## �� Como Executar

### Comandos Rápidos

Para executar o projeto diretamente, use os seguintes comandos:

> **Atenção:** Projetos Windows Forms com .NET Framework são recomendados para uso no Visual Studio. O suporte no VSCode é limitado e pode não permitir a execução direta da interface gráfica.


```bash
# Clonar o repositório
git clone https://github.com/carlos-augusto-carneiro/JantarDosFilosofos.git

# Entrar na pasta do projeto
cd JantarDosFilosofos

# Compilar o projeto
dotnet build

# Executar o projeto
dotnet run
```

## 🎮 Como Usar

1. Ao iniciar o programa, você verá 5 botões representando os filósofos
2. Observe as mudanças de estado e cores:
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

## 🙏 Agradecimentos

- Inspirado no clássico problema do Jantar dos Filósofos de Edsger Dijkstra
- Imagens dos filósofos foram geradas por uma IA Generativa