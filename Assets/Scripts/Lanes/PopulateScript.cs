﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateScript : MonoBehaviour
{
	public static int laneWidth = 8;

    public virtual void Populate(LaneType? type = null, LaneScript laneScript = null) {
		Debug.Log($"{this.GetType()}.Populate()");
	}
}
