# Zombie-Toys
A 3D shooter with a psuedo top down view of a boy whose toys come alive at night. The boy must survive the night by shooting an endless horde of enchanted toys.

this repository only contains the scripts for all the actions of the game.

includes enemy movement, attack and health scripts

manager script contains the game flow.

game flow is as follows
  player moves and shoots
  enemy spawns at random location
  enemy numbers increase with increase in score
  score count increases for each enemy killed duration survived
  at a particular threshold value, larger enemies start spawning

player script includes player attack animations, player shooting movement
  player dies when health reaches 0
  when player dies, main menu is loaded

added a pause functionality that freezes the gamme in its current state and loads the pause menu
