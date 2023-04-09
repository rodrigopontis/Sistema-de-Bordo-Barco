
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {

        private CharacterController controller;

        // Input stuffs
        private float horizontal;
        private float vertical;

        // Stats do controlador
        public float speed = 3.0F;
        public float gravityForce = 9.8f;
        private float gravity;

        public float rotateSpeed = 3.0F;
        public bool isGrounded;


        // Start is called before the first frame update
        private void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        private void Update()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            isGrounded = controller.isGrounded;

            // gravidade
            if (!isGrounded)
            {
                gravity -= gravityForce * Time.deltaTime;
                controller.SimpleMove(new Vector3(0, gravity, 0));
            }
        }


        public void Move()
        {
            if (vertical != 0)
            {
                controller.SimpleMove(vertical * speed * transform.forward);
            }
        }

        public float GetVertical()
        {
            return this.vertical;
        }
    }
}