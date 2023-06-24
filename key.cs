using Godot;
using System;

public partial class key : Sprite2D
{
	GlobalVar globalvar;
	Int32 oldpoints;
	Int32 points_on_this_level;
	
	public override void _Ready()
	{
		globalvar = (GlobalVar)GetNode("/root/GlobalVar");
		oldpoints = globalvar.Points;
	}
	
	
	private void _on_area_2d_body_entered(Node2D body)
	{
		var path_to_next_level = GetParent().GetNode<Godot.RichTextLabel>("NextLevel").Text;
		
		var next_level = (PackedScene)ResourceLoader.Load(path_to_next_level);
		
		GetTree().ChangeSceneToPacked(next_level);
		
		points_on_this_level = (globalvar.Points - oldpoints);
		if (points_on_this_level == 1){
			globalvar.LoadNotGonnaSugarCoatIt = true;
		}
	}
}


