using Godot;
using System;

public partial class ball : CharacterBody2D
{
	Godot.Sprite2D arrow;
	float direction;
	float hit_Strenght;
	
	
	public override void _Ready(){
		arrow = GetNode<Godot.Sprite2D>("arrow");
	}
	
	public override void _Input(InputEvent @event)
	{
		 if (@event.IsActionPressed("MouseClick")){
				
				direction = this.GetAngleTo(GetGlobalMousePosition());
				
				hit_Strenght = this.Position.DistanceTo(GetGlobalMousePosition());
				
				
				Velocity += new Vector2(Mathf.Cos(direction), Mathf.Sin(direction)) * hit_Strenght;
		}
	}
	
	
	public override void _PhysicsProcess(double delta)
	{
		
		arrow.LookAt(GetGlobalMousePosition());
		arrow.Rotation += 3.14f/2;
		
		arrow.Scale = new Vector2(1,arrow.GlobalPosition.DistanceTo(GetGlobalMousePosition())/32);
		
		
		
		
		var collisionInfo = MoveAndCollide(Velocity * (float)delta);
	}
}
