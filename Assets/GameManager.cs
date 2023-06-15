using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject redcar;
    public GameObject bluecar;
    public GameObject vancar;
    public GameObject buscar;
    public GameObject armorcar;
    GameObject clone;

    GameObject[] zombie;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(GameObject.FindWithTag("Car")==null)
            {
                clone=Instantiate(redcar);
                Camera.main.gameObject.GetComponent<CameraWithCar>().enabled = true;
                Camera.main.gameObject.GetComponent<CameraWithCar>().cartransform = clone.transform;
                clone.GetComponent<AudioSource>().Play();
            }   
        }
        */
    }
   
    public void CreateCar(GameObject car)
    {
            Destroy(GameObject.FindWithTag("Car"));
            clone = Instantiate(car);
            Camera.main.gameObject.GetComponent<CameraWithCar>().enabled = true;
            Camera.main.gameObject.GetComponent<CameraWithCar>().cartransform = clone.transform;
            clone.GetComponent<AudioSource>().Play();

        zombie = GameObject.FindGameObjectsWithTag("Zombie");
        for(int i=0;i<zombie.Length;i++)
        {
            zombie[i].GetComponent<Animator>().SetBool("Walk", true);
        }
    }
}
