using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent onClick;
    public GameObject lmbIcon;
    public AudioClip clickSnd;
    private GameObject clickPrompt;
    protected bool hovering;

    private void Start()
    {
        clickPrompt = Instantiate(lmbIcon);
        clickPrompt.transform.parent = transform;
        clickPrompt.transform.localPosition = Vector3.zero;
    }
    private void Update()
    {
        clickPrompt.SetActive(!GameManager.menuOpen && hovering);

        if (clickPrompt.activeInHierarchy)
        {
            if (GameManager.Click.WasPerformedThisFrame())
            {
                if (clickSnd)
                    AudioSource.PlayClipAtPoint(clickSnd, GameManager.cam.transform.position);
                onClick.Invoke();
            }
        }
    }

    private void OnMouseEnter()
    {
        hovering = true;
    }
    private void OnMouseExit()
    {
        hovering = false;
    }
}
