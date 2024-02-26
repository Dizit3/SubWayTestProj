using DG.Tweening;
using UnityEngine;

public class RegistrationMenuAnimation : MonoBehaviour
{
    [SerializeField] private Vector3 targetPos;
    [SerializeField] private float animSpeed = 0f;


    private void Start()
    {
        transform.DOMoveY(targetPos.y, animSpeed);

    }


}
