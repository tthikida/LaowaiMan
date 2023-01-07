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
<<<<<<< HEAD


        button.onClick.AddListener(() => {
            print("button clicked");
            UnitActionSystem.Instance.SetSelectedAction(baseAction);
            print(baseAction);
        });

        //button.onClick.AddListener(MoveActionBtn_Click);
    }

    private void MoveActionBtn_Click()
    {
        print("clicked");

=======
>>>>>>> parent of cd48d16 (addListener working)
    }
}
