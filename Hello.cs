using Godot;

// IMPORTANT: the name of the class MUST match the filename exactly.
// this is case sensitive!
public class Hello : Panel
{
    public override void _Ready()
    {
        GetNode("Button").Connect("pressed", this, nameof(_OnButtonPressed));
    }

    public void _OnButtonPressed()
    {
        GetNode<Label>("Label").Text = "HELLO!";
    }
}