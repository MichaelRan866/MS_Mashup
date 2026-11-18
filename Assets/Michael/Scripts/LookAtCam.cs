using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    private void Update()
    {
        transform.LookAt(GameManager.cam.transform.position);
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, 0f);
    }
}
