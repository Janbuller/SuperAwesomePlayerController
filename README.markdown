# SuperAwesomePlayerController
A really snappy Unity player controller.

# How to use?
To use this player controller for your own game you have to follow these steps.
## Add components to player
Let's first add all the necessary components to the player object.
1. First you have to add the `"PlayerController.cs"` script to your player game object.
2. Next you have to add a `"Rigidbody"` component to your player.
3. Now you have to add a collider to your player.
4. Now drag the `"Rigidbody"` component to the `"Rigid Body"` field on the `"PlayerController"` component.
## Add inputs
Now lets add the input methods. <br/>
You need to add inputs called Horizontal, Jump and Fall. <br/>
To get to the inputs menu, you have to go to `Edit > Project Settings > Input` in the menu bar.

<table >
		<tr>
			<th>Input Name</th>
			<th>Positive Button</th>
			<th>Negative Button</th>
		</tr>
		<tr>
			<td>Horizontal</td>
			<td>The right button</td>
			<td>The left button</td>
		</tr>
		<tr>
			<td>Jump</td>
			<td>Jump Button</td>
			<td> </td>
		</tr>
		<tr>
			<td>Fall</td>
			<td> </td>
			<td>Fast-Fall Button</td>
		</tr>
</table>

## Ground
Add the tag `"Ground"` to your ground object.

## Recreating example
These are the last steps to do if you want to recreate the example.<br/>
### The player
The player object has to be a `3x3x1` sphere with a y position of `-8.45`.<br/>
Change the mass under the `"Rigidbody"` component to 1.5 and freeze the Z rotation.
### Gravity
Click on `Edit > Project Settings > Physics` in the menu bar. <br/>
Change the `"Gravity"` to

<table >
		<tr>
			<th>X</th>
			<th>Y</th>
			<th>Z</th>
		</tr>
		<tr>
			<td>0</td>
			<td>-58.86</td>
			<td>0</td>
		</tr>
</table>

### Ground
Make a cube with the following `"Transform"`

<table >
		<tr>
        	<td></td>
            <th>X</th>
			<th>Y</th>
			<th>Z</th>
		</tr>
		<tr>
			<th>Position</th>
            <td>0</td>
			<td>-20</td>
			<td>0</td>
		</tr>
		<tr>
			<th>Rotation</th>
            <td>0</td>
			<td>0</td>
			<td>0</td>
		</tr>
		<tr>
			<th>Scale</th>
            <td>50</td>
			<td>20</td>
			<td>10</td>
		</tr>
</table>

### Camera
Change the background color to `HEX` `428BFF`. <br/>
Change the `"Transform"`

<table >
		<tr>
        	<td></td>
            <th>X</th>
			<th>Y</th>
			<th>Z</th>
		</tr>
		<tr>
			<th>Position</th>
            <td>0</td>
			<td>-0</td>
			<td>-45.23</td>
		</tr>
		<tr>
			<th>Rotation</th>
            <td>0</td>
			<td>0</td>
			<td>0</td>
		</tr>
		<tr>
			<th>Scale</th>
            <td>1</td>
			<td>1</td>
			<td>1</td>
		</tr>
</table>
