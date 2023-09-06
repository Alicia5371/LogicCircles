using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Conroller : MonoBehaviour
{
    public float speed;
    public bool right;

    // Start is called before the first frame update
    void Start()
    {
        if (!right) //if right is false
        {
            transform.Rotate(Vector3.back * 180); //Then rotate 180 degrees and go left
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name); //Using "other" lets us acess information about the object it collided with.
        DirectionalNode dn = other.GetComponent<DirectionalNode>();
        Debug.Log(dn.current);

        float rot = 0; //rot == rotation
        Vector3 dir = Vector3.zero; //Means 0,0,0 it does not move  //dir == direction
        if (dn.current == "right")
        {
            dir = Vector3.back;
            rot = 90;
        }
        else if (dn.current == "left")
        {
            dir = Vector3.forward;
            rot = 90;
        }



        transform.Rotate(dir * rot); //back == right rotation, forward == left rotation
    }
}
