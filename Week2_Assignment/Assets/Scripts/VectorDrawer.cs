using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class myClass { };

public class VectorDrawer : MonoBehaviour
{

    // Declare variables here that are global to this script / class / GameObject
    //public Vector3 from = new Vector3(0, 0, 0);
    //public Vector3 to = new Vector3(1,10,1);
    public Vector3 direction = new Vector3(0, 0, 0);
    [Range(0,10)]
    public float scale = 1;
    public Color color;


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnDrawGizmos()
    {
        //DrawVector(transform.position, transform.right, Color.red);
        //DrawVector(transform.position, transform.up, Color.green);
        //DrawVector(transform.position, transform.forward*scale, Color.blue);

        //DrawVector(transform.position, transform.rotation*direction.normalized * scale, Color.white);
		DrawVector(transform.position, direction.normalized*scale, Color.red);
    }

	void DrawVector(Vector3 start, Vector3 direction, Color color)
    {
        Gizmos.color = color;
        Gizmos.DrawLine(start,start+direction);
    }
    
}

