
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Admin_Players : UdonSharpBehaviour
{
    [SerializeField] GameObject[] adminObjects;
    [SerializeField] string[] adminUsers;
    void Start()
    {
        foreach(string adminPlayers in adminUsers) {
            if (Networking.LocalPlayer.displayName == adminPlayers) {
                 foreach(GameObject go in adminObjects) {
                  go.SetActive(true);
                 }
             }
         }
    }
}
