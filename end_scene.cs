using Godot;
using System;

public partial class end_scene : Node2D
{
	RichTextLabel FinalPointsText;
	GlobalVar globalvar;
	Int32 perfectscore;
	AudioStreamPlayer2D background_music;
	
	private void _on_back_to_main_meny_button_down()
	{
		globalvar.Points = 0;
		var PathToMainMenu = (PackedScene)ResourceLoader.Load("res://main_menu.tscn");
		GetTree().ChangeSceneToPacked(PathToMainMenu);
	}
	private void _on_back_to_level_1_button_down()
	{
		globalvar.Points = 0;
		var PathToLevelOne = (PackedScene)ResourceLoader.Load("res://level_1.tscn");
		GetTree().ChangeSceneToPacked(PathToLevelOne);
	}
	
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		perfectscore = 11;
		background_music = (AudioStreamPlayer2D)GetNode("/root/BackGroundMusic");
		background_music.Playing = false;
		
		globalvar = (GlobalVar)GetNode("/root/GlobalVar");
		FinalPointsText = GetNode<RichTextLabel>("FinalPointsText");
		
		FinalPointsText.Text = "[center] your score is "+ globalvar.Points.ToString();
		
		if (globalvar.Points <= perfectscore){
			GetNode<VideoStreamPlayer>("VideoStreamPlayer").Visible = true;
			globalvar.SecretUnlocked = true;
			}
		
	}
}






