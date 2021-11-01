using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules
{
    /// <summary>
    /// The Module class is the base class for all custom Modules/Systems/Components.
    /// </summary>
    public abstract class Module : MonoBehaviour
    {
        /// <summary>
        /// Call to log the position, rotation and the local scale of this Module to the Console.
        /// </summary>
        public void DebugModule()
        {
            // Log the position.
            Debug.Log(transform.position);

            // Log the rotation.
            Debug.Log(transform.rotation);

            // Log the local scale.
            Debug.Log(transform.localScale);
        }
    }
}