﻿namespace SS14.Client.UserInterface.Controls
{
    [ControlWrap(typeof(Godot.TextureButton))]
    public class TextureButton : BaseButton
    {
        public TextureButton() : base()
        {
        }
        public TextureButton(string name) : base(name)
        {
        }
        public TextureButton(Godot.TextureButton button) : base(button)
        {
        }

        protected override Godot.Control SpawnSceneControl()
        {
            return new Godot.TextureButton();
        }
    }
}
