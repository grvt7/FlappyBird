using UnityEngine;

public class Spawner : MonoBehaviour {
    // Creating a refrence to prefabs
    public GameObject prefab;
    // Spawn rate for new pipes
    public float spawnRate = 1f;
    // Min height where the pipes will be created
    public float minHeight = -1;
    // Max height for pipes
    public float maxHeight = +1;

// Repeateadly call Spawn function while the game is running
    private void OnEnable() {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

// Stop calling the spawn function when game is disabled
    private void OnDisable() {
        CancelInvoke(nameof(Spawn));
    }

// To add/spawn new pipes
    private void Spawn() {
        // Instantiate pipes using the prefabs, at the position of spawner, without rotation
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }

}
