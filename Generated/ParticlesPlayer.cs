using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class ParticlesPlayer : IReactor
	{
		[SerializeField, Required, SceneObjectsOnly] private ParticleSystem _particleSystem = null;

		public void HandleReaction() =>
			_particleSystem.Play();
	}
}
