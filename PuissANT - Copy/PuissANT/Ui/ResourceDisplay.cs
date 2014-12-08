﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PuissANT.Ui
{
    public class ResourceDisplay
    {
        public Image Icon;
        public Image Bar;
        public Vector2 Position, BarOffset, IconOffset, FontOffset;
        public string Name;
        public double Value;

        private string _iconPath, _barPath;

        public ResourceDisplay(string name)
        {
            Icon = new Image();
            Bar = new Image();
            Position = Vector2.Zero;
            BarOffset = Vector2.Zero;
            IconOffset = FontOffset = Vector2.Zero;
            Name = name;
            _iconPath = Icon.Path = "ui\\" + name + "Icon";
            _barPath = "ui\\resourceBackground";
        }

        public void LoadContent(Vector2 position)
        {
            BarOffset = new Vector2(0, 0);
            IconOffset = new Vector2(0, 0);
            FontOffset = new Vector2(50, 6);
            
            Icon.LoadContent(Icon.Path, String.Empty);
            Icon.Position = new Vector2(position.X + IconOffset.X, position.Y + IconOffset.Y);
            Bar.LoadContent(_barPath, String.Empty);
            Bar.Position = new Vector2(position.X + BarOffset.X, position.Y + BarOffset.Y);
            Bar.FontPosition = new Vector2(FontOffset.X, FontOffset.Y);
        }

        public void UnloadContent()
        {
            Icon.UnloadContent();
            Bar.UnloadContent();
        }

        public void Update(GameTime gameTime)
        {
            if (Value != ResourceManager.Instance.Resources[Name])
            {
                Value = ResourceManager.Instance.Resources[Name];
                Bar.LoadContent(_barPath, Value.ToString());
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Bar.Draw(spriteBatch);
            Icon.Draw(spriteBatch);
        }
    }
}