using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 12f);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }

}
