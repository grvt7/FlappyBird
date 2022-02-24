using UnityEngine;

public class Player : MonoBehaviour {
    private SpriteRenderer spriteRenderer; //Used to Change the Sprite in the current scene
    public Sprite[] sprites; // To collect all the sprites in the project to cycle through.
    private int spriteIndex = 0; // To keep track of the sprite in the sprites collection/array.
    private Vector3 direction;//Used to change the direction the bird is moving. Used to move the bird up or down.
    public float gravity = -9.8f;
    public float strength = 5f; //Used to dictate how much the bird will move up or down

    // Awake is called when Unity inits the game first time. Called only once in the lifecycle.
    private void Awake() {
        // Gets the sprite renderer component from the component on which the script is running
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Called the very first Frame when the object gets enabled
    private void Start() {
        // Invoke is a way of calling a function and this method calls the function repeatedly
        // Takes name of method to call, calls it first time using 2nd argument and repeats it in time using 3rd
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f); // Calls Animate Sprite

    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            direction = Vector3.up * strength;
            Debug.Log("SpaceBar");
        }
        // Bsic way to get touch input. I am not using it here
        // //For mobile. Check number of fingers touching the screen.
        // if(Input.touchCount > 0) {
        //     // Creates a touch object with the first finger that touched the screen as main
        //     Touch touch = Input.GetTouch(0);
        //     // Checks if the finger just touched the screeen 
        //     if(touch.phase == TouchPhase.Began){
        //         direction = Vector3.up * strength;
        //     }
        // }

        //DeltaTime is used to smooth out the movement as it makes sure that the time interval between 
        //frames remains same. Shorted frames will take more time and longer will take small time
        //thus making sure that the movement between the frames is smooth.
        // The final step is to apply gravity to the bird. Only applying gravity along y axis.
        direction.y += gravity * Time.deltaTime;

        // Then we move the position of the bird using transform
        transform.position += direction * Time.deltaTime;
    }

    private void AnimateSprite() {
        spriteIndex++;
        if(spriteIndex >= sprites.Length) {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }
}
