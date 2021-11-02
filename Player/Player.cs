using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Static;

namespace Game.Modules.Creatures.Humans
{
    [RequireComponent(typeof(CharacterController))]
    /// <summary>
    /// The Player class handles movement, interaction and functional game logic.
    /// </summary>
    public class Player : Human
    {
        #region Fields

        /// <summary>
        /// The current canera rotation.
        /// </summary>
        private Vector2 cameraRotation = Vector2.zero;

        /// <summary>
        /// The interpolated canera rotation.
        /// </summary>
        private Vector2 smoothCameraRotation = Vector2.zero;

        /// <summary>
        /// The desired input direction.
        /// </summary>
        private Vector3 inputDirection = Vector3.zero;

        /// <summary>
        /// The desired move direction.
        /// </summary>
        private Vector3 moveDirection = Vector3.zero;

        #endregion

        #region Components

        /// <summary>
        /// The Characer Controller which is used for Collision detection.
        /// </summary>
        private CharacterController characterController = null;

        /// <summary>
        /// The main Camera from which we view the Scene.
        /// </summary>
        private Camera mainCamera = null;

        #endregion

        // Start is called before the first frame update.
        private void Start()
        {
            // Set the Character Controller reference.
            characterController = GetComponent<CharacterController>();

            // Set the center point of the Character Controller.
            characterController.center = Data.getPlayerCharacterControllerCenter;

            // Set the height of the Character Controller.
            characterController.height = Data.getPlayerCharacterControllerHeight;

            // Set the min move distance of the Character Controller.
            characterController.minMoveDistance = 0.0f;

            // Set the skin width of the Character Controller.
            characterController.skinWidth = 0.0f;

            // Set the Camera reference.
            mainCamera = Camera.main;
        }

        // Update is called once per frame.
        private void Update()
        {
            UpdateMovement();
            UpdateInteraction();
            UpdateCameraRotation();
        }

        /// <summary>
        /// Call to update the Player's movement.
        /// </summary>
        private void UpdateMovement()
        {
            // Set the input direction.
            inputDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

            // Interpolate towards the desired movement direction.
            moveDirection = Vector3.Lerp(moveDirection, inputDirection * Data.GetPlayerSpeed, Data.GetPlayerMovementInterpolationSpeed);

            // Apply the movement to the Character Controller.
            characterController.SimpleMove(transform.TransformDirection(moveDirection));
        }

        /// <summary>
        /// Call to update the Player's interaction with the enviroment.
        /// </summary>
        private void UpdateInteraction()
        {
            // The structure which saves information from the Raycast.
            RaycastHit hit;

            // Cast a ray from the Camera's position and the Camera's forward vector.
            if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit))
            {
                // Check if we hit anything.
                if (hit.collider.gameObject)
                {
                    // *TODO*
                    // Handle specific interaction logic.
                }
            }
        }

        /// <summary>
        /// Call to update the rotation of the Player and the Camera.
        /// </summary>
        private void UpdateCameraRotation()
        {
            // Set both camera rotation values.
            cameraRotation.y += Input.GetAxisRaw("Mouse X") * Data.getPlayerCameraSensitivity;
            cameraRotation.x += -Input.GetAxisRaw("Mouse Y") * Data.getPlayerCameraSensitivity;

            // Then make sure that the up/down rotation stays within realistic limits.
            cameraRotation.x = Mathf.Clamp(cameraRotation.x, -90.0f, 90.0f);

            // Then also make sure to not get a floating point error, so wrap the value.
            cameraRotation.y = Solver.Wrap(cameraRotation.y, -360, 360);

            // Then interpolate the smooth camera rotation.
            smoothCameraRotation = Vector2.Lerp(smoothCameraRotation, cameraRotation, Solver.GetDeltaValue(Data.getPlayerCameraInterpolation));

            // Then set the camera's rotation.
            mainCamera.transform.localRotation = Quaternion.Euler(new Vector3(smoothCameraRotation.x, 0, 0));

            // Then set the rotation of the player.
            transform.rotation = Quaternion.Euler(new Vector3(0, smoothCameraRotation.y, 0));
        }
    }
}