using System.Collections;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace AkatsukiMuckCheat
{
    class MainHack : MonoBehaviour
    {
        [SuppressMessage("ReSharper", "Unity.RedundantEventFunction")]
        private bool Menu = true;
        private bool Active = true;
        private string disableTitle;

        public void Start()
        {
            ClientSend.SendChatMessage("Hello Onii Chan ! iam saif good to meet u all UwU");
        }
        IEnumerator GodMod()
        {
            if (Active)
            {
                PlayerStatus _PlayerStatus = PlayerStatus.Instance;
                _PlayerStatus.speed = 11111;
                _PlayerStatus.hp = _PlayerStatus.maxHp+ 999;
                _PlayerStatus.stamina = _PlayerStatus.maxStamina;
                _PlayerStatus.hunger = _PlayerStatus.maxHunger;
                ClientSend.PlayerHp(_PlayerStatus.maxHp + 999, _PlayerStatus.maxHp+ 999);
                yield return new WaitForSeconds(0.5F);
            }
        }
        public void Update()
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.F1))
                {
                    Menu = !Menu;
                }
                if (Input.GetKeyDown(KeyCode.F2))
                {
                    Active = !Active;
                }
                if (Input.GetKeyDown(KeyCode.End))
                {
                    Loader.Unload();
                }
            }
        }

        public void OnGUI()
        {
            StartCoroutine(nameof(GodMod));
            if (Menu) { 
                GUI.Box(new Rect(20, 50, 160, 80), "<color=red>Muck Cheat - Mr28</color>");
                GUI.Label(new Rect( (150/2), 80, 170, 80), disableTitle);
                GUI.Label(new Rect((150/2), 100, 170, 80), "End / Exit");
                if (Active)
                {
                    disableTitle = "Activated <color=green>ON</color>";
                }
                else
                {
                    disableTitle = "Activated <color=red>OFF</color>";
                }
            }
        }
    }
}
