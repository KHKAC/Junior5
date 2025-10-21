using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score;
    public TextMeshProUGUI scoreTxt;
    public List<GameObject> targets;
    float spawnRate = 1.0f;

    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        scoreTxt.text = $"{score}";
    }

    IEnumerator SpawnTarget()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
}
