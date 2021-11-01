using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Static
{
    /// <summary>
    /// The Creator class is a static helper class which is used for Object creation.
    /// </summary>
    public static class Creator
    {
        /// <summary>
        /// Call to create an new Game Object with a specific Component attached.
        /// </summary>
        /// <typeparam name="T">The Component you want to attach.</typeparam>
        /// <param name="gameObjectName">The name of the created Game Object.</param>
        /// <returns>The created Component instance.</returns>
        public static Component CreateGameObjectWithComponent<T>(string gameObjectName = "Created Game Object") where T : Component
        {
            // Create a new Game Object instance with a specific name.
            GameObject gameObject = new GameObject(gameObjectName);

            // Create the Component instance and then return it.
            return gameObject.AddComponent<T>();
        }
    }
}