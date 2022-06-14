using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidbody;
        float width;
    public float speed;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        width = Camera.main.pixelWidth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
           
            Vector3 position = new Vector3((touch.position.x / width - 0.5f) * 6.0f, 1.0f , rigidbody.position.z);
            
            rigidbody.MovePosition(position);



        }
        rigidbody.velocity = Vector3.forward*speed;
   

    }
}
