using System;
using UnityEngine;

public class CAnMEshRender : MonoBehaviour
{
	public CanvasRenderer CanvasRenderer;

	public Material Material;

	private Mesh mesh;

	public Vector3[] newVertices;

	public Vector2[] newUV;

	public int[] newTriangles;

	private void Start()
	{
		this.mesh = new Mesh();
		this.CanvasRenderer.SetMaterial(this.Material, null);
	}

	private void Update()
	{
		this.mesh.Clear();
		this.mesh.vertices = this.newVertices;
		this.mesh.uv = this.newUV;
		this.mesh.triangles = this.newTriangles;
		this.CanvasRenderer.SetMesh(this.mesh);
	}
}
