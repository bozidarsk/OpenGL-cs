using System;
using System.Collections.Generic;
using System.Linq;

using static OpenGL.Methods;
using static OpenGL.Constants;

namespace OpenGL;

public class SceneObject 
{
	private List<Component> components = new();

	public void AddComponent<T>(T component) where T : Component => components.Add(component);
	public T GetComponent<T>() where T : Component => (T)components.Where(x => x is T).Single();
	public bool TryGetComponent<T>(out T component) where T : Component
	{
		component = ((T?)components.Where(x => x is T).SingleOrDefault())!;
		return component == null;
	}

	public SceneObject(params Component[] components) : this((IEnumerable<Component>)components) {}
	public SceneObject(IEnumerable<Component> components) => this.components.AddRange(components);
}
