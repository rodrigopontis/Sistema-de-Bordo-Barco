using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody Rigidbody;
    public float depthBeforeSubmerged = 1f;
    public float displacementAmount = 3f;

    // Update is called once per frame
    private void FixedUpdate()
    {
        float waveHeight = WaveManager.instance.GetWaveHeight(transform.position.x);
        //sez é subaquatico than aplicar força de flutuar
        if(transform.position.y < waveHeight)
        {
                                                    //quanto objeto submerso + forte força de flutuação    * valor de deslocamento
            float empuxo = Mathf.Clamp01((waveHeight - transform.position.y) / depthBeforeSubmerged) * displacementAmount;
            Rigidbody.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * empuxo, 0f), ForceMode.Acceleration);
        }
    }
}
