namespace Player
{
    using UnityEngine;

    public class PlayerManager : MonoBehaviour
    {

        private PlayerMovement playerMovement;

        private void Start()
        {
            playerMovement = GetComponent<PlayerMovement>();
        }

        private void Update()
        {
            playerMovement.Move();
        }
    }
}