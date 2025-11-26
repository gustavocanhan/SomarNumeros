# 🧮 Somar Números --- Windows Forms

Um projeto simples em **C# Windows Forms** criado para treinar validação
de entrada, conversão numérica e atualização de componentes gráficos. O
usuário informa dois valores numéricos e o programa exibe o resultado da
soma.

## 🚀 Funcionalidades

-   Entrada de dois números via **TextBox**
-   Validação de:
    -   Campos vazios\
    -   Valores inválidos (não numéricos)
-   Soma dos valores informados
-   Exibição do resultado no **Label**
-   Botão para **limpar** os campos e reiniciar

## 🖥 Estrutura da Interface

O formulário (`Frm_TelaInicial`) contém:

-   Txt_EntradaUm --- Campo para o primeiro número\
-   Txt_EntradaDois --- Campo para o segundo número\
-   Btn_Somar --- Realiza a soma\
-   Btn_Limpar --- Limpa os campos e o resultado\
-   Lbl_Resultado --- Exibe o resultado calculado

Todos os componentes seguem as boas práticas de nomenclatura do Windows
Forms.

## 🎯 Objetivo do Projeto

Esse projeto tem como propósito:

-   Praticar manipulação de componentes no Windows Forms\
-   Aprofundar validação de dados (`TryParse`)\
-   Trabalhar com mensagens de erro amigáveis\
-   Atualizar dinamicamente textos em Labels\
-   Organizar o fluxo do formulário para melhor experiência do usuário

## 📚 Aprendizados

Ao concluir esse projeto, você pratica:

-   Eventos de clique (`Button`)
-   Leitura de valores de `TextBox`
-   Conversão segura para números (`double.TryParse`)
-   Atualização de interface em tempo real\
-   Limpeza e foco automático em componentes

## 🧹 Botão Limpar

O botão **Limpar** redefine:

-   Ambos os campos de entrada\
-   O texto do resultado\
-   O foco retorna para Txt_EntradaUm
