using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTerrain : MonoBehaviour
{

	private GameObject gm;
	private GameObject tg;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectsWithTag("GameController")[0];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * gm.GetComponent<SpeedController>().getSpeed() * Time.deltaTime, Space.World);
        if( transform.position.z < 2.5 )
        {
        	if( this.gameObject.name == "Ground01(Clone)" || this.gameObject.name == "Bridge_Large(Clone)" )
        	{
	        	gm.GetComponent<TerrainGenerator>().spawnNew();
	        }
	        Destroy(this.gameObject);
	}
    }
}
