using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class ZoomCam : MonoBehaviour
{
    public static bool camOn = false;
    public static Camera zoomCam;
    public static GameObject inventory;
    private float timer = .2f;
    private static bool timerRunning = false;
    public static int currentPaintingId = -1;
   

    private void Start()
    {
       
        inventory = Refferences.Instance.Inventory;
        zoomCam = GetComponent<Camera>();
        zoomCam.enabled = false;
        inventory.SetActive(false);
        camOn = false;
    }
    //moves the cam to the painting and enables it
    public static void EnableCam(int paintingId)
    {
        currentPaintingId = paintingId;

        Vector3 camPos = PaintingControl.paintingPos;
        camPos = new Vector3(camPos.x, 3.95f, 16.46f);
        
        //camRot = zoomCam.transform.rotation(camPos,camPos,camPos);
        Vector3 invPos = PaintingControl.inventoryPos;
        invPos = new Vector3(invPos.x, 2.25f, 20.26f);

        inventory.transform.position = invPos;
        zoomCam.transform.position = camPos;
        zoomCam.enabled = true;
        inventory.SetActive(true);
        timerRunning = true;
        InventoryManager.Instance.ListItems();
    }
    //disables the cam
    public static void DisableCam()
    {
        zoomCam.enabled = false;
        inventory.SetActive(false);
        camOn = false;
        currentPaintingId = -1;
    }
    //when escaped is clicked do these actions
    public void EscapeClicked(InputAction.CallbackContext ctx)
    {
        //when start input
        //if (ctx.started) { }
        //when pressed in
        if (ctx.performed)
        {
            DisableCam();
        }
        //When button released
        //if (ctx.canceled) { }
    }

    public void Update()
    {
        if (timerRunning)
        {
            timer -= Time.deltaTime;

            if (timer <= 0.0f)
            {
                camOn = true ;
                timerRunning = false;
            }
        }
    }
}
