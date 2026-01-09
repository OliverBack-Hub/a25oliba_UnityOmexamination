using UnityEngine;
using UnityEngine.InputSystem;

public class KeyBind : MonoBehaviour
{
    public InputActionAsset oliverPlayerAction;
    public Animator oliverAnimator;

    // Update is called once per frame
    void Update()
    {
        if (oliverPlayerAction.FindAction("Walktest").IsPressed())
        {
            oliverAnimator.SetBool("Walk", true);
        }
        else
            oliverAnimator.SetBool("Walk", false);
    }
}
