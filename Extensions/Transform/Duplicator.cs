using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Game.Modules.Extensions
{
    /// <summary>
    /// The Duplicator is a Transform Extension Type which focuses on duplicating existing 
    /// </summary>
    public class Duplicator : TransformExtension
    {
        [Title("Duplicator - Core Settings")]

        /// <summary>
        /// The Target Transform which we want to copy the data from.
        /// </summary>
        [SerializeField] [Required("The target is a core requirement")] private Transform target = null;

        [Title("Duplicator - Position Settings")]

        /// <summary>
        /// The offset we apply on top of the duplicated position.
        /// </summary>
        [SerializeField] [ShowIf("@this.duplicatePosition == true")] private Vector3 positionOffset = Vector3.zero;

        [Title("Duplicator - Position Settings")]

        /// <summary>
        /// The interpolation speed when interpolating positional values.
        /// </summary>
        [SerializeField] [ShowIf("@this.useInterpolation == true")] [Range(5.0f, 100.0f)] private float positionInterpolationSpeed = 25.0f;

        /// <summary>
        /// The interpolation speed when interpolating rotational values.
        /// </summary>
        [SerializeField] [ShowIf("@this.useInterpolation == true")] [Range(5.0f, 100.0f)] private float rotationInterpolationSpeed = 25.0f;

        [Title("Duplicator - Toggleable Settings")]

        /// <summary>
        /// Whether this Duplicator duplicates the position.
        /// </summary>
        [SerializeField] private bool duplicatePosition = false;

        /// <summary>
        /// Whether this Duplicator duplicates the position.
        /// </summary>
        [SerializeField] private bool duplicateRotation = false;

        /// <summary>
        /// Whether this Duplicator uses interpolation.
        /// </summary>
        [SerializeField] private bool useInterpolation = false;

        // Start is called before the first frame update.
        void Start()
        {

        }

        // Update is called once per frame.
        void Update()
        {
            // If the Duplicator needs to interpolate.
            if (useInterpolation)
            {
                // Then first interpolate towards the target position with the offset applied.
                transform.position = Vector3.Lerp(transform.position, target.position + positionOffset, positionInterpolationSpeed * Time.deltaTime);

                // Then interpolate the rotation.
                transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, rotationInterpolationSpeed * Time.deltaTime);

                // Then return.
                return;
            }

            // Set the position.
            transform.position = target.position;

            // Set the rotation.
            transform.rotation = target.rotation;
        }
    }
}