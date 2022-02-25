using UnityEngine;

public class Parallax : MonoBehaviour {
    // To change the texture of the background we need to get the refrence to mesh renderer
    private MeshRenderer meshRenderer;
    // Speed at which the moving animation occours
    public float animationSpeed = 0.09f;

    private void Awake() {
        // Refrences the Mesh Renderer
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update() {
        // Moves the object inside the mesh renderer
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
