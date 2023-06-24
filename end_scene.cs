using Godot;
using System;

public partial class end_scene : Node2D
{
	RichTextLabel FinalPointsText;
	GlobalVar globalvar;
	Int32 perfectscore;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		perfectscore = 4;
		
		globalvar = (GlobalVar)GetNode("/root/GlobalVar");
		FinalPointsText = GetNode<RichTextLabel>("FinalPointsText");
		
		FinalPointsText.Text = "[center] your score is "+ globalvar.Points.ToString();
		
		if (globalvar.Points == perfectscore)
			GetNode<VideoStreamPlayer>("VideoStreamPlayer").Visible = true;
	}
}
