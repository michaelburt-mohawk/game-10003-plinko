using Godot;
using System;

public partial class Player : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Freeze = true;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// if the disk is frozen, it's at the top and we can move it around
		if (Freeze)
		{
			// copy the current position into a new position
			Vector2 newPosition = Position;

			// set the X position to be the mouse position
			newPosition.X = GetViewport().GetMousePosition().X;

			// finally, set the position as the new position
			Position = newPosition;

			// drop_disk action is bound to the Left Click
			if (Input.IsActionJustPressed("drop_disk"))
			{
				Freeze = false;
			}
		}
	}
}
