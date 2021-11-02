using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules.Extensions
{
    /// <summary>
    /// The Extension class is the base class for all custom Extension Types.
    /// </summary>
    public abstract class Extension : Module
    {
        /// An Extension is a very specialized class type usually used for doing one specific task.
        /// For Example:
        /// You want to make a Game Object copy the Transform values from another Transform but don't want to clutter your project with massive amounts of loose Mono Behaviour's.
    }
}