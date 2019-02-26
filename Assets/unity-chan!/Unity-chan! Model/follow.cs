using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
        
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;    
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);
        transform.RotateAround(player.transform.position, Vector3.up, player.transform.localEulerAngles.y + 180);
        //transform.rotation = Quaternion.Euler(0, player.transform.localEulerAngles.y +180, 0);
    }
}
