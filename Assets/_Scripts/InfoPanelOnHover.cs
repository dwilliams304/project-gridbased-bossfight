using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanelOnHover : MonoBehaviour
{
    [SerializeField] private GameObject _infoPanel;

    [SerializeField] private float _scaleSpeed = 0.15f;

    public void OnHoverEnter(){
        _infoPanel.LeanScale(new Vector3(1f, 1f, 1f), _scaleSpeed);
    }

    public void OnHoverExit(){
        _infoPanel.LeanScale(new Vector3(0f, 0f, 0f), _scaleSpeed);
    }
}
