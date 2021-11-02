using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Static
{
    /// <summary>
    /// The Solver class is a static helper class which is used for Math related stuff.
    /// </summary>
    public static class Solver
    {
        /// <summary>
        /// Returns a value multiplied by the current Delta Time.
        /// </summary>
        /// <returns>A multiplied delta value.</returns>
        public static float GetDeltaValue(float value)
        {
            // Return the multiplied value.
            return value * Time.deltaTime;
        }

        /// <summary>
        /// Returns a value wrapped between a minimum and maximum amount.
        /// </summary>
        /// <param name="value">The value that needs to get wrapped.</param>
        /// <param name="min">The minimum range value.</param>
        /// <param name="max">The maximum range value.</param>
        /// <returns>A wrapped value.</returns>
        public static float Wrap(float value, float min = 0, float max = 1)
        {
            // If the value is below the minimum then return the maximum.
            if (value < min)
                return max;

            // If the value is below the maximum then return the minimum.
            if (value > max)
                return min;

            // If the value is still within range then just return it.
            return value;
        }
    }
}