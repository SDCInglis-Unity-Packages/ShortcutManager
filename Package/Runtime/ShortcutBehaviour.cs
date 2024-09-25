using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace SDCInglis.ShortcutManager
{
	public class ShortcutBehaviour : MonoBehaviour, IShortcutListener
	{
		[SerializeField] private ShortcutData _shortcutData;
		[SerializeField] private Text _shortcutLabel;
		[SerializeField] private CanvasGroup _canvasGroup;

		private void OnEnable()
		{
			ShortcutManager.AddShortcutListener(this, _shortcutData);
		}

		private void OnDisable()
		{
			ShortcutManager.RemoveShortcutListener(this, _shortcutData);
		}

		public void OnShortcutEnabled(ShortcutData data)
		{
			if (_shortcutLabel != null)
				_shortcutLabel.text = data.DisplayString;

			if (_canvasGroup != null)
				_canvasGroup.alpha = 1;
		}

		public void OnShortcutDisabled(ShortcutData data)
		{
			if (_canvasGroup != null)
				_canvasGroup.alpha = 0;
		}

		public void OnShortcutStarted(ShortcutData data, InputAction.CallbackContext context)
		{
			Debug.Log("OnShortcutStarted");
		}

		public void OnShortcutPerformed(ShortcutData data, InputAction.CallbackContext context)
		{
			Debug.Log("OnShortcutPerformed");
		}

		public void OnShortcutCancelled(ShortcutData data, InputAction.CallbackContext context)
		{
			Debug.Log("OnShortcutCancelled");
		}
	}
}
