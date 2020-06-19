using MEC;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ToolBox.Reactors
{
	public class SceneLoader : IReactor, IStringReactor
	{
		[SerializeReference, Required] private ISceneGetter _sceneGetter = null;
		[ShowInInspector, ReadOnly] private static bool _isLoading = false;

		public void HandleReaction()
		{
			if (_sceneGetter != null)
				StartSceneLoading(_sceneGetter.GetScene());
		}

		public void HandleReaction(string value) =>
			StartSceneLoading(value);

		private void StartSceneLoading(string sceneName)
		{
			if (!_isLoading)
				Timing.RunCoroutine(LoadSceneAsync(sceneName));
		}

		private IEnumerator<float> LoadSceneAsync(string sceneName)
		{
			_isLoading = true;
			AsyncOperation sceneLoading = SceneManager.LoadSceneAsync(sceneName);

			while (!sceneLoading.isDone)
				yield return 0f;

			Time.timeScale = 1f;
			_isLoading = false;
		}
	}

	public class SceneRestarter : ISceneGetter
	{
		public string GetScene() =>
			SceneManager.GetActiveScene().name;
	}

	public class SceneAssetSelector : ISceneGetter
#if UNITY_EDITOR
		, ISerializationCallbackReceiver
#endif
	{
#if UNITY_EDITOR
		[SerializeField, Required, AssetSelector] private SceneAsset _sceneAsset = null;
#endif
		[SerializeField, ReadOnly] private string _sceneName = "";

		public string GetScene() =>
			_sceneName;

#if UNITY_EDITOR
		public void OnAfterDeserialize()
		{

		}

		public void OnBeforeSerialize()
		{
			if (_sceneAsset != null)
				_sceneName = _sceneAsset.name;
		}
#endif
	}

	public interface ISceneGetter
	{
		string GetScene();
	}
}
