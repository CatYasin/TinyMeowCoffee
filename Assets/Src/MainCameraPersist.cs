using UnityEngine;

public class MainCameraPersist : MonoBehaviour
{
 
    private static MainCameraPersist instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}

