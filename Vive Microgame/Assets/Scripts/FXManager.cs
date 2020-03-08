using UnityEngine;

public class FXManager : MonoBehaviour
{
    public static FXManager Instance { get; private set; }

    public GameObject turkeyFX;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        turkeyFX.SetActive(false);
    }

    public void EnableFX()
    {
        turkeyFX.SetActive(true);
    }
}
