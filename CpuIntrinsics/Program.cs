// See https://aka.ms/new-console-template for more information
Console.WriteLine("System.Runtime.Intrinsics.X86:");

var hasX86Aes = System.Runtime.Intrinsics.X86.Aes.IsSupported;
var hasX86Avx = System.Runtime.Intrinsics.X86.Avx.IsSupported;
var hasX86Avx2 = System.Runtime.Intrinsics.X86.Avx2.IsSupported;
var hasX86AvxVnni = System.Runtime.Intrinsics.X86.AvxVnni.IsSupported;
var hasX86Bmi1 = System.Runtime.Intrinsics.X86.Bmi1.IsSupported;
var hasX86Bmi2 = System.Runtime.Intrinsics.X86.Bmi2.IsSupported;
var hasX86Fma = System.Runtime.Intrinsics.X86.Fma.IsSupported;
var hasX86Lzcnt = System.Runtime.Intrinsics.X86.Lzcnt.IsSupported;
var hasX86Pclmulqdq = System.Runtime.Intrinsics.X86.Pclmulqdq.IsSupported;
var hasX86Popcnt = System.Runtime.Intrinsics.X86.Popcnt.IsSupported;
var hasX86Sse = System.Runtime.Intrinsics.X86.Sse.IsSupported;
var hasX86Sse2 = System.Runtime.Intrinsics.X86.Sse2.IsSupported;
var hasX86Sse3 = System.Runtime.Intrinsics.X86.Sse3.IsSupported;
var hasX86Sse41 = System.Runtime.Intrinsics.X86.Sse41.IsSupported;
var hasX86Sse42 = System.Runtime.Intrinsics.X86.Sse42.IsSupported;
var hasX86Ssse3 = System.Runtime.Intrinsics.X86.Ssse3.IsSupported;
var hasX86Base = System.Runtime.Intrinsics.X86.X86Base.IsSupported;
Console.WriteLine($"X86.Aes.IsSupported = {hasX86Aes}");
Console.WriteLine($"X86.Avx.IsSupported = {hasX86Avx}");
Console.WriteLine($"X86.Avx2.IsSupported = {hasX86Avx2}");
Console.WriteLine($"X86.AvxVnni.IsSupported = {hasX86AvxVnni}");
Console.WriteLine($"X86.Bmi1.IsSupported = {hasX86Bmi1}");
Console.WriteLine($"X86.Bmi2.IsSupported = {hasX86Bmi2}");
Console.WriteLine($"X86.Fma.IsSupported = {hasX86Fma}");
Console.WriteLine($"X86.Lzcnt.IsSupported = {hasX86Lzcnt}");
Console.WriteLine($"X86.Pclmulqdq.IsSupported = {hasX86Pclmulqdq}");
Console.WriteLine($"X86.Popcnt.IsSupported = {hasX86Popcnt}");
Console.WriteLine($"X86.Sse.IsSupported = {hasX86Sse}");
Console.WriteLine($"X86.Sse2.IsSupported = {hasX86Sse2}");
Console.WriteLine($"X86.Sse3.IsSupported = {hasX86Sse3}");
Console.WriteLine($"X86.Sse41.IsSupported = {hasX86Sse41}");
Console.WriteLine($"X86.Sse42.IsSupported = {hasX86Sse42}");
Console.WriteLine($"X86.Ssse3.IsSupported = {hasX86Ssse3}");
Console.WriteLine($"X86.X86Base.IsSupported = {hasX86Base}");

Console.WriteLine();
Console.WriteLine("System.Runtime.Intrinsics.Arm:");

var hasArmAdvSimd = System.Runtime.Intrinsics.Arm.AdvSimd.IsSupported;
var hasArmAes = System.Runtime.Intrinsics.Arm.Aes.IsSupported;
var hasArmArmBase = System.Runtime.Intrinsics.Arm.ArmBase.IsSupported;
var hasArmCrc32 = System.Runtime.Intrinsics.Arm.Crc32.IsSupported;
var hasArmDp = System.Runtime.Intrinsics.Arm.Dp.IsSupported;
var hasArmRdm = System.Runtime.Intrinsics.Arm.Rdm.IsSupported;
var hasArmSha1 = System.Runtime.Intrinsics.Arm.Sha1.IsSupported;
var hasArmSha256 = System.Runtime.Intrinsics.Arm.Sha256.IsSupported;
Console.WriteLine($"Arm.AdvSimd.IsSupported = {hasArmAdvSimd}");
Console.WriteLine($"Arm.Aes.IsSupported = {hasArmAes}");
Console.WriteLine($"Arm.ArmBase.IsSupported = {hasArmArmBase}");
Console.WriteLine($"Arm.Crc32.IsSupported = {hasArmCrc32}");
Console.WriteLine($"Arm.Dp.IsSupported = {hasArmDp}");
Console.WriteLine($"Arm.Rdm.IsSupported = {hasArmRdm}");
Console.WriteLine($"Arm.Sha1.IsSupported = {hasArmSha1}");
Console.WriteLine($"Arm.Sha256.IsSupported = {hasArmSha256}");

Console.WriteLine();
Console.WriteLine("System.Runtime.GCSettings:");

var isServerGC = System.Runtime.GCSettings.IsServerGC;
var largeObjectHeapCompactionMode = System.Runtime.GCSettings.LargeObjectHeapCompactionMode;
var latencyMode = System.Runtime.GCSettings.LatencyMode;
Console.WriteLine($"GCSettings.IsServerGC = {isServerGC}");
Console.WriteLine($"GCSettings.LargeObjectHeapCompactionMode = {largeObjectHeapCompactionMode}");
Console.WriteLine($"GCSettings.LatencyMode = {latencyMode}");

_ = Console.ReadKey();