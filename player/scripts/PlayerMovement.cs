
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private  Animator anim;

    // Input stuffs
    public float horizontal;
    public float vertical;
    
    // Stats do controlador
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;

    // Start is called before the first frame update
    public void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if(vertical != 0){
            anim.SetBool("isWalking", true);
        }else{
            anim.SetBool("isWalking", false);
        }

        // rotation
        transform.Rotate(0, horizontal * rotateSpeed, 0);
        
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * vertical;
        
        transform.position = transform.position + new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);
    }
}
