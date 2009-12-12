#region File Description
//-----------------------------------------------------------------------------
// NameScreen.cs
//
// Allows player to enter their name
//-----------------------------------------------------------------------------
#endregion

#region Using directives
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using RacingGame.GameLogic;
using RacingGame.Graphics;
using RacingGame.Helpers;
using RacingGame.Sounds;
#endregion

namespace RacingGame.GameScreens
{
    class NameScreen : IGameScreen
    {
        private struct NameIn
        {
            public string name;

            public NameIn(string setName)
            {
                name = setName;
            }
        }

        public bool Render()
        {
            // This starts both menu and in game post screen shader!
            BaseGame.UI.PostScreenMenuShader.Start();

            // Render background
            BaseGame.UI.RenderMenuBackground();
            BaseGame.UI.RenderBlackBar(160, 498 - 160);

            BaseGame.UI.RenderBottomButtons(true);

            if (Input.KeyboardEscapeJustPressed ||
                Input.GamePadBJustPressed ||
                Input.GamePadBackJustPressed)
                return true;

            return false;
        }
    }
}