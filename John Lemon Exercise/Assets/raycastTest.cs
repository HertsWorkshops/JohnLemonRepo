using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastTest : MonoBehaviour
{

    public float parachuteEffectiveness;
    public float deploymentHeight;

    private bool deployed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray landingRay = new Ray(transform.position, Vector3.down);
        Debug.DrawRay(transform.position, Vector3.down * deploymentHeight, Color.red);

        if (!deployed)
        {
            if (Physics.Raycast(landingRay, out hit ,deploymentHeight))
            {
                if (hit.collider.tag == "environment")
                {
                    DeployParachute();
                }
            }
        }


        
    }

    void DeployParachute()
    {
        deployed = true;
        gameObject.GetComponent<Rigidbody>().drag = parachuteEffectiveness;
        
    }
}
