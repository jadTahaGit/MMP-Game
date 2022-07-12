using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnerController : MonoBehaviour
{

    [SerializeField]
    private GameObject asteroidPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnAsteroid();
    }

    // Update is called once per frame
    void SpawnAsteroid()
    {
        GameObject asteroidInstance = Instantiate(asteroidPrefab) as GameObject;
        asteroidInstance.transform.position = new Vector2(0, 10);
    }
}
