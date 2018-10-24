# SuperAwesomePlayerController
A really snappy Unity player controller.

# How to use?
To use this player controller for your own game you have to follow these steps.
## Add components to player
Let's first add all the necessary components to the player object
1. First you have to add the `"PlayerController.cs"` script to your player game object.
2. Next you have to add a `"Rigidbody"` component to your player.
3. Now you have to add a collider to your player.
4. Now drag the `"Rigidbody"` component to the `"Rigid Body"` field on the `"PlayerController"` component.
## Add inputs
Now lets add the input methods <br/>
You need to add inputs called Horizontal, Jump and Fall.

|Input Name|Positive Button|Negative Button|
|---|---|---|
|Horizontal|The right button|The left button|
|Jump|Jump Button|
|Fall||Fast-Fall Button|

## Ground
Add the tag `"Ground"` to your ground object

## Recreating example
These are the last steps to do if you want to recreate the example.<br/>
### The player
The player object has to be a `3x3x1` sphere with a y position of `-8.45`<br/>
Change the mass under the `"Rigidbody"` component to 1.5 and freeze the Z rotation
### Gravity
Click on `Edit > Project Settings > Physics` in the menu bar <br/>
Change the `"Gravity"` to
|X|Y|Z
|:---:|:---:|:---:
|0|-58.86|0
### Ground
Make a cube with the following `"Transform"`
| |Position|Rotation|Scale
|:---:|:---:|:---:|:---:
|X|0|0|50
|Y|-20|0|20
|Z|0|0|10
### Camera
Change the background color to `HEX` `428BFF` <br/>
Change the `"Transform"`
| |Position|Rotation|Scale
|:---:|:---:|:---:|:---:
|X|0|0|1
|Y|0|0|1
|Z|-45.23|0|1