using Godot;
using System;

public partial class GameOver : Control
{

	public override void _Ready()
	{
		Hide();
	}

	
	


	public void OnRestartButtonPressed()
	{
		GetTree().ReloadCurrentScene();
	}
}
