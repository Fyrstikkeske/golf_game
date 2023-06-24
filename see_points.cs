using Godot;
using System;

public partial class see_points : RichTextLabel
{
	GlobalVar globalvar;
	Int32 oldpoints;
	Int32 points_on_this_level;
	
	public override void _Ready()
	{
		globalvar = (GlobalVar)GetNode("/root/GlobalVar");
		oldpoints = globalvar.Points;
	}
	
	
	public override void _Process(double delta)
	{
		points_on_this_level = (globalvar.Points - oldpoints);
		this.Text = points_on_this_level.ToString();
	}
}
