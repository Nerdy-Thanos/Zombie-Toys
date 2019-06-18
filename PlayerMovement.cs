using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float Position = 0.0f;
	void start()
	{
		Player.Set.Position = Vector3 (0.0f, 0.0f, 0.0f);
	}
	void update()
	{
		Player.Transform.Position = Random (Cursor.SetCursor);
	}
}
