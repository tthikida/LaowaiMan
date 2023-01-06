using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class MouseWorld : MonoBehaviour
{
    [SerializeField] private LayerMask mousePlaneLayerMask;

    private static MouseWorld instance;
    

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        //transform.position = MouseWorld.GetPosition();
    }

    private void MoveSelectionSphere()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = MouseWorld.GetPosition();
            print("mouse down - getPosition");
        }
    }

    public static Vector3 GetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, instance.mousePlaneLayerMask);
        Debug.DrawLine(Camera.main.transform.position, raycastHit.point, Color.red, 1f);
        return raycastHit.point;
    }
    
}
