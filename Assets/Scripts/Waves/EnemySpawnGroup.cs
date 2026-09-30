using System;
using UnityEngine;

[Serializable]
public class EnemySpawnGroup
{
    public string groupName = "Enemy Group";

    [Required]
    public GameObject enemyPrefab;

    [Min(0f)]
    public float spawnDelay = 0f;

    [Min(1)]
    public int enemyCount = 1;

    [Min(0f)]
    public float spawnInterval = 1f;

    [Min(0f)]
    public float difficultyMultiplier = 1f;

    public float LastSpawnTime
    {
        get
        {
            if (enemyCount <= 0)
                return spawnDelay;

            return spawnDelay + (enemyCount - 1) * spawnInterval;
        }
    }

    public float DifficultyScore
    {
        get
        {
            if (enemyPrefab == null)
                return 0f;

            return enemyCount * difficultyMultiplier;
        }
    }
}