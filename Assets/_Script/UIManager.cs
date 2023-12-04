using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public GameObject btnReplay;

    private void Awake()
    {
        UIManager.Instance = this;

        this.btnReplay = GameObject.Find("ButtonReplay");
        this.btnReplay.SetActive(false);
    }
}
