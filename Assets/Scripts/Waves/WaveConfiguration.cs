using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "NewWave",
    menuName = "Waves/Wave Configuration"
)]
public class WaveConfiguration : ScriptableObject
{
    [Header("General Configuration")]

    public string waveName = "New Wave";

    [Min(1f)]
    public float duration = 30f;

    public AudioClip audio;

    [Header("Enemy Groups")]

    public List<EnemySpawnGroup> enemyGroups = new List<EnemySpawnGroup>();

    [Header("Boss Configuration")]

    public bool hasBoss = false;

    [Required]
    public GameObject bossPrefab;

    [Min(0f)]
    public float bossSpawnTime = 0f;

    [Header("Difficulty")]

    public AnimationCurve difficultyCurve =
        AnimationCurve.Linear(0f, 1f, 1f, 1f);

#if UNITY_EDITOR
    [TextArea(3, 6)]
    public string designerNotes;
#endif
}