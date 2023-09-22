using NUnit.Framework;

namespace LoopExercises;

public class LoopExercisesTests
{
    private Loop_Exercises exercise;
    
    [SetUp]
    public void SetUp()
    {
        exercise = new Loop_Exercises();
    }
    
    [Test]
    public void TestSumOfNNumbers()
    {
        Assert.AreEqual(15, exercise.SumOfNNumbers(5));
    }
    
    [Test]
    public void TestFactorial()
    {
        Assert.AreEqual(120, exercise.Factorial(5));
    }
    
    [Test]
    public void TestFibonacciSeries()
    {
        CollectionAssert.AreEqual(new List<int> { 0, 1, 1, 2, 3 }, exercise.FibonacciSeries(5));
    }
    
    [Test]
    public void TestCountDigits()
    {
        Assert.AreEqual(5, exercise.CountDigits(12345));
    }
    
    [Test]
    public void TestReverseNumber()
    {
        Assert.AreEqual(54321, exercise.ReverseNumber(12345));
    }
    
    [Test]
    public void TestCalculatePower()
    {
        Assert.AreEqual(8, exercise.CalculatePower(2, 3));
    }
    
    [Test]
    public void TestMultiplicationTable()
    {
        CollectionAssert.AreEqual(new List<string> { "5x1=5", "5x2=10", "5x3=15" }, 
            exercise.MultiplicationTable(5, 3));
    }
    
    [Test]
    public void TestSumOfDigits()
    {
        Assert.AreEqual(6, exercise.SumOfDigits(123));
    }
    
    [Test]
    public void TestIsArmstrong()
    {
        Assert.IsTrue(exercise.IsArmstrong(153));
        Assert.IsFalse(exercise.IsArmstrong(123));
    }

    [Test]
    public void TestPrimeNumbersUpToN()
    {
        CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 7 }, 
            exercise.PrimeNumbersUpToN(10));
    }









}