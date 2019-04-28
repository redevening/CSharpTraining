# 01 -  BlackJack

BlackJack is a game often played in casinos.

A set of cards [French Deck](https://en.wikipedia.org/wiki/French_playing_cards) is used to play the game.

A player plays against the dealer. The goal of the game is to get ones card value as close to 21 as possible but not going over.

## How the game is played

1. At the beginning the dealer deals the player two cards face up and himself also two cards, one card face up and the other one face down.
2. Its the players turn now: The player can decide whether he wants to get another card. If the player takes another card he has three cards now. If the value of his cards is over 21 the game is over and the player has lost the game.
3. Now its the dealers turn and the dealer reveals his hidden card. If the card values of the dealer is smaller  than 17 the dealer has to take another card. If his card value is now over 21 he has lost the game and the game is over.
4. Now player and dealer take turn taking cards. The player does not need to take a card if i doesn't want to as he fears going above 21. The rules for the dealer are more strict. The dealer has to take a card if his card values are smaller than 17 and is not allowed to take a card otherwise. If the player or the dealer have a card value above 21 they have lost and the game is over.
5. When the player/dealer do not want more cards anymore the game is over and the points are counted.
6. The player with the most points has won

### Card Points
Color is irrelevant for card points. Only card values are relevant for blackjack points.

|  Card Value |  BlackJack Points |
|-------------|-------------------|
| TWO         | 2                 |
| THREE       | 3                 |
| FOUR        | 4                 |
| FIVE        | 5                 |
| SIX         | 6                 |
| SEVEN       | 7                 |
| EIGHT       | 8                 |
| NINE        | 9                 |
| TEN         | 10                |
| JACK        | 10                |
| QUEEN       | 10                |
| KING        | 10                |
| ACE         | 10 (in the real game this could also be 1 depending what would be better for the player) |

## How to implement the exercise
In this project you will find a partially implemented solution which you can use. There are also some TODOS that may help you implement the solution.

You don't have to use this suggestions but they may help you.


## Options:
- Blackjack can be played with multiple people. We may implement a multi user blackjack in a later exercise.
- Also for us an Ace always has 10 points. In the real game an ace has 1 or 10 points depending on what would be better for the player.

## Questions to answer

1. How should a card be represented?
    - How to represent Card Color information?
    - How to represent Card Value information?
    - How to represent BlackJack Points of a Card?

2. How should the deck of cards be represented?
    - How are the cards in the deck represented?
    - How to make sure the deck is shuffled?
    - How to make sure that when a card is drawn it is removed from the deck?
    - What happens if the deck is empty? Is it ok if the program crashes when trying to draw from an empty deck? Can this happen in a game? How could we handle such case?

3. How should a player/dealer be represented?
    - What information do we need to store for them?
    - Should they be represented in their own data structure?
    - Can this be the same for dealer/player?

### Further questions to think about
1. What are the problems, when the blackjack points of a card are directly stored in an enum? Specially: Is there a problem when multiple enum entries have the same entry? Think about how an enum is actually implemented.
2. What would need to change to be able to count the Ace not always as 10 points but rather as 10 points or 1 point depending what would be better for the player?
3. What would need to change to be able to play the game with multiple players?
