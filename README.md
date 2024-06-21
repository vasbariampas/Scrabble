# Scrabble
# Overview
This C# console application simulates a simplified version of the game Scrabble. The application deals 7 random letters to two players and then forms every possible 2-letter word for each player, calculating the respective points for each word.

| Tile/Letter | Distribution | Points |
|-------------|--------------|--------|
| A           | 9            | 1      |
| B           | 2            | 3      |
| C           | 2            | 3      |
| D           | 4            | 2      |
| E           | 12           | 1      |
| F           | 2            | 4      |
| G           | 3            | 2      |
| H           | 2            | 4      |
| I           | 9            | 1      |
| J           | 1            | 8      |
| K           | 1            | 5      |
| L           | 4            | 1      |
| M           | 2            | 3      |
| N           | 6            | 1      |
| O           | 8            | 1      |
| P           | 2            | 3      |
| Q           | 1            | 10     |
| R           | 6            | 1      |
| S           | 4            | 1      |
| T           | 6            | 1      |
| U           | 4            | 1      |
| V           | 2            | 4      |
| W           | 2            | 4      |
| X           | 1            | 8      |
| Y           | 2            | 4      |
| Z           | 1            | 10     |
| Blank       | 2            | 0      |


# How It Works
1. The application initializes a list of Scrabble letters with their respective frequencies.
2. It randomly deals 7 letters to each player.
3. It generates all possible 2-letter combinations from the dealt letters for each player.
4. It calculates the points for each 2-letter word based on Scrabble letter values.
5. It displays the letters, 2-letter words, and points for each player.
