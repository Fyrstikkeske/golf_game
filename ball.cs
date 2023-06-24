//ting å lag
//main menu(easyish), mål(mediumIsh)

using Godot;
using System;

public partial class ball : CharacterBody2D
{
	Godot.Sprite2D arrow;
	float direction;
	float hit_Strenght;
	
	GlobalVar globalvar;
	
	void movement_system(InputEvent @event){
		 if (@event.IsActionPressed("MouseClick")){
			direction = this.GetAngleTo(GetGlobalMousePosition());
			hit_Strenght = this.Position.DistanceTo(GetGlobalMousePosition());
			Velocity += new Vector2(Mathf.Cos(direction), Mathf.Sin(direction)) * hit_Strenght;
			globalvar.Points += 1;
		}
	}
	
	void Bounce(KinematicCollision2D collisionInfo, Double delta){
		if (collisionInfo != null){
			Velocity = Velocity.Bounce(collisionInfo.GetNormal());
		}
	}
	
	public override void _Ready(){
		arrow = GetNode<Godot.Sprite2D>("arrow");
		globalvar = (GlobalVar)GetNode("/root/GlobalVar");
	}
	
	public override void _Input(InputEvent @event)
	{
		movement_system(@event);
		
	}
	
	
	public override void _PhysicsProcess(double delta)
	{
		
		arrow.LookAt(GetGlobalMousePosition());
		arrow.Rotation += 3.14f/2;
		
		arrow.Scale = new Vector2(1,arrow.GlobalPosition.DistanceTo(GetGlobalMousePosition())/32);
		
		KinematicCollision2D collisionInfo = MoveAndCollide(Velocity * (float)delta);
		
		Bounce(collisionInfo, delta);
		
		Velocity = new Vector2(Velocity[0]* 0.99f, Velocity[1]* 0.99f);
		
	}
}
