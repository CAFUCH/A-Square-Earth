using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAction : AIAction
{
    public override void TakeAction() {

        aiBrain.SetDestinationF(aiBrain.target.position, 7f);
    }
}
