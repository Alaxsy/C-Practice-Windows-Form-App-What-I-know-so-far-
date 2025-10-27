This is a program for a button game idea I had.

The game objective is you have to click all the buttons within the clicks allowed.

Clicks <= Clicks allowed == you win
Clicks > Clicks allowed == you lose & restart.


At any point the player can reset the stage by clicking "Reset stage" button.
Clicking the start button makes everything visible. Group box, Buttons within group box, Score box + label, stage reset. etc.
starting with stage 1.


Stage 1 has 10 buttons.
In group box 1 there are 10 buttons. Each button can be clicked once by the Player.
Once the button is click it turns invisible. "Player can no longer click that button".
Adds +1 to score box.
stores that the button has been clicked to true.

If all 10 buttons visible = false and the score box reads <= 10. player wins stage one.
Makes group box 1 disappear and makes group box 2 visible.
Player moves to stage 2.

If any 10 buttons visible = true and the score box reads > 10. player lose stage one.
stage one gets reset and Player replays stage one.


Stage 2 has 10 buttons.
In group box 2 there are 10 buttons. Each button can be clicked once by the Player.
Once the button is click it turns invisible. "Player can no longer click that button".
Adds +1 to score box.
stores that the button has been clicked to true.

However. I would like to add the idea of when a button is clicked by the player, Another button that was previously invisible becomes visible thus adding difficulty.

example.
when you click a button it turns invisible so

When button 1 visible = false and button 7 visible = true. make button 9 visible = true. Even if button 9 was previously visible = false.
when button 8 visible = false and button 7, button 6, button 3 visible = false. make buttons 6, 7 and 5 visible = true. Even if button 6, 7 and 5 were previously visible = false.

The idea is the make some sort of pattern to click numbers in a specific order to make buttons appear and disappear until you click all the button with 0 button available to be clicked.

so for stage 2:
If all 10 buttons are visible = false and the score box reads <= 20. player wins stage one.
Player moves to stage 2.

If any 10 buttons are visible = true and the score box reads > 20. player lose stage two.
Player replays stage two.


Stage 3 is basically the same thing but you get 30 clicks to remove all the boxes.
same button concept as stage 2 but one button click could make all the buttons reappear if certain conditions are met.

Example.
When button 20 visible = false and button 23,24,26, 29,30 visible = true. make button 20-29 visible = true. Even if button 20-29 was previously visible = false.
