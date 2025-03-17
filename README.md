# Controle de Pátio Portuário

### Desenvolvido em C# - Visual Studio

Projeto desenvolvido para mapear a distribuição de veículos no pátio de embarque,
controlar o aceite do veículo no pátio (_com base em lista do fornecedor_),
validação do veículo para embarque no navio.  
Projeto previa integração com sistema Web, e utilização de redes Wifi. Como a
estrutura seria onerosa, na época, se decidiu por uma solução **"offline"**  
Portanto foi desenvolvido um sistema desktop para preparação de estrutura (_XML_)
a ser transmitida aos PDAs (Smartphones não eram uma opção na época), os dados
recebidos das operadoras, vinham num formato _CSV_.  
Com o objetivo de atender demanda de cliente específico.  
Projeto cancelado por mudanças nas políticas de embarque de veículos
(alteração de porto).

Banco de Dados utilizado: _Access_ (Determinado pelo provedor Web)
Estrutura de Dados: _XML_, _CSV_  
Componentes básicos, RX, LMD, Jedi, de terceiros e próprios do Delphi _versões 5 e 6_

Autores: **Marilene Esquiavoni** & **Denny Paulista Azevedo Filho**

### Tela Sistema Desktop

![Sistema Desktop](https://mdcursos.dev.br/img/sisdesk/SisDeskContolPatio.png)

### Tela do Controle de Patio

![Tela da Comanda](https://mdcursos.dev.br/img/sisdesk/ControlePatio.png)

### Tela do Controle de Embarque

![Tela da Comanda](https://mdcursos.dev.br/img/sisdesk/ControleEmbarque.png)

### Principais funcionalidades do sistema

- Registro e controle do embarque de veículos
- Distribuição no patio _em implantação_
- Geração de estruturas de dados para PDAs
- Importação de dados dos PDAs
