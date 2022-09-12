# CpuIntrinsics
Check if CPU has some instruction set using .NET and C#.


# Running in an Apple M1:
System.Runtime.Intrinsics.Arm:
Arm.AdvSimd.IsSupported = True
Arm.Aes.IsSupported = False
Arm.ArmBase.IsSupported = True
Arm.Crc32.IsSupported = True
Arm.Dp.IsSupported = False
Arm.Rdm.IsSupported = False
Arm.Sha1.IsSupported = False
Arm.Sha256.IsSupported = False

System.Runtime.GCSettings:
GCSettings.IsServerGC = False
GCSettings.LargeObjectHeapCompactionMode = Default
GCSettings.LatencyMode = Interactive
