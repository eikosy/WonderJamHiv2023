﻿using System;
using Game.Scripts.Quests;
using UnityEngine;

namespace Game.Scripts.Interaction
{
    [RequireComponent(typeof(StatTriggerComponent))]
    public class CollectItem1 : MonoBehaviour, IInteractable
    {
        private StatTriggerComponent _statTriggerComponent;

        private void Awake()
        {
            _statTriggerComponent = GetComponent<StatTriggerComponent>();
        }

        public void VFX()
        { 

            Debug.Log("Interacting with" + gameObject.name);
            gameObject.SetActive(false);

        }

        public void Interact()
        {
            if (!_statTriggerComponent.Trigger()) return;
            VFX();
            OnInteractionSuccess();

        }

        public void OnInteractionSuccess()
        {
            gameObject.layer = 0;
        }
       

       
    }
}