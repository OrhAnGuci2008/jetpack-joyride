using Godot;
using System;

public partial class Game : Node2D
{
	// Called when the node enters the scene tree for the first time.
	Control gameOverScreen;
	public override void _Ready()
	{
		gameOverScreen = GetNode<Control>("GameOver");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnPlayerDeath()
	{
		GD.Print("Player has died!");
		gameOverScreen.Show();
	}


}
