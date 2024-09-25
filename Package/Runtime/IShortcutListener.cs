using UnityEngine.InputSystem;

namespace SDCInglis.ShortcutManager
{
	public interface IShortcutListener
	{
		void OnShortcutEnabled(ShortcutData data);
		void OnShortcutDisabled(ShortcutData data);
		void OnShortcutStarted(ShortcutData data, InputAction.CallbackContext context);
		void OnShortcutPerformed(ShortcutData data, InputAction.CallbackContext context);
		void OnShortcutCancelled(ShortcutData data, InputAction.CallbackContext context);
	}
}
