using UnityEngine;

public abstract class Manager<T> : MonoBehaviour where T : Manager<T>
{
    private static T instance;

    public static T Instance => instance;

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = GetComponent<T>();
        }
        else
        {
            Destroy(gameObject);
        }

        OnAwake();
    }

    private void Start()
    {
        Init();
        OnStart();
    }

    protected virtual void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }

    protected virtual void OnAwake() { }

    protected virtual void OnStart() { }

    protected virtual void Init() { }
}
