﻿using UnityEngine;

namespace Script.Player
{
    public class PlayerScript : PlayerBase
    {
          
         public override void Start()
        {
            base.Start();
        }

        private void Update()
        {
            Move();
        }


    }
}