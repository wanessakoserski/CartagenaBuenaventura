# :joystick: **CartagenaBuenaventura** :joystick:
Projeto integrador com fins educacionais: Sistema Autônomo, criar uma automatização que consiga jogar de maneira estratégica o jogo Cartagena. 
O nome do grupo se chama Buenaventura, nome de uma cidade na Colômbia dentro da temática do jogo.

## 	:game_die: Cartagena 
Cartagena é um jogo de tabuleiro, onde o objetivo é levar todos os seus piratas da prisão até o barco (são 6 piratas).

### Regras 
- cada jogador começa com 6 cartas;
- em uma partida cada jogador terá seu turno para jogar os piratas, cada turno o jogador terá três ações;
- ações possíveis: mover um peão para frente, mover um peão para trás e pular a vez;
- mover para a frente: custa uma carta, e o peão irá se mover para próxima casa vazia com o mesmo símbolo que a carta. Se não tiver nenhuma casa de mesmo símbolo vazia, o peão chega no barco;
- mover para trás: sem custo, porém o pirata movido só pode se mover para uma casa que já tenha um ou dois piratas. O jogador ganha um número de cartas igual a quantidade de piratas que estava na casa;
- pular a vez: você não executa nenhuma ação dentro das suas 3 ações possíveis em seu turno, pode pular quantas vezes quiser e sem nenhum custo.

Para mais informações sobre o jogo [clique aqui](https://tablegames.com.br/wp-content/uploads/2017/10/cartagena_manual_table_games.pdf). 

## :construction: Dados do jogo - Server 
A trilha que é disposta no tabuleiro, as cartas dos jogadores e histórico das jogados, todos esses dados do jogo, são guardados em um servidor. 
Em ``Classes > Services > Game.cs`` é possível encontrar métodos onde tratamos os retornos desse servidor.

:warning: ATENÇÃO: O servidor depois da data 12/06/2023 não estará funcionando, pois o trabalho já foi entregue, isso irá comprometer qualquer teste do programa.

## :robot: Automação 
Nosso Robot ``Classes > Automation > Robot.cs`` é responsável por sempre verificar se é sua vez de jogar, chama alguma estratégia disponível em ``Classes > Automation > Strategies``. Porém, nota-se que é necessário para qualquer estratégia que seja diposta a escolha herda ``Classes > Automation > Strategy.cs`` e implemente os métodos base de umae estratégia, dessa forma ela poderá ser utilizada pelo Robot.

O Robot é chamado e utilizado no ``Forms > Board.cs`` onde está ocorrendo a partida dentro da nossa proposta de centralização de visualização do jogo.
