using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
	public Transform spawnPoint;
	public Transform enemyPrefab;
	public Text waveCountdownText;

	public float timeBetweenWaves = 10f;
	private float countdown = 5f;

	public static int waveIndex;

    void Start()
    {
		waveIndex = 0;
	}

    void Update()
	{
		if (countdown <= 0f)
		{
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;
		waveCountdownText.text = " Next wave in: " + Mathf.Round(countdown).ToString();
	}

	IEnumerator SpawnWave()
	{
		waveIndex++;

		if (waveIndex <= 5)
        {
			for (int i = 0; i < waveIndex; i++)
			{
				SpawnEnemy();
				yield return new WaitForSeconds(1f);
			}
		}
	}

	void SpawnEnemy()
	{
		Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
	}
}
