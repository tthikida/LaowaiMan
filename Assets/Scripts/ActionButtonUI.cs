using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActionButtonUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private ActionButtonUI button;


    public void SetBaseAction(BaseAction baseAction)
    {
        textMeshPro.text = baseAction.GetActionName().ToUpper();



        button.onClick.AddListener(() => {
            print("button clicked");
            UnitActionSystem.Instance.SetSelectedAction(baseAction);

            print("baseAction: " + baseAction);

        });

        //button.onClick.AddListener(MoveActionBtn_Click);
    }

    private void MoveActionBtn_Click()
    {
        print("clicked");


    }
}
