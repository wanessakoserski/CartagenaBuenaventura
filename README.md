# :joystick: **CartagenaBuenaventura** :joystick:
Projeto integrador com fins educacionais: Sistema Autônomo, criar uma automatização que consiga jogar de maneira estratégica o jogo Cartagena. 
O nome do grupo se chama Buenaventura, nome de uma cidade na Colômbia dentro da temática .

## 	:game_die: Cartagena :game_die:
Cartagena é um jogo de tabuleiro, onde o objetivo é levar todos os seus piratas da prisão até o barco (são 6 piratas).
### Regras 
- mover para frente é necessário baixar um carta com o mesmo símbolo que você quer mandar o peão
- quando mover o peão para frente, ele vai para a primeira casa vazia como símbolo correspondente
- mover para trás o peão vai para a primeira casa com dois peões ou um peão, você vai ganhar a quantidade correpondente ao número de peões

## :construction: Dados do jogo - Server :construction:
O tabuleiro, as cartas e histórico ao longo do jogo, todos esse dados do jogo, são guardados em um servidor. 
Em ``Classes > Services > Game.cs`` está nossa classe onde tratamos os retornos desse servidor.

:warning: ATENÇÃO: O servidor depois da data 12/06/2023 não estará funcionando, pois o trabalho já foi entregue

## :robot: Automação :robot:
Nosso Robot ``Classes > Automation > Robot.cs`` é responsável por sempre verificar se é sua vez de jogar, chama alguma estratégia disponível em ``Classes > Automation > Strategies``. É necessário que a estratégia escolhida herda ``Classes > Automation > Strategy.cs``.
O Robot é chamado no ``Forms > Board.cs`` onde está ocorrendo a partida dentro da nossa proposta de centralização e visualização do jogo.
