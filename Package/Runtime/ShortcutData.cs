using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SDCInglis.ShortcutManager
{
	[Serializable]
	public struct ShortcutData
	{
		[SerializeField] private InputActionReference _inputAction;
		[SerializeField] private string _displayName;

		public InputAction Action => _inputAction != null ? _inputAction.action : null;
		public string DisplayString => $"{_displayName} | {Action?.GetBindingDisplayString()}";
	}
}
