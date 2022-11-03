using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowiiiiiii : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 3, 4);
    }
}
