using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float deltaz;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, player.transform.position.z - deltaz);
    }
}
