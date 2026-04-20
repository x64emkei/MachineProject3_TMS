using BenchmarkDotNet.Attributes;
using MachineProject3_TMS;
using System;
using Microsoft.VSDiagnostics;

[CPUUsageDiagnoser]
public class RegisterUserBenchmark
{
    private string testUsername;
    private string testEmail;
    private string testPass;
    private string testName;
    private int counter = 0;
    [GlobalSetup]
    public void Setup()
    {
        // Use unique fake data per run to attempt to avoid immediate uniqueness constraints,
        // though depending on the real DB schema, it might still fail or hit DB limits.
        counter = new Random().Next(10000, 99999);
        testUsername = $"bench_user_{counter}";
        testEmail = $"bench_{counter}@example.com";
        testPass = "benchPass123";
        testName = "Benchmark User";
    }

    [Benchmark]
    public void BenchmarkRegisterUserDatabase()
    {
        // Call the newly extracted static method from the user code
        // We add a counter to try and avoid duplicate email/user errors breaking the benchmark flow
        counter++;
        FrmLogin.RegisterUserDatabase(testUsername + counter, testEmail + counter + "@bench.com", testPass, testName);
    }
}