using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCar : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public int mov;
    public int rot;
    float hor,ver;
    bool ModeFalg;

    Animator zombieanim;
    public GameObject blood;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        ver = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Q))
            ModeFalg = !ModeFalg;

    }
    private void FixedUpdate()
    {
        if(ModeFalg)
        {
            rot = 50;
            rb.AddRelativeForce(Vector3.forward * ver * mov, ForceMode.Acceleration);
            rb.AddTorque(Vector3.up * hor * rot, ForceMode.Force);
        }
        else
        {
            rot = 5;
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.Translate(Vector3.forward * ver * mov * Time.deltaTime);
            transform.Translate(Vector3.right * hor * rot * Time.deltaTime);
        }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
            other.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            collision.gameObject.GetComponent<Animator>().SetBool("Die", true);
            Instantiate(blood, collision.gameObject.transform);
        }
    }
}
