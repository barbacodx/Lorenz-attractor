/**
 * [...]
 * The Lorenz system is a system of ordinary differential equations first studied by 
 Edward Lorenz. It is notable for having chaotic solutions for certain parameter values and initial conditions. 
 In particular, the Lorenz attractor is a set of chaotic solutions of the Lorenz system. 
 *  
 *
 * 	The Butterfly Effect 
 * @author  Riccardo Barbatti
 * @version 1.0, 08/03/22
 * @
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LorenzAttractor : MonoBehaviour
{

	private float x = 1.0f;
	private float y = 0.0f;
	private float z = 0.0f;
	
	private float a = 10.0f;
	private float b = 8.0f/3.0f;
	private float c = 28.0f;
    
    private float rotFly = 0f;

    private bool isRunning = true;

    public List<Vector3> MyPositions = new List<Vector3>();
   // ArrayList<Vector> points = new ArrayList<PVector>();
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void ButterFlyInit(){


        rotFly = rotFly + 0.005f;
       // rotateY(rotFly);
        //rotFly = rotFly + 0.005;
     //   rotateY(rotation);

        float dt = 0.01f;
        float dx = (a * (y - x)) * dt;
        float dy = (x * (c - z) - y) * dt;
        float dz = (x * y - b * z) * dt;
        x = x + dx;
        y = y + dy;
        z = z + dz;
        // point(x, y, z);
        // points.add(new PVector(x, y, z));

         MyPositions.Add(new Vector3(x, y, z));
        Debug.DrawLine (Vector3.zero, new Vector3(x, y, z), Color.red);
        // beginShape();

        /*
                for (PVector v : points) {
                    vertex(v.x, v.y, v.z);
                }*/
        // endShape();
        //}


    }


    // Update is called once per frame
    void Update()
    {

        ButterFlyInit();
    }
}
