using UnityEngine;

public class PaintingControl : MonoBehaviour
{
    public static Vector3 paintingPos;
    public static Vector3 inventoryPos;
    public int id;
    
    //if the player clicks on the painting the camera gets the position of the painting
    private void OnMouseDown()
    {
        
        paintingPos = gameObject.transform.position;
        inventoryPos = gameObject.transform.position;
        ZoomCam.EnableCam(id);
    }
}
