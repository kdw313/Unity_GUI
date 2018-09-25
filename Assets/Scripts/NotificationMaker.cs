using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Notification maker.
/// Author: Shawn Kim
/// Created Date: 2018-09-25
/// Last Modified: 2018-09-25
/// </summary>
public class NotificationMaker : MonoBehaviour {

    [SerializeField]
    private Animator notificationBarAnimator;

    [SerializeField]
    private Image notificationImageBG;

    [SerializeField]
    private Text notificationTextTitle;

    [SerializeField]
    private Text notificationTextMessage;

    [SerializeField]
    private Image notificationImageIcon;

    [SerializeField]
    private Sprite info;

    [SerializeField]
    private Sprite warning;

    private IEnumerator coroutine;

    private void Start()
    {
        //coroutine = FromBottomToTop();
    }

    private void Update()
    {
        if (IsAnimatorPlaying())
        {
            notificationBarAnimator.SetBool("Up", false);
        } 
    }

    /// <summary>
    /// Notifies from bottom.
    /// </summary>
    /// <param name="id">Identifier (1: informing, 2: warning).</param>
    void NotifyFromBottom(short id)
    {

        switch(id)
        {
            case 1:
                ChangeBGColor(10, 200, 10);
                ChangeText("Hello World", "This is Notificaiton");
                notificationImageIcon.sprite = info;
                notificationBarAnimator.SetBool("Up", true);
            break;

            case 2:
                ChangeBGColor(200, 10, 10);
                ChangeText("Hello World", "This is Warning");
                notificationImageIcon.sprite = warning;
                notificationBarAnimator.SetBool("Up", true);
            break;

            default:
            break;
        }

    }


    /// <summary>
    /// Changes the BGC olor.
    /// </summary>
    /// <param name="R">R: red value of the color in byte.</param>
    /// <param name="G">G: green value of the color in byte.</param>
    /// <param name="B">B: green value of the color in byte.</param>
    private void ChangeBGColor(byte R, byte G, byte B)
    {
        notificationImageBG.color = new Color32(R, G, B, 255);
    }


    /// <summary>
    /// Changes the text.
    /// </summary>
    /// <param name="title">Title.</param>
    /// <param name="msg">Message.</param>
    private void ChangeText(string title, string msg)
    {
        notificationTextTitle.text = 
            notificationTextTitle.text.Replace(notificationTextTitle.text,
                                               title);
        
        notificationTextMessage.text = 
            notificationTextMessage.text.Replace(notificationTextMessage.text,
                                                 msg);
    }

    /// <summary>
    /// Ises the animator playing.
    /// </summary>
    /// <returns><c>true</c>, if animator playing was ised, <c>false</c> otherwise.</returns>
    bool IsAnimatorPlaying()
    {
        return notificationBarAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1;
    }
}
