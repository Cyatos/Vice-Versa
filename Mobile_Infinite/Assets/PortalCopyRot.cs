﻿using UnityEngine;
using System.Collections;

public class PortalCopyRot : MonoBehaviour {

	public GameObject portalref;
	void Update () {
		transform.rotation = portalref.transform.rotation;
	}
}