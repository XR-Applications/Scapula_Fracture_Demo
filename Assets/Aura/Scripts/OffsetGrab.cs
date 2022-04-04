using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class OffsetGrab : XRGrabInteractable
{
    [SerializeField] TextMeshProUGUI debugText;
    //store position of the hand
    private Vector3 interactorPos = Vector3.zero;

    //store rotation of the hand
    private Quaternion interactorRotation = Quaternion.identity;

    //method called when selection action triggered
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        StoreInteractor(args.interactor);
        MatchAttachment(args.interactor);
    }

    private void StoreInteractor(XRBaseInteractor interactor)
    {
        //store interactor pos and rotation (mostly for reset purposes, doubt i'll use it)
        interactorPos = interactor.attachTransform.localPosition;
        interactorRotation = interactor.attachTransform.localRotation;
    }

    private void MatchAttachment(XRBaseInteractor interactor)
    {
        //move the interactor to the attachment point of the interactable
        //if it has an attachment point that is
        bool hasAttachment = attachTransform != null;
        interactor.attachTransform.position = hasAttachment? attachTransform.position : transform.position;
        interactor.attachTransform.rotation = hasAttachment ? attachTransform.rotation : transform.rotation;
    }

}
