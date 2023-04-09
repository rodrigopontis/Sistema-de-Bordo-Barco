namespace Player
{
    using UnityEngine;

    public class AnimatorHandler : MonoBehaviour
    {

        private Animator anim;
        private PlayerMovement playerMovement;

        private void Awake()
        {
            anim = GetComponent<Animator>();
            playerMovement = GetComponentInParent<PlayerMovement>();
        }

        private void LateUpdate()
        {
            if (playerMovement.GetVertical() != 0)
            {
                anim.SetBool("isWalking", true);
            }
            else
            {
                anim.SetBool("isWalking", false);
            }
        }
    }
}