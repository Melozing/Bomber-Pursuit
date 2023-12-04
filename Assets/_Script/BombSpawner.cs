using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    List<GameObject> bombs;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;
    protected GameObject bombPrefab;
    protected GameObject player;

    private void Awake()
    {
        this.bombPrefab = GameObject.Find("BombPrefab");
        this.bombPrefab.SetActive(false);

        this.player = GameObject.Find("Player");
    }


    private void Start()
    {
        this.bombs = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        this.Spawn();

        this.CheckBombDead();

    }

    void Spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < spawnDelay) { return; }
        this.spawnTimer = 0f;

        if (this.bombs.Count >= 7)
        {
            return;
        }

        int index = this.bombs.Count + 1;

        GameObject bomb = Instantiate(this.bombPrefab);
        bomb.name = "Bom #" + index;

        bomb.transform.position = this.player.transform.position;
        bomb.transform.parent = this.transform;
        bomb.gameObject.SetActive(true);

        this.bombs.Add(bomb);
    }

    void CheckBombDead()
    {
        GameObject bomb;
        for (int i = 0; i < bombs.Count; i++)
        {
            bomb = this.bombs[i];
            if (bomb == null) this.bombs.RemoveAt(i);
        }
    }
}
