using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    Rigidbody cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space)){
        // Destroys gameObject on pressing Space
            //Destroy(gameObject);
        // Adds upwards force to cube
            cube.AddForce(Vector3.up*200);
        // Adds Velocity to object
            cube.velocity = Vector3.forward * 2f;    
        }

        if(Input.GetKeyDown(KeyCode.K)){
            SceneManager.LoadScene("Level2");
        }
    }

    private void OnMouseDown(){
       // Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Enemy"){
            Destroy(collision.gameObject);
        }
            
    }
}
