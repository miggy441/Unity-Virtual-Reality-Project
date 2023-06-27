using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MenuHandler : MonoBehaviour
{
    [SerializeField]
    private InputActionReference m_PressB;
    private bool menuBool;
    public UnityEvent menuOn, menuOff;

    public void OnEnable()
    {
        m_PressB.action.performed += MenuToggle;
    }

    public void OnDisable()
    {
        m_PressB.action.performed -= MenuToggle;
    }

    public void MenuToggle(InputAction.CallbackContext obj)
    {
        if (!menuBool)
            menuOn.Invoke(); //turn on event
        else  
            menuOff.Invoke();//turn off event
        
        menuBool = !menuBool;
    }
}
