using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnerController : MonoBehaviour
{

    [SerializeField]
    private GameObject asteroidPrefab;
    [SerializeField]
    private float respawnTime = 1.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        StartCoroutine(AsteroidWave());
    }

    // Update is called once per frame
    void SpawnAsteroid()
    {
        GameObject asteroidInstance = Instantiate(asteroidPrefab) as GameObject;
        float spawnX = Random.Range(-screenBounds.x, screenBounds.x);
        asteroidInstance.transform.position = new Vector2(spawnX, 10);
    }

    private IEnumerator AsteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            SpawnAsteroid();

        }
    }
}
