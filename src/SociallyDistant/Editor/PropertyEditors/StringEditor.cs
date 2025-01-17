﻿using System;
using SociallyDistant.Editor.Attributes;
using Thundershock.Gui.Elements;

namespace SociallyDistant.Editor.PropertyEditors
{
    [PropertyEditor(typeof(string))]
    public sealed class StringEditor : AssetPropertyEditor<string>
    {
        private TextEntry _text = new();

        protected override void Build()
        {
            RootElement = _text;
            
            _text.TextChanged += TextOnTextChanged;
        }

        private void TextOnTextChanged(object? sender, EventArgs e)
        {
            this.NotifyValueChanged(_text.Text);
        }

        protected override void OnValueChanged()
        {
            _text.Text = Value;
        }
    }
}