using UnityEngine;

public class PaintingExit : MonoBehaviour
{
    //on click of gameobject
    private void OnMouseDown()
    {
        ZoomCam.DisableCam();
    }
}
