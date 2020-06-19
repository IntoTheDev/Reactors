using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class TextChanger : IReactor
	{
		[SerializeField, Required, SceneObjectsOnly] private TMP_Text _view = null;
		[SerializeField] private string _text = "";

		public void HandleReaction() =>
			_view.text = _text;
	}
}
