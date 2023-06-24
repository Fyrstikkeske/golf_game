using Godot;
using System;

public partial class key : Sprite2D
{
	private void _on_area_2d_body_entered(Node2D body)
	{
		var path_to_next_level = GetParent().GetNode<Godot.RichTextLabel>("RichTextLabel").Text;
		
		var next_level = (PackedScene)ResourceLoader.Load(path_to_next_level);
		
		GetTree().ChangeSceneToPacked(next_level);
	}
}


