using UnityEngine;

public class Parallax : MonoBehaviour {
    // To change the texture of the background we need to get the refrence to mesh renderer
    private MeshRenderer meshRenderer;
    public float animationSpeed = 0.09f;

    private void Awake() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update() {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
