using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
	public string prefabFolderPath;

	private float minSpawnInterval = 1f; 
	private float maxSpawnInterval = 3f; 
	private int minObjectsToSpawn = 1;
	private int maxObjectsToSpawn = 5;

	private List<GameObject> objectsToSpawn = new List<GameObject>();
	private float timeToNextSpawn;

	void Start()
	{
		LoadPrefabs();
		SetRandomSpawnTime();
	}

	void Update()
	{
		timeToNextSpawn -= Time.deltaTime;

		if (timeToNextSpawn <= 0f && objectsToSpawn.Count > 0)
		{
			int objectsToSpawnCount = Random.Range(minObjectsToSpawn, maxObjectsToSpawn + 1);

			for (int i = 0; i < objectsToSpawnCount; i++)
			{
				int randomIndex = Random.Range(0, objectsToSpawn.Count);
				GameObject selectedObject = objectsToSpawn[randomIndex];

				Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), transform.position.y, Random.Range(-10, 11));
				GameObject spawnedObject = Instantiate(selectedObject, randomSpawnPosition, Quaternion.identity);
				if (spawnedObject.GetComponent<DestroyObject>() == null)
				{
					spawnedObject.AddComponent<DestroyObject>();
				}
			}
			SetRandomSpawnTime();
		}
	}

	void LoadPrefabs()
	{
		GameObject[] loadedPrefabs = Resources.LoadAll<GameObject>(prefabFolderPath);

		foreach (GameObject prefab in loadedPrefabs)
		{
			objectsToSpawn.Add(prefab);
		}

		if (objectsToSpawn.Count == 0)
		{
			Debug.LogWarning("No prefabs found in the specified folder: " + prefabFolderPath);
		}
	}

	void SetRandomSpawnTime()
	{
		timeToNextSpawn = Random.Range(minSpawnInterval, maxSpawnInterval);
	}
}
