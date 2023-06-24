using Godot;
using System;

public partial class main_menu : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
	
	private void _on_button_button_down()
	{
		var next_level = (PackedScene)ResourceLoader.Load("res://level_1.tscn");
		
		GetTree().ChangeSceneToPacked(next_level);
	}
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}



