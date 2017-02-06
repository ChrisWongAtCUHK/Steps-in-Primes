using System;
using NUnit.Framework;

[TestFixture]
public static class StepInPrimesTests {

[Test]
    public static void test1() {
        Assert.AreEqual(new int[] {101, 103}, StepInPrimes.Step(2,100,110));
        Assert.AreEqual(new int[] { 103, 107 }, StepInPrimes.Step(4, 100, 110));
        Assert.AreEqual(new int[] { 101, 107 }, StepInPrimes.Step(6, 100, 110));
        Assert.AreEqual(new int[] { 359, 367 }, StepInPrimes.Step(8, 300, 400));
        Assert.AreEqual(new int[] { 307, 317 }, StepInPrimes.Step(10, 300, 400));
    }
}

