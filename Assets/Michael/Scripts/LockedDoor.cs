using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public Vector3 defaultPos;
    public Vector3 openPos;
    public Material glowMat;
    public bool open;

    private void Start() 
    {
        defaultPos = transform.localPosition;
    }
    private void Update()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, open ? openPos : defaultPos, 15f * Time.deltaTime);
        glowMat.SetColor("_EmissionColor", (open ? Color.green : Color.red) * 6f);
    }

    public void Open() { open = true; }
}
