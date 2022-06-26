# TheBraveHunter

![The Brave Hunter](https://raw.githubusercontent.com/Thawab-alkhiami/TheBraveHunter/main/Assets/Images/Screenshot%202022-06-26%20at%2019.58.58.png)

## Game Story
A brave hunter wanders in the forests, and many dangerous eagles await him!
The hunter adventure takes place day and night in a large forest. There is a target that the hunter should achieve to win.
During the day, the hunter should search for red Mushrooms. At the night, the hunter should search for brown Mushrooms.
While achieving the target, the hunter should protect himself from the eagles and shoot them. If the hunter collides with the eagle he will lose his life.
If the hunter achieves the target he will win.

## Game's main objects
### The hunter
The hunter holds a Gun and discovers the forest. He moves using the arrows: 
`UP` moves forward, `DOWN` moves backward, `RIGHT` moves right, and `LEFT` moves left.
The hunter shotes using `SPACE` key button.
If the hunter collides with the eagle, his lives amount will be reduced 1.
![](https://raw.githubusercontent.com/Thawab-alkhiami/TheBraveHunter/main/Assets/Images/Screenshot%202022-06-26%20at%2022.57.53.png)

### The eagles
The eagles are instantiated randomly in the forest then move toward the hunter's position.
The eagle has two states of annimation:
1. Fly and flutter with wings:
![Eagle flying animation](https://raw.githubusercontent.com/Thawab-alkhiami/TheBraveHunter/main/Assets/Images/Eagle.png)
2. Fall down and die:
![Eagle falling-down animation](https://raw.githubusercontent.com/Thawab-alkhiami/TheBraveHunter/main/Assets/Images/Screenshot%202022-06-26%20at%2020.00.08.png)

### The bullet
If the bullet collides the eagle, the eagle will die.

### The Mushroom
In the first scene, the hunter should collide with the **red** Mushroom to move to the second scene.
![](https://raw.githubusercontent.com/Thawab-alkhiami/TheBraveHunter/main/Assets/Images/Screenshot%202022-06-26%20at%2020.10.10.png)
In the second scene, the hunter should collide with the **brown** Mushroom to move to win.
![](https://github.com/Thawab-alkhiami/TheBraveHunter/blob/main/Assets/Images/brown%20mushroom.png)


### Forest's objects
1. diffeerent types of trees
2. diffeerent types of flowers
3. diffeerent types of plants
4. diffeerent types of rocks
5. wood

When the hunter collides with the forest's objects it bonuces back and cannot cross them.

## Spawn Management (Prefabs Management)
### Eagles Instantiating
Eagles are instantiated by the spawn manager in different positions in the forest.
Instantiating stops when:
1. Hunter's death.
2. Win case.
3. Lose case.

### Eagles Destruction
Eagles are destroyed when colliding with bullets.

### Bullet Instantiating
Bullets  are instantiated by the gun.

### Bullet Destruction
Bullets are destroyed when colliding with the ground, forest objects, and eagles.

## UI
There are two texts, the first one is for **Lives**
The second is for **The target**
![](https://github.com/Thawab-alkhiami/TheBraveHunter/blob/main/Assets/Images/texts.png)

The lives text is updated when the hunter's lives changed.
The target text is updated when changing the scene.

### Win Text
Both texts changed to Congrats when the player wins.
![](https://github.com/Thawab-alkhiami/TheBraveHunter/blob/main/Assets/Images/win.png)

### Game Over Text
Both texts changed to Game Over when the player lose.
![](https://github.com/Thawab-alkhiami/TheBraveHunter/blob/main/Assets/Images/game%20over.png)

## Environment and Borders
When the hunter collides with the quads it bounces back and cannot cross the borders.

### Day Quads
![](https://github.com/Thawab-alkhiami/TheBraveHunter/blob/main/Assets/Images/day%20quad.png)

### Night Quads
![](https://github.com/Thawab-alkhiami/TheBraveHunter/blob/main/Assets/Images/night%20quad.png)

## Scenes Management
The game contains 2 scenes. each scene has its special nature objects, light, music, and target.
To move to the first scene, the hunter should collide with the **red** Mushroom.

## Asset Store
We used free assets for the hunter's gun, eagle, and forest objects

## Back Ground Music
Each scene has different background music.

## Camera
The camera follows the hunter and rotate with him.

## Directional light
The light inttnsity changes when the scene changes day/night.

## Demo video
https://drive.google.com/file/d/1c9-YuCbMtfN5GsMEBCuDewkx9AjADvXP/view?usp=sharing



