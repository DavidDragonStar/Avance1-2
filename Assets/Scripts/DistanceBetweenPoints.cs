using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceBetweenPoints : MonoBehaviour { 
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
    
	//0
    public float d0_1 = 0;
    public float d0_3 = 0;
    public float d0_6 = 0;
	//1
	public float d1_0 = 0;
	public float d1_2 = 0;
	public float d1_9 = 0;
	//2
	public float d2_1 = 0;
	public float d2_3 = 0;
	public float d2_11 = 0;
	//3
	public float d3_0 = 0;
	public float d3_2 = 0;
	public float d3_4 = 0;
	//4
	public float d4_3 = 0;
	public float d4_5 = 0;
	public float d4_11 = 0;
	//5
	public float d5_4 = 0;
	public float d5_6 = 0;
	//6
	public float d6_0 = 0;
	public float d6_5 = 0;
	public float d6_7 = 0;
	//7
	public float d7_6 = 0;
	public float d7_8 = 0;
	//8
	public float d8_7 = 0;
	public float d8_9 = 0;
	//9
	public float d9_1 = 0;
	public float d9_8 = 0;
	public float d9_10 = 0;
	//10
	public float d10_9 = 0;
	public float d10_11 = 0;
	//11
	public float d11_2 = 0;
	public float d11_4 = 0;
	public float d11_10 = 0;
	
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

		d0_1 = Vector3.Distance(r0, r1); 	print("0 a 1: " + d0_1 + "m");
		d0_3 = Vector3.Distance(r0, r3); 	print("0 a 3: " + d0_3 + "m");
		d0_6 = Vector3.Distance(r0, r6); 	print("0 a 6: " + d0_6 + "m");

		d1_0 = d0_1; 						print("1 a 0: " + d1_0 + "m");
		d1_2 = Vector3.Distance(r1, r2); 	print("1 a 2: " + d1_2 + "m");
		d1_9 = Vector3.Distance(r1, r9); 	print("1 a 9: " + d1_9 + "m");

		d2_1 = d1_2; 						print("2 a 1: " + d2_1 + "m");
		d2_3 = Vector3.Distance(r2, r3); 	print("2 a 4: " + d2_3 + "m");
		d2_11 = Vector3.Distance(r2, r11); 	print("2 a 11: " + d2_11 + "m");

		d3_0 = d0_3; 						print("3 a 0: " + d3_0 + "m");
		d3_2 = d2_3; 						print("3 a 2: " + d3_0 + "m");
		d3_4 = Vector3.Distance(r3, r4); 	print("3 a 4: " + d3_4 + "m");

		d4_3 = d3_4; 						print("4 a 3: " + d4_3 + "m");
		d4_5 = Vector3.Distance(r4, r5); 	print("4 a 5: " + d4_5 + "m");
		d4_11 = Vector3.Distance(r4, r11); 	print("4 a 5: " + d4_11 + "m");

		d5_4 = d4_5; 						print("5 a 4: " + d5_4 + "m");
		d5_6 = Vector3.Distance(r5, r6);	print("5 a 6: " + d5_6 + "m");

		d6_0 = d0_6; 						print("6 a 0: " + d6_0 + "m");
		d6_5 = d5_6;						print("6 a 5: " + d6_5 + "m");
		d6_7 = Vector3.Distance(r6, r7);	print("6 a 7: " + d6_7 + "m");

		d7_6 = d6_7;						print("7 a 6: " + d7_6 + "m");
		d7_8 = Vector3.Distance(r7, r8);	print("7 a 8: " + d7_8 + "m");

		d8_7 = d7_8;						print("8 a 7: " + d8_7 + "m");
		d8_9 = Vector3.Distance(r8, r9);	print("8 a 9: " + d8_9 + "m");

		d9_1 = d1_9;						print("9 a 1: " + d9_1 + "m");
		d9_8 = d8_9;						print("9 a 8: " + d9_8 + "m");
		d9_10 = Vector3.Distance(r9, r10);	print("9 a 10: " + d9_10 + "m");

		d10_9 = d9_10;						print("10 a 9: " + d10_9 + "m");
		d10_11 = Vector3.Distance(r10, r11);print("10 a 11: " + d10_11 + "m");

		d11_2 = d2_11; 						print("11 a 2: " + d11_2 + "m");
		d11_4 = d4_11; 						print("11 a 4: " + d11_4 + "m");
		d11_10 = d10_11; 					print("11 a 10: " + d11_10 + "m");
	}
}