﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class TrashSlot : Selectable
{
    internal Inventory inventory;

    public override void OnPointerUp(PointerEventData eventData)
    {
        if(inventory.Changing)
        {
            inventory.SwitchIndex(inventory.CurrentItemIndex, Inventory.Trash);

            inventory.CurrentItemIndex = Inventory.NoIndex;
            inventory.TargetItemIndex = Inventory.NoIndex;
        }
    }

    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (inventory.Changing)
        {
            inventory.TargetItemIndex = Inventory.Trash;
        }
    }
}