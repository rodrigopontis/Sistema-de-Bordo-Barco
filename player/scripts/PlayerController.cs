using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponentInChildren<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement.Update();
    }
}
