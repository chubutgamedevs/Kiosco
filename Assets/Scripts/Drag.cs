using UnityEngine;

public class Drag : MonoBehaviour
{

    private Vector3 dragOffset;
    //private Vector3 parentDragOffset;

    public Camera cam;
    private Vector3 origin;
    public bool dragEnabled;
    [SerializeField] Transform target;
    [SerializeField] float snap = 0.1f;
    void Awake()
    {
        dragEnabled = true;

        if (!cam)
        {
            cam = Camera.main;
        }
    }
    private void Start()
    {
        origin = transform.position;
    }

    void OnMouseDown()
    {
        dragOffset = transform.position - GetMousePos();
        target.gameObject.SetActive(true);
    }
    private void OnMouseUp()
    {

        target.gameObject.SetActive(false);
        if (Vector3.Distance(target.position, transform.position) < snap)
        {

            transform.position = target.position;

        }
        else
        {
            transform.position = origin;
        }
    }

    void OnMouseDrag()
    {
        if (dragEnabled)
        {

            transform.position = GetMousePos() + dragOffset;

        }
    }


    Vector3 GetMousePos()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = -cam.transform.position.z + transform.position.z;
        return cam.ScreenToWorldPoint(mousePos);
    }

    public void enableDrag()
    {
        dragEnabled = true;
    }
    public void disableDrag()
    {
        dragEnabled = false;
    }




}