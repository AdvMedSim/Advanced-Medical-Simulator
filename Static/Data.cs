using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Static
{
    /// <summary>
    /// The Data class is a static helper class which contains globally used values.
    /// </summary>
    public static class Data
    {
        #region Interpolation

        /// <summary>
        /// Returns the global interpolation speed multiplied by the Delta Time.
        /// </summary>
        public static float GetGlobalInterpolationSpeed
        {
            get { return 25.0f * Time.deltaTime; }
        }

        #endregion

        #region Player

        /// <summary>
        /// Returns the base speed.
        /// </summary>
        public static float GetPlayerSpeed
        {
            get { return 5.0f; }
        }

        // Returns the interpolation speed for the movement multiplied by the Delta Time.
        public static float GetPlayerMovementInterpolationSpeed
        {
            get { return 10 * Time.deltaTime; }
        }

        /// <summary>
        /// Returns the height offset for the Player's Character Controller.
        /// </summary>
        public static float getPlayerCharacterControllerHeight
        {
            get { return 2.0f; }
        }

        /// <summary>
        /// Returns the center point offset for the Player's Character Controller.
        /// </summary>
        public static Vector3 getPlayerCharacterControllerCenter
        {
            get { return new Vector3(0, 1.0f, 0); }
        }

        #endregion
    }
}