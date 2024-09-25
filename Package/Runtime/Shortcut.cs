using UnityEngine.InputSystem;

namespace SDCInglis.ShortcutManager
{
	public class Shortcut
	{
		private readonly IShortcutListener _listener;
		private readonly ShortcutData _data;

		public Shortcut(IShortcutListener listener, ShortcutData data)
		{
			_listener = listener;
			_data = data;
		}

		public void Enable()
		{
			if (_data.Action is { enabled: false })
			{
				_data.Action.Enable();
				_data.Action.started += OnActionStarted;
				_data.Action.performed += OnActionPerformed;
				_data.Action.canceled += OnActionCancelled;
				_listener?.OnShortcutEnabled(_data);
			}
		}

		public void Disable()
		{
			if (_data.Action is { enabled: true })
			{
				_data.Action.Disable();
				_data.Action.started -= OnActionStarted;
				_data.Action.performed -= OnActionPerformed;
				_data.Action.canceled -= OnActionCancelled;
				_listener?.OnShortcutDisabled(_data);
			}
		}

		private void OnActionStarted(InputAction.CallbackContext context)
		{
			_listener?.OnShortcutStarted(_data, context);
		}

		private void OnActionPerformed(InputAction.CallbackContext context)
		{
			_listener?.OnShortcutPerformed(_data, context);
		}

		private void OnActionCancelled(InputAction.CallbackContext context)
		{
			_listener?.OnShortcutCancelled(_data, context);
		}
	}
}
