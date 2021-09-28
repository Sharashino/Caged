using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public PlayerStats Player
    {
        get => player;
        set => player = value;
    }

    private void Awake()
    {
        if (!Instance) Instance = this;
    }

    [SerializeField] private PlayerStats player;
}
