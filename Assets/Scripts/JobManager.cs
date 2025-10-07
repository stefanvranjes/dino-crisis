using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;
using Unity.Jobs;

public class JobManager : MonoBehaviour
{
    public static JobManager instance;

    private int jobIndex;
    private NativeArray<JobHandle> handles;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        handles = new NativeArray<JobHandle>(110, Allocator.Persistent);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddJob(JobHandle handle)
    {
        handles[jobIndex++] = handle;
    }

    public void CompleteAll()
    {
        JobHandle.CompleteAll(handles);
        jobIndex = 0;
    }
}
