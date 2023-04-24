# dancing-rabbit
במשחק יש ארנב שרוקד למוזיקה על מסלול, כאשר כל כמה שניות יש קיר שמתקרב אליו. בקיר יש חור שהוא הדמות של הארנב בפוזיציה מסויימת. כאשר הקיר מתקרב - על השחקן לבחור מתוך 3 אפשרויות את הפוזיציה הנכונה אותה הוא צריך לעשות כדי לעבור דרך הקיר. ינתן זמן מוקצב לבחירת הפוזיציה וככל שהמשחק יתקדם הזמן הזה יקטן והקיר יגיע מהר יותר לכיוון השחקן, מה שישאיר לשחקן מעט זמן לחשוב ויצטרך תגובת זמן מהירה. 
המשחק הוא משחק מחשב.

[קישור לדף הרכיבים](https://github.com/Game-Developmento/dancing-rabbit/blob/main/formal-elements.md)

Welcome to our game! Although it is not exactly like the original game idea, we have created something similar.
[Click here to play the game!](https://itch.io/)

## Game Description
You are the player standing on a platform and moving towards the walls. Each wall has a hole that you must go through to keep going. If you touch the wall, you lose. The goal is to get to the other side without touching any walls. In the original game, the player needs to be in a special pose to get through the wall. So the idea of our game is similar to that.

## How to Play
Use the right and left arrow keys to move the player and try to fit into the holes in the wall.

## Scripts

### InputMover
Controls the player's movement.
### ForceAdder
Adds force to the player to move forward.
### FollowPlayer
Makes the camera follow the player.
###  ResetOnCollision
Resets the game when the player loses by hitting the wall.
