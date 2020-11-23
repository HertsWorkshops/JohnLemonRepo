using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCollider : MonoBehaviour
{
    public Animator CubeAnimatior;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (CubeAnimatior.GetBool("isTriggered") == false)
            {
            CubeAnimatior.SetBool("isTriggered", true);

            }
            else if (CubeAnimatior.GetBool("isTriggered") == true)
            {
                CubeAnimatior.SetBool("isTriggered", false);

            }

        }
    }
   

}
