//
// using System.Collections.Generic;
// using UnityEngine;
//
// public class TabElement
// {
//     public GameObject TabGroup;
//     public TabMember TabMember;
//
//     public TabElement(GameObject tG, TabMember tM)
//     {
//         TabGroup = tG;
//         TabMember = tM;
//     }
// }
//
// public static class TabManager
// {
//
//     private static List<TabElement> Tabs = new List<TabElement>();
//
//     
//     // Adds the tab to the list of tabs and groups
//     public static void RegisterTab(GameObject tabGroup, TabMember tabMember)
//     {
//         Tabs.Add(new TabElement(tabGroup,tabMember));
//     }
//
//     public static void ClickTab(GameObject tG, TabMember tM)
//     {
//         for (int i = 0; i < Tabs.Count; i++)
//         {
//             if (Tabs[i].TabGroup == tG)
//             {
//                 if (Tabs[i].TabMember != tM)
//                 {
//                     Tabs[i].TabMember.active = false;
//                 }
//                 else
//                 {
//                     Tabs[i].TabMember.active = true;
//                 }
//             }
//         }
//     }
//     
// }
//
