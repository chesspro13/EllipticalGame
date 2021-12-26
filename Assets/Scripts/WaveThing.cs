using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveThing : MonoBehaviour
{

	public GameObject speedController;
	public GameObject waawaa;
	
    // Start is called before the first frame update
    void Start()
    {
        speedController = GameObject.FindGameObjectsWithTag("GameController")[0];
    }

    // Update is called once per frame
    void Update()
    {
    	transform.Translate(transform.forward * ( -speedController.GetComponent<SpeedController>().getSpeed() - 2 ) * 10f * Time.deltaTime );
    	GameObject water;
    	if( transform.position.z < 0 )
    	{
		transform.position = new Vector3(0,-52,11215);
	}
    }
}
