using UnityEngine;

public class Ender : MonoBehaviour
{
    public Animator anim;

    public void End()
    {
        anim.SetBool("end", true);
    }
}
