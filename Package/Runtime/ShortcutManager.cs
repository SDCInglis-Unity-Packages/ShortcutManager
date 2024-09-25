using System.Collections.Generic;
using JetBrains.Annotations;

namespace SDCInglis.ShortcutManager
{
	public class ShortcutManager
	{
		[NotNull] private static Shortcut _shortcut;

		public static void AddShortcutListener(IShortcutListener listener, ShortcutData data)
		{
			_shortcut = new Shortcut(listener, data);
			_shortcut.Enable();
		}

		public static void RemoveShortcutListener(IShortcutListener listener, ShortcutData data)
		{
			_shortcut.Disable();
		}
	}
}
