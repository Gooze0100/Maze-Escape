using UnityEngine;

public class MazeCell : MonoBehaviour
{
    [SerializeField] GameObject _leftWall;
    [SerializeField] GameObject _rightWall;
    [SerializeField] GameObject _frontWall;
    [SerializeField] GameObject _backWall;
    [SerializeField] GameObject _unvisitedBlock;

    public bool isVisited { get; private set; }

    public void Visit()
    {
        isVisited = true;
        _unvisitedBlock.SetActive(false);
    }

    public void ClearLeftWall()
    {
        _leftWall.SetActive(false);
    }
    public void ClearRightWall()
    {
        _rightWall.SetActive(false);
    }
    public void ClearFrontWall()
    {
        _frontWall.SetActive(false);
    }
    public void ClearBackWall()
    {
        _backWall.SetActive(false);
    }
}
