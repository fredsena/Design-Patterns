﻿using DesignPatterns.Core.Strategy.DuckStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Strategy.DuckStrategy.Algorithm
{
    public class FlyWithWings : IFlyBehavior
    {
        public string Fly()
        {
            return "I can Fly!!!!";
        }
    }
}
