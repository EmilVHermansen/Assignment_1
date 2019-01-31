using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKillerCubes : MonoBehaviour
{
	[SerializeField] GameObject sphere;
	[SerializeField] Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void SpawnEnemies()
	{
		Instantiate(sphere, pos, Quaternion.identity).SetActive(true);
		
	}
	
}
