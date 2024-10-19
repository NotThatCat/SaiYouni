using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nearby : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Tìm kẻ địch gần nhất
        BaiTap2(); // Tìm vật phẩm gần nhất
    }

    // Bài Tập 1: Tìm Kẻ Địch Gần Nhất
    Vector3 BaiTap1()
    {
        // Tạo danh sách các kẻ địch với tọa độ (x, y, z) trong không gian 3D
        int count = Random.Range(4, 10);
        List<Vector3> enemyPosition = new List<Vector3>();
        for (int i = 0; i < count; i++)
        {
            enemyPosition.Add(GetRandomPosition(-10, 10));
        }

        // Vị trí của người chơi được cung cấp
        Vector3 playerPosition = GetRandomPosition(-10, 10);

        // Sử dụng công thức khoảng cách Euclid hoặc Vector3.Distance() để tính khoảng cách
        // So sánh khoảng cách và tìm kẻ địch gần nhất
        Vector3 nearestEnemy = enemyPosition[0];
        float dis = Mathf.Infinity;
        foreach (Vector3 p in enemyPosition)
        {
            if (dis < Vector3.Distance(p, playerPosition))
            {
                dis = Vector3.Distance(p, playerPosition);
                nearestEnemy = p;
            }
        }

        // Trả về thông tin của kẻ địch gần nhất
        return nearestEnemy;

    }

    protected virtual Vector3 GetRandomPosition(int min, int max)
    {
        return new Vector3(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));
    }

    // Bài Tập 2: Tìm Vật Phẩm Gần Nhất
    Vector2 BaiTap2()
    {
        // Tạo danh sách các vật phẩm với tọa độ (x, y) trong không gian 2D
        int count = Random.Range(4, 10);
        List<Vector2> enemyPosition = new List<Vector2>();
        for (int i = 0; i < count; i++)
        {
            enemyPosition.Add(GetRandomPosition2D(-10, 10));
        }

        // Vị trí của người chơi được cung cấp
        Vector2 playerPosition = GetRandomPosition(-10, 10);

        // Tính khoảng cách từ người chơi đến từng vật phẩm
        // So sánh để tìm vật phẩm gần nhất
        Vector2 nearestEnemy = enemyPosition[0];
        float dis = Mathf.Infinity;
        foreach (Vector2 p in enemyPosition)
        {
            if (dis < Vector2.Distance(p, playerPosition))
            {
                dis = Vector2.Distance(p, playerPosition);
                nearestEnemy = p;
            }
        }

        // Trả về thông tin của vật phẩm gần nhất
        return nearestEnemy;
    }
    protected virtual Vector2 GetRandomPosition2D(int min, int max)
    {
        return new Vector2(Random.Range(min, max), Random.Range(min, max));
    }
}
