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
		[SerializeReference, Required] private ISceneGetter sceneGetter = null;
		[ShowInInspector, ReadOnly] private static bool isLoading = false;

		public void HandleReaction()
		{
			if (sceneGetter != null)
				StartSceneLoading(sceneGetter.GetScene());
		}

		public void HandleReaction(string value) =>
			StartSceneLoading(value);

		private void StartSceneLoading(string sceneName)
		{
			if (!isLoading)
				Timing.RunCoroutine(LoadSceneAsync(sceneName));
		}

		private IEnumerator<float> LoadSceneAsync(string sceneName)
		{
			isLoading = true;
			AsyncOperation sceneLoading = SceneManager.LoadSceneAsync(sceneName);

			while (!sceneLoading.isDone)
				yield return 0f;

			Time.timeScale = 1f;
			isLoading = false;
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
		[SerializeField, Required, AssetSelector] private SceneAsset sceneAsset = null;
#endif
		[SerializeField, ReadOnly] private string sceneName = "";

		public string GetScene() =>
			sceneName;

#if UNITY_EDITOR
		public void OnAfterDeserialize()
		{

		}

		public void OnBeforeSerialize()
		{
			if (sceneAsset != null)
				sceneName = sceneAsset.name;
		}
#endif
	}

	public interface ISceneGetter
	{
		string GetScene();
	}
}
