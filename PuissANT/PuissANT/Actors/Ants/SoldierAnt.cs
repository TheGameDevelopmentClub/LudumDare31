﻿using System.Collections;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using PuissANT.Pheromones;

namespace PuissANT.Actors.Ants
{
    public class SoldierAnt : Ant
    {
        public SoldierAnt()
        {

        }

        public override void Update(GameTime time)
        {
            //Move towards attack pheremone
            IEnumerable<Pheromone> p = PheromoneManger.Instance.GetPheromoneOfType(PheromoneType.Attack);
            throw new System.NotImplementedException();
        }

        public override void Render(GameTime time)
        {
            throw new System.NotImplementedException();
        }
    }
}