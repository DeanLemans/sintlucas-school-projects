using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] private Transform player; 
    [SerializeField] private Vector3 offset;   
    //makes it so that the cam follows the player
    private void LateUpdate()
    {
        transform.position = new Vector3(player.position.x + offset.x, offset.y, offset.z);
    }
}
