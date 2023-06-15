using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    // Start is called before the first frame update
    Animator zombieman;
    void Start()
    {
        zombieman = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //zombieman.Play("walk");                 //here I will put the name of the state          //it wil play even if there is no transaction from another state
            zombieman.SetBool("Walk", true);        //here I will put the name of parameter that I put in condition of transaction
        }
        */
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
            zombieman.SetBool("Die", true);
    }

}
