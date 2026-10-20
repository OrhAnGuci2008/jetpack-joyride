using Godot;
using System;
 
public partial class Laser : Area2D
{
	float speed = 300f;
	

	public override void _Process(double delta)
	{
		Position +=  Vector2.Left * speed * (float)delta;


		if (Position.X < -200)
		{
			QueueFree();
		}
	}

	public void OnBodyEntered(Node2D body)
	{
		if (body is Player player)
		{
		
			GD.Print("Player hit by Laser!");
			player.EmitSignal(Player.SignalName.Death);
		}
	}
}
