using Godot;
using System;

public partial class level_1 : Node2D
{
	AudioStreamPlayer2D background_music;
	GlobalVar globalvar;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		globalvar = (GlobalVar)GetNode("/root/GlobalVar");
		background_music = (AudioStreamPlayer2D)GetNode("/root/BackGroundMusic");
		background_music.Autoplay = true;
		background_music.Playing = true;
	}
}
