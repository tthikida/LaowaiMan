using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GridDebugObject : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshPro;
    private object gridObject;

    public void SetGridObject(object gridObject)
    {
        this.gridObject = gridObject;
    }

        private void Update()
    {
            textMeshPro.text = gridObject.ToString();
    }
}
