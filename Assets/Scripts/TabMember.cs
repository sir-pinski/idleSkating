// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Events;
// using UnityEngine.EventSystems;
// using UnityEngine.UIElements;
// using Image = UnityEngine.UI.Image;
//
// [System.Serializable]
// public class MyStringEvent : UnityEvent<string>
// {
// }
//
// public class TabMember : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler
// {
//     
//     public GameObject tabGroup; // An object representing a group of tabs
//     // public TabManager tabManager; // The general tab manager
//     public Image parentImage;
//     public MyStringEvent onClick;
//     public String tabScreenName;
//
//     public bool active;
//     public bool mouseOver;
//     public bool mouseDown;
//
//     public Color normalColor = new Color(0.7f,0.7f,0.7f);
//     public Color highlightedColor = new Color(0.9f,0.9f,0.9f);
//     public Color pressedColor = new Color(0.6f,0.6f,0.6f);
//     public Color selectedColor = new Color(0.8f,0.8f,0.8f);
//     
//     // Start is called before the first frame update
//     void Start()
//     {
//         active = false;
//         mouseOver = false;
//         mouseDown = false;
//         
//         TabManager.RegisterTab(tabGroup, this);
//
//         parentImage.color = normalColor;
//     }
//
//     // Update is called once per frame
//     private void Update()
//     {
//         if (mouseDown)
//         {
//             parentImage.color = highlightedColor;
//         }
//         else if (mouseOver)
//         {
//             parentImage.color = pressedColor;
//         }
//         else if (active)
//         {
//             parentImage.color = selectedColor;
//         }
//         else
//         {
//             parentImage.color = normalColor;
//         }
//     }
//
//     public void OnPointerEnter(PointerEventData ped)
//     {
//         mouseOver = true;
//     }
//
//     public void OnPointerExit(PointerEventData eventData)
//     {
//         mouseOver = false;
//     }
//
//     public void OnPointerClick(PointerEventData eventData)
//     {
//         TabManager.ClickTab(tabGroup, this);
//         onClick.Invoke(tabScreenName);
//     }
//
//     public void OnPointerDown(PointerEventData eventData)
//     {
//         mouseDown = true;
//     }
//
//     public void OnPointerUp(PointerEventData eventData)
//     {
//         mouseDown = false;
//     }
// }
