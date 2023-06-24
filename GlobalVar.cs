using Godot;
using System;

public partial class GlobalVar : Node
{
	
	public Int32 Points;
	public bool LoadNotGonnaSugarCoatIt;
	public bool SecretUnlocked;
	public override void _Ready(){
		SecretUnlocked = false;
	}
} 
