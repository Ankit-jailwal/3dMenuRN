using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroys gameObject on pressing Space
        if(Input.GetKeyDown(KeyCode.Space)){
            Destroy(gameObject);
        }
    }

    private void OnMouseDown(){
        Destroy(gameObject);
    }
}
