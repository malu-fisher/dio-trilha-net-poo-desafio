# 📱 Desafio POO com Smartphones

Este repositório contém a implementação do **desafio de programação orientada a objetos (POO)**, parte do curso **End to End Engineering com a DIO e WEX**.

O objetivo do desafio é aplicar os pilares da programação orientada a objetos — **abstração, herança, encapsulamento e polimorfismo** — na modelagem de um sistema simples de smartphones.

---

## 🚀 Tecnologias Utilizadas

- .NET 9 / .NET Core
- C#
- Programação Orientada a Objetos

---

## 📚 Estrutura do Projeto

```text
dio-trilha-net-poo-desafio/
│
├── Models/
│   ├── Smartphone.cs       # Classe abstrata base
│   ├── Nokia.cs            # Implementação específica para Nokia
│   └── Iphone.cs           # Implementação específica para iPhone
│
├── Program.cs              # Classe principal com os testes
└── README.md               # Este arquivo



---

## 📱 Classes Implementadas

### `Smartphone` (Classe Abstrata)

Contém propriedades e comportamentos comuns a todos os smartphones:

- `Numero` (string)
- `Modelo` (string)
- `Marca` (string)
- `IMEI` (string)
- `Memoria` (int, em GB)

#### Métodos:

- `Ligar()`
- `ReceberLigacao()`
- `InstalarAplicativo(string nomeApp)` — abstrato

---

### `Nokia` e `Iphone`

- Herdam da classe `Smartphone`
- Implementam o método `InstalarAplicativo` com comportamentos específicos:
  - Nokia: `"Instalando o aplicativo '{nomeApp}' no Nokia."`
  - iPhone: `"Instalando o aplicativo '{nomeApp}' no iPhone."`

---

## ✅ Funcionalidades Testadas

- Criar instâncias das classes `Nokia` e `Iphone`
- Chamar os métodos:
  - `Ligar()`
  - `ReceberLigacao()`
  - `InstalarAplicativo(string nomeApp)`
- Exibir mensagens no console de forma personalizada

---

## 💡 Exemplo de Uso

Para executar o projeto:

```bash
dotnet run

Saída esperada:

Teste com Nokia:
Ligando...
Recebendo ligação...
Instalando o aplicativo 'Snake' no Nokia.

Teste com iPhone:
Ligando...
Recebendo ligação...
Instalando o aplicativo 'Instagram' no iPhone.

🧠 Sobre o Desafio

Este projeto foi desenvolvido como parte do desafio prático de orientação a objetos,
integrante da trilha End to End Engineering promovida pela
[Digital Innovation One - DIO](https://www.dio.me/sign-up?ref=4Z05DTHSFX)
em parceria com a WEX.



