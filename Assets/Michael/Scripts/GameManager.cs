using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public InputActionAsset actions;
    public static InputAction Click;
    public static Camera cam;
    public static bool menuOpen;

    private void Awake()
    {
        actions.Enable();
        Click = actions.FindAction("Click");
        cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }
    public void SetMenuOpen(bool newVal) { menuOpen = newVal; }
    public static void PlaySnd(AudioClip snd, float vol = 1f) { AudioSource.PlayClipAtPoint(snd, cam.transform.position, vol); }
    public void PlaySnd_(AudioClip snd) { AudioSource.PlayClipAtPoint(snd, cam.transform.position); }
}
