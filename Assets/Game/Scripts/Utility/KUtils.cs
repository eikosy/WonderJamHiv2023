﻿using UnityEngine;
using Random = System.Random;

namespace Game.Scripts.Utility
{
    public static class KUtils
    {
        public static Random Rnd = new Random();
        public static Vector2 xz(this Vector3 v) => v.x * Vector2.right + v.z * Vector2.up;
    }
    
    
}