using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    Vector3  r0 = new Vector3(0, 0, 0);
    Vector3  r1 = new Vector3(0, 0, 0);
    Vector3  r2 = new Vector3(0, 0, 0);
    Vector3  r3 = new Vector3(0, 0, 0);
    Vector3  r4 = new Vector3(0, 0, 0);
    Vector3  r5 = new Vector3(0, 0, 0);
    Vector3  r6 = new Vector3(0, 0, 0);
    Vector3  r7 = new Vector3(0, 0, 0);
    Vector3  r8 = new Vector3(0, 0, 0);
    Vector3  r9 = new Vector3(0, 0, 0);
    Vector3 r10 = new Vector3(0, 0, 0);
    Vector3 r11 = new Vector3(0, 0, 0);
    
    float d0 = 0;
    float d1 = 0;
    float d2 = 0;
    float d3 = 0;
    float d4 = 0;
    float d5 = 0;
    float d6 = 0;
    float d7 = 0;
    float d8 = 0;
    float d9 = 0;
    float d10 = 0;
    float d11 = 0;

    void Start () {
        r0 = GameObject.Find("r (0)").transform.position;
        r1 = GameObject.Find("r (1)").transform.position;
        r2 = GameObject.Find("r (2)").transform.position;
        r3 = GameObject.Find("r (3)").transform.position;
        r4 = GameObject.Find("r (4)").transform.position;
        r5 = GameObject.Find("r (5)").transform.position;
        r6 = GameObject.Find("r (6)").transform.position;
        r7 = GameObject.Find("r (7)").transform.position;
        r8 = GameObject.Find("r (8)").transform.position;
        r9 = GameObject.Find("r (9)").transform.position;
        r10 = GameObject.Find("r (10)").transform.position;
        r11 = GameObject.Find("r (11)").transform.position;
    }

	void Update () {
        Vector3 myPos = transform.localPosition;

         d0 = Vector3.Distance(myPos,  r0); //Debug.Log("Distance to r0: " + d0);
         d1 = Vector3.Distance(myPos,  r1); //Debug.Log("Distance to r1: " + d1);
         d2 = Vector3.Distance(myPos,  r2); //Debug.Log("Distance to r2: " + d2);
         d3 = Vector3.Distance(myPos,  r3); //Debug.Log("Distance to r3: " + d3);
         d4 = Vector3.Distance(myPos,  r4); //Debug.Log("Distance to r4: " + d4);
         d5 = Vector3.Distance(myPos,  r5); //Debug.Log("Distance to r5: " + d5);
         d6 = Vector3.Distance(myPos,  r6); //Debug.Log("Distance to r6: " + d6);
         d7 = Vector3.Distance(myPos,  r7); //Debug.Log("Distance to r7: " + d7);
         d8 = Vector3.Distance(myPos,  r8); //Debug.Log("Distance to r8: " + d8);
         d9 = Vector3.Distance(myPos,  r9); //Debug.Log("Distance to r9: " + d9);
        d10 = Vector3.Distance(myPos, r10); //Debug.Log("Distance to r10: " + d10);
        d11 = Vector3.Distance(myPos, r11); //Debug.Log("Distance to r11: " + d11);
    }
}