namespace ToolBox.Reactors
{
	public interface IBaseReactor { }

	public interface IReactor : IBaseReactor
	{
		void HandleReaction();
	}

	public interface IReactor<T> : IBaseReactor
	{
		void HandleReaction(T value);
	}
}
