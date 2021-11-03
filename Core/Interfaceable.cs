using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game.Modules.Interfaceables
{
    /// <summary>
    /// The Interfaceable class is the base class for all Interface Types.
    /// </summary>
    public abstract class Interfaceable : Module, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
    {
        /// <summary>
        /// Whether the cursor is hovering over this Interfaceable.
        /// </summary>
        private bool isHovering = false;

        /// <summary>
        /// Called whenever the user clicks on this Interfaceable.
        /// </summary>
        internal virtual void OnClick()
        {

        }

        /// <summary>
        /// Called whenever the user hovers over this Interfaceable.
        /// </summary>
        internal virtual void OnHoverEnter()
        {
            // Set the hovering state.
            isHovering = true;
        }

        /// <summary>
        /// Called whenever the user leaves this Interfaceable.
        /// </summary>
        internal virtual void OnHoverExit()
        {
            // Set the hovering state.
            isHovering = true;
        }

        /// <summary>
        /// Returns whether the user is hovering over this Interfaceable.
        /// </summary>
        /// <returns>The hovering state.</returns>
        public bool IsHovering()
        {
            if (isHovering)
                return true;

            return false;
        }

        #region Interface Implementations

        // Called whenever the cursor clicks on the Game Object.
        public void OnPointerClick(PointerEventData pointerEventData)
        {

        }

        // Called whenever the cursor passes over the Game Object.
        public void OnPointerEnter(PointerEventData pointerEventData)
        {

        }

        // Called whenever the cursor leaves the Game Object.
        public void OnPointerExit(PointerEventData pointerEventData)
        {

        }

        #endregion
    }
}