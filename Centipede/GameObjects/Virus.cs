﻿#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Pacman.GameStates;
#endregion

namespace Pacman.GameObjects
{
    class Virus : Ghosts
    {
        Random rnd = new Random();

        #region Constructor
        /// <summary>
        /// The constructor of the third ghost
        /// </summary>
        /// <param name="pos">gives the position of the ghost</param>
        public Virus(Vector2 pos) : base(pos, "Ghost3")
        {
            this.position = pos;
        }
        #endregion

        #region Handle Input
        /// <summary>
        /// This method cotrolls the speed at wich the ghost walks and constrains them to the screen
        /// </summary>
        /// <param name="inputHelper">handles the input for the diffirent keys</param>
        public override void HandleInput(InputHelper inputHelper)
        {
            Vector2 oldPosition = position;
            ghostWalk = rnd.Next(4);
            if (inputHelper.KeyPressed(Keys.W) || inputHelper.KeyPressed(Keys.A) || inputHelper.KeyPressed(Keys.S) || inputHelper.KeyPressed(Keys.D))
            {

                switch (ghostWalk)
                {
                    case 0:
                        {
                            if (position.Y < 975)
                            {
                                position.Y += 50;
                            }
                            break;
                        }
                    case 1:
                        {
                            if (position.X > 25)
                            {
                                position.X -= 50;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (position.Y > 25)
                            {
                                position.Y -= 50;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (position.X < 675)
                            {
                                position.X += 50;
                            }
                            break;
                        }
                }
                if (CollidesWithGhost(this))
                {
                    position = oldPosition;
                }
            }

        }
        #endregion
    }
}
