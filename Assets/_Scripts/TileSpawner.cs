using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [Header("Spawnable Tiles")]
    [SerializeField] private List<GameObject> _spawnables;
    private List<GameObject> _spawnedTiles = new List<GameObject>();

    [Header("Spawn Points")]
    [SerializeField] private List<GameObject> _spawnPoints = new List<GameObject>();
    private List<GameObject> _usedSpawns = new List<GameObject>();


    private int _currentLevel;

    void OnEnable(){
        BossController.onStartBossAtack += SpawnTiles;
        BossController.onFinishedBossAttack += RemoveTiles;
    }   
    void OnDisable(){
        BossController.onStartBossAtack -= SpawnTiles;
        BossController.onFinishedBossAttack -= RemoveTiles;
    }

    void Start(){
        _spawnPoints.AddRange(GameObject.FindGameObjectsWithTag("SpawnPoint"));
    }

    void SpawnTiles(){
        Debug.Log("Attack cycle start");
        int whereToSpawn = Random.Range(0, _spawnPoints.Count);
        GameObject newTile = Instantiate(_spawnables.RandomFromList(), _spawnPoints[whereToSpawn].transform.position, Quaternion.identity);

        _spawnedTiles.Add(newTile);
        _usedSpawns.Add(_spawnPoints[whereToSpawn]);
        _spawnPoints.RemoveAt(whereToSpawn);
    }


    void RemoveTiles(){
        Debug.Log("Attack cycle complete");

        foreach(GameObject tile in _spawnedTiles) Destroy(tile);

        _spawnPoints.AddRange(_usedSpawns);
        _usedSpawns.Clear();
    }
}
