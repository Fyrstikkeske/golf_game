using Godot;
using System;

public partial class not_gonna_sugar_coat_it : Sprite2D
{
	GlobalVar globalvar;
	Godot.AnimationPlayer notgonnasugarcoatitanimationplayer;
	
	
	public override void _Ready()
	{
		notgonnasugarcoatitanimationplayer = GetNode<Godot.AnimationPlayer>("NotGonnaSugarCoatItAnimationPlayer");
		
		globalvar = (GlobalVar)GetNode("/root/GlobalVar");
		if (globalvar.LoadNotGonnaSugarCoatIt == true){
			this.Visible = true;
			notgonnasugarcoatitanimationplayer.Play("NotGonnaSugarCoatItAnimation");
			globalvar.LoadNotGonnaSugarCoatIt = false;
		}
	}
}
