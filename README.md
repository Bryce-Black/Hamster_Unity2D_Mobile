# Hamster_Unity2D_Mobile
Hi!
This is the very first game I ever made in Unity

The main goal of the game is to keep the character from hitting the bottom portion of the screen and to attain the highest score possible.

In this project, I hit two major roadblocks, the first of which was making an anti-cheat system, in early versions of the game, you could essentially trap the character in the corner to rack up an insane score. The second roadblock that plagued me, is that when Unity is detecting a tap-and-hold input, it's read by the computer as hundreds of taps per second, giving the player loads of points in the process.

I wanted a simple solution that solved both problems. It ended up being a time limit that resets itself once a hit is undetected. 

The time limit was working great; however, you could still find a sweet spot on the upper-part of the screen and increase your points per second. To fix this, I created a function that detects a north wall collision, and when that happens to add a random force in either the left or right direction. It adds MUCH more force when a tap is detected above a certain y-coordinate. This ended up adding a high-risk high-reward feature that makes the game even more fun!
