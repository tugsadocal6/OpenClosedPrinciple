using UnityEngine;

public class TargettingSystem : MonoBehaviour
{
    private ITargetGetter targetGetter;

    private void Start()
    {
        targetGetter = GetComponent<ITargetGetter>();
        if (targetGetter == null) { return; }
        var targets = targetGetter.GetTargets(transform);
        foreach (Transform target in targets)
            Debug.Log(target.name);
    }
}
