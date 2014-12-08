﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace PuissANT
{
    public class ResourceManager
    {
        public GameTime WorldTime;
        public Dictionary<string, double> Resources;

        private static ResourceManager _instance;
        
        public static ResourceManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ResourceManager();
                return _instance;
            }
        }

        private ResourceManager()
        {
            WorldTime = new GameTime();
            Resources = new Dictionary<string, double>();
        }

        public void LoadContent()
        {
            Resources.Add("dirt", 10);
            Resources.Add("food", 100);
            Resources.Add("ants", 3);
            Resources.Add("birthsPerSec", 0.1);
            Resources.Add("queenHealth", 100);
        }

        public void UnloadContent()
        {

        }

        public void Update(GameTime gameTime)
        {
            
        }
        
    }
}