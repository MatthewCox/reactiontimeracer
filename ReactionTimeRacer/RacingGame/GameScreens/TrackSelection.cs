#region File Description
//-----------------------------------------------------------------------------
// TrackSelection.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using RacingGame.GameLogic;
using RacingGame.Graphics;
using RacingGame.Helpers;
using RacingGame.Properties;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RacingGame.Sounds;
using RacingGame.Landscapes;
#endregion

namespace RacingGame.GameScreens
{
    /// <summary>
    /// Track selection screen
    /// </summary>
    /// <returns>IGame screen</returns>
    class TrackSelection : IGameScreen
    {
        #region Constants
        static readonly Rectangle[] ButtonRects = new Rectangle[]
            {
                UIRenderer.TrackButtonBeginnerGfxRect,
                UIRenderer.TrackButtonAdvancedGfxRect,
                UIRenderer.TrackButtonExpertGfxRect,
            };
        static readonly Rectangle[] TextRects = new Rectangle[]
            {
                UIRenderer.TrackTextBeginnerGfxRect,
                UIRenderer.TrackTextAdvancedGfxRect,
                UIRenderer.TrackTextExpertGfxRect,
            };
        const int NumberOfButtons = 3,
            ActiveButtonWidth = 132,
            InactiveButtonWidth = 108,
            DistanceBetweenButtons = 32;
        #endregion

        #region Render
        /// <summary>
        /// Start with button 0 being selected (beginner track)
        /// Update: Now use advanced track as default, looks better in replays.
        /// </summary>
        static int selectedButton = 1;

        /// <summary>
        /// Selected track number
        /// </summary>
        /// <returns>Int</returns>
        static public int SelectedTrackNumber
        {
            get
            {
                return selectedButton;
            }
        }

        /// <summary>
        /// Selected track
        /// </summary>
        /// <returns>Track level</returns>
        static public RacingGameManager.Level SelectedTrack
        {
            get
            {
                return (RacingGameManager.Level)1;
            }
        }

        /// <summary>
        /// Current button sizes for scaling up/down smooth effect.
        /// </summary>
        float[] currentButtonSizes =
            new float[NumberOfButtons] { 1, 0, 0 };

        /// <summary>
        /// Ignore the mouse unless it moves;
        /// this is so the mouse does not disrupt game pads and keyboard
        /// </summary>
        bool ignoreMouse = true;

        /// <summary>
        /// Render game screen. Called each frame.
        /// </summary>
        public bool Render()
        {
            if (Input.KeyboardEscapeJustPressed ||
                Input.GamePadBJustPressed ||
                Input.GamePadBackJustPressed ||
                BaseGame.UI.backButtonPressed)
                return true;

            RacingGameManager.AddGameScreen(new GameScreen());

            return false;
        }
        #endregion
    }
}
