using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D c1){
        if(c1.gameObject.tag == "Piso"){
            Destroy(this.gameObject);
        }
        if(c1.gameObject.tag == "Bala"){
            
            Destroy(this.gameObject);
            Destroy(c1.gameObject);
        }
    }
}
