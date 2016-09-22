using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

	public GameObject hexPrefab;

	int width = 20;
	int height = 20;

	float xOffset = 0.884f;
	float zOffset = 0.764f;



	// Use this for initialization
	void Start () { 

		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {

				float xPos = x * xOffset;

				if (y % 2 == 1) {
					xPos += xOffset/2f;

				}

				Instantiate (hexPrefab, new Vector3( xPos,0,y * zOffset  ), Quaternion.identity  );
			}
		}
			
	}



	
	// Update is called once per frame
	void Update (){ 
	
	}
}
