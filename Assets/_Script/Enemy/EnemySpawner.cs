using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    protected List<GameObject> enemies;
    protected int maxEnemy = 1;
    protected GameObject enemySpawnPos;
    protected GameObject enemyPrefab;
    protected float time = 0f;
    protected float delay = 1f;

    private void Awake()
    {
        this.enemySpawnPos = GameObject.Find("EnemySpawnPos");
        this.enemyPrefab = GameObject.Find("EnemyPrefab");
        this.enemyPrefab.SetActive(false);

        this.enemies = new List<GameObject>();
    }

    private void Update()
    {
        this.Spawn();
        this.CheckDead();
    }

    protected virtual void Spawn()
    {
        if (PlayerCtrl.instance.damageReceiver.IsDead()) return;
        if (this.enemies.Count >= this.maxEnemy) return;

        this.time += Time.deltaTime;
        if (this.time < this.delay)
        {
            return;
        }
        this.time = 0f;

        GameObject enemy = Instantiate(this.enemyPrefab);
        enemy.transform.position = this.enemySpawnPos.transform.position;
        enemy.transform.parent = transform;
        enemy.SetActive(true);

        this.enemies.Add(enemy);
    }

    void CheckDead()
    {
        GameObject minion;
        for (int i = 0; i < this.enemies.Count; i++)
        {
            minion = this.enemies[i];
            if (minion == null) { this.enemies.RemoveAt(i); }
        }
    }
}
