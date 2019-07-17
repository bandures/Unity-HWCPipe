using System.Runtime.InteropServices;

namespace Unity.Profiling
{
    public static class HWCPipe
    {
        enum CpuCounter
        {
            Cycles = 0,
            Instructions,
            CacheReferences,
            CacheMisses,
            BranchInstructions,
            BranchMisses,
            MaxValue
        }

        enum GpuCounter
        {
            GpuCycles,
            VertexComputeCycles,
            FragmentCycles,
            TilerCycles,

            VertexComputeJobs,
            FragmentJobs,
            Pixels,

            Tiles,
            EarlyZTests,
            EarlyZKilled,
            LateZTests,
            LateZKilled,

            Instructions,
            DivergedInstructions,

            ShaderCycles,
            ShaderArithmeticCycles,
            ShaderLoadStoreCycles,
            ShaderTextureCycles,

            CacheReadLookups,
            CacheWriteLookups,
            ExternalMemoryReadAccesses,
            ExternalMemoryWriteAccesses,
            ExternalMemoryReadStalls,
            ExternalMemoryWriteStalls,
            ExternalMemoryReadBytes,
            ExternalMemoryWriteBytes,

            MaxValue
        }

        [DllImport("hwcpipe")]
        public static extern void Start();

        [DllImport("hwcpipe")]
        public static extern void Stop();

        [DllImport("hwcpipe")]
        public static extern void Sample();


        [DllImport("hwcpipe")]
        public static extern int CPU_GetNumCounters();

        [DllImport("hwcpipe")]
        public static extern bool CPU_IsCounterEnabled(int counterId);

        [DllImport("hwcpipe")]
        public static extern bool CPU_EnableCounter(int counterId);

        [DllImport("hwcpipe")]
        public static extern int CPU_GetCounterValue(int counterId);


        [DllImport("hwcpipe")]
        public static extern int GPU_GetNumCounters();

        [DllImport("hwcpipe")]
        public static extern bool GPU_IsCounterEnabled(int counterId);

        [DllImport("hwcpipe")]
        public static extern bool GPU_EnableCounter(int counterId);

        [DllImport("hwcpipe")]
        public static extern int GPU_GetCounterValue(int counterId);
    }
}
