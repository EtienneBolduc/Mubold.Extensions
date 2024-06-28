using System.Reactive.Disposables;

namespace Mubold.Extensions;

public static class DisposableMixins
{
	public static T DisposeWith<T>(this T item, CompositeDisposable compositeDisposable)
		where T : IDisposable
	{
		if (compositeDisposable is null)
		{
			throw new ArgumentNullException(nameof(compositeDisposable));
		}

		compositeDisposable.Add(item);
		return item;
	}
}