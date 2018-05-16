﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceResources : MonoBehaviour {

	public ButtonUi ButtonPrefab { get; private set; }
	public Canvas MainCanvas { get; private set; }
	public LayoutGroup MainPanel { get; private set; }
	//public SliderUI ProgressbarPrefab { get; private set; }
	private void Awake()
	{
		ButtonPrefab = Resources.Load<ButtonUi>("Button");
		MainCanvas = FindObjectOfType<Canvas>();
		//ProgressbarPrefab = Resources.Load<SliderUI>("Progressbar");
		MainPanel = MainCanvas.GetComponentInChildren<LayoutGroup>();
	}
}
