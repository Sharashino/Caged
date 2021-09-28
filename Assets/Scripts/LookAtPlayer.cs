using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private GameObject playerObject;
    
    private void Start()
    {
        playerObject = GameManager.Instance.Player.gameObject;
    }

    void Update()
    {
        transform.LookAt(playerObject.transform);
    }
}
