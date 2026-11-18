using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public Vector3 targetRotPivot;
    public float swayFactor;
    public float lerpSpeed;
    private Vector3 targetRot;
    private Vector2 pivot;

    void Start()
    {
        pivot = new Vector2(Screen.width, Screen.height) / 2f;

        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.menuOpen)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(targetRot), lerpSpeed * Time.deltaTime);
        Vector2 mousePos = Mouse.current.position.ReadValue();
        Vector3 cursorVec = new Vector3((mousePos.x - pivot.x) / (Screen.width / 2f), (mousePos.y - pivot.y) / (Screen.height / 2f));
        targetRot = targetRotPivot - new Vector3(cursorVec.y, -cursorVec.x, 0f) * swayFactor;
    }
}
