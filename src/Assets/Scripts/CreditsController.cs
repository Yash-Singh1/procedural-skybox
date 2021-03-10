using UnityEngine;

public class CreditsController : MonoBehaviour
{
    public Animator playerAnim;
    bool creditsShown;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && creditsShown)
        {
            playerAnim.SetTrigger("hide");
            creditsShown = false;
        }
    }

    public void ShowCredits()
    {
        playerAnim.SetTrigger("show");
        creditsShown = true;
    }
}