using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] private Unit unit;

    void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            List<GridPosition> positionList = unit.GetMoveAction().GetValidActionGridPositionList();
            foreach(GridPosition position in positionList)
            {
                print("Position: " + position);
            }
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            GridSystemVisual.Instance.HideAllGridPositions();
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            GridSystemVisual.Instance.ShowGridPositionList(unit.GetMoveAction().GetValidActionGridPositionList());
        }
    }
}
