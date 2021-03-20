﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RedTeam
{
    public abstract class SceneComponent
    {
        private Scene _scene;

        public Scene Scene => _scene;
        
        public RedTeamGame Game => _scene.Game;
        
        public void Load(Scene scene)
        {
            _scene = scene ?? throw new ArgumentNullException(nameof(scene));
            OnLoad();
        }

        public void Unload()
        {
            OnUnload();
            _scene = null;
        }

        public void Update(GameTime gameTime)
        {
            OnUpdate(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            OnDraw(gameTime, spriteBatch);
        }
        
        protected virtual void OnLoad() {}
        protected virtual void OnUnload() {}

        protected virtual void OnUpdate(GameTime gameTime) {}
        protected virtual void OnDraw(GameTime gameTime, SpriteBatch batch) {}

    }
}