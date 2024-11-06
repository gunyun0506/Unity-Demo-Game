using UnityEngine;

public class Practice : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            Renderer renderer =  GetComponent<Renderer> ();
            renderer.material.color = Color.red;
            
        }
    }
}
