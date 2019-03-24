using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
  
	public GameObject platformPrefab;
    public GameObject rplatformPrefab;
    
    public int numberofredplats = 100;
	public int numberOfPlatforms = 500;
	public float levelWidth = .5f;
	public float minY = .01f;
	public float maxY = .03f;
    public float redY = 3f;
    public float maxredY =6f;

    // Use this for initialization
    void Start () {

		Vector3 spawnPosition = new Vector3();

		for (int i = 0; i < numberOfPlatforms; i++)
		{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
		}

        Vector3 spaunPosition = new Vector3();

        for (int i = 0; i < numberofredplats; i++)
        {
            spaunPosition.y += Random.Range(redY,maxredY);
            spaunPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(rplatformPrefab, spaunPosition, Quaternion.identity);

        }

        
    }
}