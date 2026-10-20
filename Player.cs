using Godot;
using System;
 
public partial class Player : CharacterBody2D
{
    [Signal]
    public delegate void DeathEventHandler();

    float gravity = 900f;
    float jetpack = 1800f;
    float maxFallSpeed = 600f;

 	public override void _PhysicsProcess(double delta)
    {
        float dt = (float)delta;
 
        // Gravity
        Velocity = new Vector2(
            Velocity.X,
            Velocity.Y + gravity * dt
        );
 
        // Hold Space = Jetpack
        if (Input.IsKeyPressed(Key.Space))
        {
            Velocity = new Vector2(
                Velocity.X,
                Velocity.Y - jetpack * dt
            );
        }
 
        // Max falling speed
        Velocity = new Vector2(
            Velocity.X,
            Mathf.Min(Velocity.Y, maxFallSpeed)
        );
 
        MoveAndSlide();
    }
}