using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{

	public GameObject [] paths;
	public GameObject trees;
	
	public int renderDistance;
	
	public int treeChance;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
            GameObject path;
            for( float i = 0f; i < renderDistance; i++)
            {
	            path = Instantiate(paths[0], new Vector3(0,0,7.5f*i), transform.rotation);
	            path.AddComponent<MovingTerrain>();
	    }
    }
    
    public void spawnNew()
    {
	GameObject path;
	
	if( Random.Range(0, 100) < 25 )
		path = Instantiate(paths[3], new Vector3(0,0,7.5f*renderDistance), transform.rotation);
	else
		path = Instantiate(paths[0], new Vector3(0,0,7.5f*renderDistance), transform.rotation);
		
	path.AddComponent<MovingTerrain>();
		
	if( Random.Range(0, 100) < treeChance )
	{
		bool isNeg = false;
		int treeCount = Random.Range(0,3);
		Debug.Log("Tree Count: " + treeCount.ToString() );
		for( int i = 0; i < treeCount; i++ )
		{
			float distanceFromPath = Random.Range(3.14f, 6f);
			float neg = Random.Range(0,2);
			float height = Random.Range(-1.5f, 0f);
			if( i == 0 )
			{
				if( neg == 1)
				{
					distanceFromPath *= -1;
					isNeg = true;
				}
			}else
			{
				if( !isNeg )
				{
					distanceFromPath *= -1;
				}				
			}
			
			
			int rotation = Random.Range(1, 5);
			path = Instantiate( trees, new Vector3(distanceFromPath,height,7.5f*renderDistance), Quaternion.Euler(0,rotation * 90,0));
			path.AddComponent<MovingTerrain>();
	
		}
	}
    }
}
