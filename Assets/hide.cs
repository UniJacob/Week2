using UnityEngine;
using UnityEngine.InputSystem;

public class Hide : MonoBehaviour
{
    [SerializeField]
    public InputAction hideAction = new InputAction(type: InputActionType.Button);
    private bool isHidden = false;

    private void OnValidate()
    {
        if (hideAction.bindings.Count == 0)
        {
            hideAction.AddBinding("<Keyboard>/space");
        }
    }

    private void OnEnable()
    {
        hideAction.Enable();
    }

    private void OnDisable()
    {
        hideAction.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hideAction.WasPressedThisFrame())
        {
            if (isHidden)
            {
                GetComponent<SpriteRenderer>().enabled = true;
            }
            else if (!isHidden)
            {
                GetComponent<SpriteRenderer>().enabled = false;
            }
            isHidden = !isHidden;
        }
    }
}
